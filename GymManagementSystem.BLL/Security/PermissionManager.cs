using GymManagementSystem.BLL.Entities;
using System;
using System.Collections.Generic;

namespace GymManagementSystem.BLL.Security
{
    public static class PermissionManager
    {
        private static readonly HashSet<string> _permissions =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public static bool LoadForRole(int roleID)
        {
            _permissions.Clear();

            if (roleID <= 0)
                return false;

            List<Permission> permissions =
                Permission.GetByRoleID(roleID);

            foreach (Permission permission in permissions)
            {
                if (!string.IsNullOrWhiteSpace(permission.PermissionName))
                {
                    _permissions.Add(
                        permission.PermissionName.Trim());
                }
            }

            return true;
        }

        public static bool HasPermission(string permissionName)
        {
            if (GlobalSettings.CurrentUser == null)
                return false;

            if (string.IsNullOrWhiteSpace(permissionName))
                return false;

            return _permissions.Contains(permissionName.Trim());
        }

        public static void Clear()
        {
            _permissions.Clear();
        }
    }
}