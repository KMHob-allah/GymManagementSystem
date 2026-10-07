using System;
using System.Security.Cryptography;
using System.Text;

namespace GymManagementSystem.BLL.Security
{
    public static class PasswordHasher
    {
        private const byte CurrentVersion = 1;

        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100000;

        private const int HeaderSize = 1 + 4;
        private const int StoredValueSize = HeaderSize + SaltSize + HashSize;

        public static byte[] HashPassword(string password)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));

            byte[] salt = new byte[SaltSize];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash;

            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(
                    password,
                    salt,
                    Iterations,
                    HashAlgorithmName.SHA256))
            {
                hash = pbkdf2.GetBytes(HashSize);
            }

            byte[] result = new byte[StoredValueSize];

            result[0] = CurrentVersion;

            byte[] iterationBytes = BitConverter.GetBytes(Iterations);

            Buffer.BlockCopy(iterationBytes,0,result,1,4);

            Buffer.BlockCopy(salt,0,result,HeaderSize,SaltSize);

            Buffer.BlockCopy(hash,0,result,HeaderSize + SaltSize,HashSize);

            return result;
        }

        public static bool VerifyPassword(string password,byte[] storedHash)
        {
            if (password == null) return false;

            if (storedHash == null || storedHash.Length != StoredValueSize)
            {
                return false;
            }

            byte version = storedHash[0];

            if (version != CurrentVersion) return false;

            int iterations = BitConverter.ToInt32(storedHash,1);

            if (iterations <= 0) return false;

            byte[] salt = new byte[SaltSize];

            Buffer.BlockCopy(storedHash,HeaderSize,salt,0,SaltSize);

            byte[] expectedHash = new byte[HashSize];

            Buffer.BlockCopy(storedHash,HeaderSize + SaltSize,expectedHash,0,HashSize);

            byte[] actualHash;

            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256))
            {
                actualHash = pbkdf2.GetBytes(HashSize);
            }

            return _FixedTimeEquals(actualHash,expectedHash);
        }

        private static bool _FixedTimeEquals(byte[] left,byte[] right)
        {
            if (left == null || right == null) return false;

            if (left.Length != right.Length) return false;

            int difference = 0;

            for (int i = 0; i < left.Length; i++)
            {
                difference |= left[i] ^ right[i];
            }

            return difference == 0;
        }
    }

}
