using GymManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public string PermissionName { get; set; }

        public Permission(int permissionID, string permissionName)
        {
            PermissionID = permissionID;
            PermissionName = permissionName;
        }

        public static List<Permission> GetByRoleID(int roleID)
        {
            List<Permission> permissions = new List<Permission>();

            if (roleID <= 0)
                return permissions;

            DataTable dataTable = PermissionsData.GetByRoleID(roleID);

            foreach (DataRow row in dataTable.Rows)
            {
                permissions.Add(
                    new Permission(
                        Convert.ToInt32(row["PermissionID"]),
                        row["PermissionName"].ToString()
                    )
                );
            }

            return permissions;
        }
    }
}