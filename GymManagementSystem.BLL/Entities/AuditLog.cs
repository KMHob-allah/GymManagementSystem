using GymManagementSystem.DAL;
using System;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    public class AuditLog
    {
        private enum eMode
        {
            Add,
            Update
        }

        private eMode _Mode;
        private User _createdByUserInfo;

        public int AuditLogID { get; set; }
        public int UserID { get; set; }
        public string ActionType { get; set; }
        public string TableName { get; set; }
        public int RecordID { get; set; }
        public DateTime CreatedAt { get; set; }

        public User CreatedByUserInfo
        {
            get
            {
                if (_createdByUserInfo == null && UserID > 0)
                    _createdByUserInfo = User.GetByID(UserID);

                return _createdByUserInfo;
            }
        }

        private AuditLog(
            int auditLogID,
            int userID,
            string actionType,
            string tableName,
            int recordID,
            DateTime createdAt)
        {
            AuditLogID = auditLogID;
            UserID = userID;
            ActionType = actionType;
            TableName = tableName;
            RecordID = recordID;
            CreatedAt = createdAt;

            _Mode = eMode.Update;
        }

        public AuditLog()
        {
            AuditLogID = 0;
            UserID = 0;
            ActionType = string.Empty;
            TableName = string.Empty;
            RecordID = 0;
            CreatedAt = DateTime.MinValue;

            _Mode = eMode.Add;
        }

        public static DataTable GetAll() => AuditLogsData.GetAll();        

        public static AuditLog GetByID(int auditLogID)
        {
            DataRow row = AuditLogsData.GetByID(auditLogID);

            if (row == null) return null;

            return new AuditLog(
                Convert.ToInt32(row["AuditLogID"]),
                Convert.ToInt32(row["UserID"]),
                row["ActionType"].ToString(),
                row["TableName"].ToString(),
                Convert.ToInt32(row["RecordID"]),
                Convert.ToDateTime(row["CreatedAt"]));
        }

        private bool _Add()
        {
            int? auditLogID = AuditLogsData.Create(UserID,ActionType,TableName,RecordID);

            if (!auditLogID.HasValue) return false;

            AuditLogID = auditLogID.Value;

            return true;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case eMode.Add:

                    if (_Add())
                    {
                        _Mode = eMode.Update;
                        return true;
                    }

                    return false;

                default:

                    return false;
            }
        }
    }

}
