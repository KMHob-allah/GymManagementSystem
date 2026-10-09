using GymManagementSystem.DAL;
using System;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    public class Attendance
    {
        private enum eMode {  Add, Update}

        public enum eSaveResult
        {
            Success,
            MemberNotActive,
            MembershipNotValid,
            Failed
        }

        private Membership _membershipInfo;


        public int AttendanceID { get; set; }
        public int MembershipID { get; set; }
        public DateTime CheckInDateTime { get; set; }

        public Membership MembershipInfo
        {
            get
            {
                if (_membershipInfo == null && MembershipID > 0)
                    _membershipInfo = Membership.GetByID(MembershipID);

                return _membershipInfo;
            }
        }


        eMode _Mode;

        private Attendance(int attendanceID,int membershipID,DateTime checkInDateTime)
        {
            AttendanceID = attendanceID;
            MembershipID = membershipID;
            CheckInDateTime = checkInDateTime;

            _Mode = eMode.Update;
        }

        public Attendance()
        {
            AttendanceID = 0;
            MembershipID = 0;
            CheckInDateTime = DateTime.MinValue;

            _Mode = eMode.Add;
        }

        public static DataTable GetAll() => AttendanceData.GetAll();        

        public static Attendance GetByID(int attendanceID)
        {
            DataRow row = AttendanceData.GetByID(attendanceID);

            if (row == null) return null;

            return new Attendance(
                Convert.ToInt32(row["AttendanceID"]),
                Convert.ToInt32(row["MembershipID"]),
                Convert.ToDateTime(row["CheckInDateTime"]));
        }
        
        private bool _Add()
        {
            int? attendanceID = AttendanceData.Create(MembershipID);

            if (!attendanceID.HasValue) return false;

            AttendanceID = attendanceID.Value;

            return true;
        }
        public eSaveResult Save()
        {
            switch (_Mode)
            {
                case eMode.Add:
                {

                    if (!MembershipInfo.MemberInfo.IsActive) return eSaveResult.MemberNotActive;

                    if (DateTime.Today < MembershipInfo.StartDate || DateTime.Today > MembershipInfo.EndDate)
                    {
                        return eSaveResult.MembershipNotValid;
                    }

                    if (_Add())
                    {
                        _Mode = eMode.Update;
                        return eSaveResult.Success;
                    }

                    else return eSaveResult.Failed;
                }

                default:
                    return eSaveResult.Failed;

            }
        }
          
    }
}