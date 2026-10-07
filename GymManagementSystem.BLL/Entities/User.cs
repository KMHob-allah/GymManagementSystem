using GymManagementSystem.BLL.Security;
using GymManagementSystem.DAL;
using System;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    public class User
    {
        public enum eMode{Add,Update}

        private int _roleID;
        private Role _roleInfo;

        private eMode _mode;

        public int UserID { get; set; }

        public int RoleID
        {
            get => _roleID;

            set
            {
                if (_roleID != value)
                {
                    _roleID = value;
                    _roleInfo = null;
                }
            }
        }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool IsActive { get; set; }

        public Role RoleInfo
        {
            get
            {
                if (_roleInfo == null) _roleInfo = Role.GetByID(RoleID);

                return _roleInfo;
            }
        }

        public User(
            int userID,
            int roleID,
            string userName,
            byte[] passwordHash,
            bool isActive)
        {
            UserID = userID;
            RoleID = roleID;
            UserName = userName;
            PasswordHash = passwordHash;
            IsActive = isActive;

            _mode = eMode.Update;
        }
        public User()
        {
            UserID = 0;
            RoleID = 0;
            UserName = string.Empty;
            PasswordHash = null;
            IsActive = true;

            _mode = eMode.Add;
        }

        public static DataTable GetAll() => UsersData.GetAll();
        
        public static User GetByID(int userID)
        {
            DataRow row = UsersData.GetByID(userID);

            if (row == null)
                return null;

            return new User(
                (int)row["UserID"],
                (int)row["RoleID"],
                row["UserName"].ToString(),
                (byte[])row["PasswordHash"],
                (bool)row["IsActive"]
            );
        }
        public static User GetByUsername(string userName)
        {
            DataRow row = UsersData.GetByUsername(userName);

            if (row == null)
                return null;

            return new User(
                (int)row["UserID"],
                (int)row["RoleID"],
                row["UserName"].ToString(),
                (byte[])row["PasswordHash"],
                (bool)row["IsActive"]
            );
        }

        public static bool IsUsernameExists(string userName, int? userID = null)
        {
            return UsersData.IsUsernameExists(userName, userID);
        }

        private bool _Add()
        {
            int? userID = UsersData.Create(RoleID,UserName,PasswordHash,IsActive);

            if (!userID.HasValue) return false;

            UserID = userID.Value;

            return true;
        }
        private bool _Update()
        {
            return UsersData.Update(UserID,RoleID,UserName,PasswordHash,IsActive);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case eMode.Add:

                    if( _Add())
                    {
                        _mode = eMode.Update;
                        return true;
                    }
                    return false;

                case eMode.Update:

                    return _Update();

                default:

                    return false;
            }
        }      

        public bool Activate()
        {
            if (!UsersData.Activate(UserID)) return false;

            IsActive = true;

            return true;
        }
        public bool Deactivate()
        {
            if (!UsersData.Deactivate(UserID)) return false;

            IsActive = false;

            return true;
        }


        public void SetPassword(string password)
        {
            PasswordHash = PasswordHasher.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            return PasswordHasher.VerifyPassword(password,PasswordHash);
        }

        public bool UpdatePassword(byte[] passwordHash)
        {
            if (!UsersData.UpdatePassword(UserID,passwordHash))
            {
                return false;
            }

            PasswordHash = passwordHash;

            return true;
        }

    }
}