using GymManagementSystem.DAL;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public Role()
        {
            RoleID = 0;
            RoleName = string.Empty;
        }
        public Role(int roleID,string roleName)
        {
            RoleID = roleID;
            RoleName = roleName;
        }

        public static DataTable GetAll()
        {
            return RolesData.GetAll();
        }

        public static Role GetByID(int roleID)
        {
            DataRow row = RolesData.GetByID(roleID);

            if (row == null) return null;

            return new Role((int)row["RoleID"], row["RoleName"].ToString());
        }
    }
}