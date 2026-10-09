using GymManagementSystem.BLL.Entities;

namespace GymManagementSystem.BLL
{
    public static class AuditLogger
    {
        public static bool Log(string actionType,string tableName,int recordID)
        {
            if (GlobalSettings.CurrentUser == null) return false;

            if (string.IsNullOrWhiteSpace(actionType) || string.IsNullOrWhiteSpace(tableName) || recordID <= 0)
            {
                return false;
            }

            AuditLog auditLog = new AuditLog
            {
                UserID = GlobalSettings.CurrentUser.UserID,
                ActionType = actionType,
                TableName = tableName,
                RecordID = recordID
            };

            return auditLog.Save();
        }
    }
}