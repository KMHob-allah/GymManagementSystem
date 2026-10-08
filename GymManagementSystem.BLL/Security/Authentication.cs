using GymManagementSystem.BLL.Entities;

namespace GymManagementSystem.BLL.Security
{
    public static class Authentication
    {
        public enum eLoginResult
        {
            Success,
            InvalidUsernameOrPassword,
            Inactive
        }

        public static eLoginResult Login(string userName,string password,out User user)
        {
            user = User.GetByUsername(userName);

            if (user == null) return eLoginResult.InvalidUsernameOrPassword;

            if (!user.IsActive)
            {
                user = null;
                return eLoginResult.Inactive;
            }

            if (!user.VerifyPassword(password))
            {
                user = null;
                return eLoginResult.InvalidUsernameOrPassword;
            }

            return eLoginResult.Success;
        }
    }
}