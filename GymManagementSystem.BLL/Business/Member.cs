using GymManagementSystem.BLL.Security;
using GymManagementSystem.DAL;
using System;
using System.Data;
using static GymManagementSystem.BLL.Entities.User;

namespace GymManagementSystem.BLL.Entities
{
    // TODO: Authorization
    // TODO: Audit Logging
    // TODO: Exceptions
    public class Member : Person
    {
        public int MemberID { get; set; }
        public string EmergencyPhone { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsActive { get; set; }

        private eMode _Mode;

        public Member() : base(
            0,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            DateTime.MinValue,
            Gender.Male,
            0)
        {
            MemberID = 0;
            EmergencyPhone = string.Empty;
            JoinDate = DateTime.MinValue;
            IsActive = false;
            _Mode = eMode.Add;
        }

        protected Member(
            int memberID,
            int personID,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            string phoneNumber,
            DateTime birthDate,
            Gender gender,
            int areaID,
            string emergencyPhone,
            DateTime joinDate,
            bool isActive)
            : base(
                personID,
                firstName,
                secondName,
                thirdName,
                lastName,
                phoneNumber,
                birthDate,
                gender,
                areaID)
        {
            MemberID = memberID;
            EmergencyPhone = emergencyPhone;
            JoinDate = joinDate;
            IsActive = isActive;
            _Mode = eMode.Update;
        }

        public static DataTable GetAll() => MembersData.GetAll();

        public static Member GetMemberByID(int memberID)
        {
            DataRow row = MembersData.GetByID(memberID);

            if (row == null)
                return null;

            return new Member(
                Convert.ToInt32(row["MemberID"]),
                Convert.ToInt32(row["PersonID"]),
                row["FirstName"].ToString(),
                row["SecondName"].ToString(),
                row["ThirdName"] == DBNull.Value ? null: row["ThirdName"].ToString(),
                row["LastName"].ToString(),
                row["PhoneNumber"].ToString(),
                Convert.ToDateTime(row["BirthDate"]),
                Convert.ToBoolean(row["Gender"]) ? Gender.Female : Gender.Male,
                Convert.ToInt32(row["AreaID"]),
                row["EmergencyPhone"].ToString(),
                Convert.ToDateTime(row["JoinDate"]),
                Convert.ToBoolean(row["IsActive"])
            );
        }

        private bool _Add()
        {
            var result = MembersData.Create(
                FirstName,
                SecondName,
                ThirdName,
                LastName,
                PhoneNumber,
                BirthDate,
                Gender == Gender.Male,
                AreaID,
                EmergencyPhone,
                IsActive);

            if (!result.HasValue)
                return false;

            PersonID = result.Value.PersonID;
            MemberID = result.Value.MemberID;

            return true;
        }

        private bool _Update()
        {
            return MembersData.Update(
                MemberID,
                FirstName,
                SecondName,
                ThirdName,
                LastName,
                PhoneNumber,
                BirthDate,
                Gender == Gender.Male,
                AreaID,
                EmergencyPhone,
                IsActive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case eMode.Add:
                    {
                        if (!PermissionManager.HasPermission("Members.Create"))
                            return false;

                        if (!_Add())
                            return false;

                        _Mode = eMode.Update;
                        return true;
                    }

                case eMode.Update:
                    {
                        if (!PermissionManager.HasPermission("Members.Update"))
                            return false;

                        return _Update();
                    }

                default:
                    return false;
            }
        }

        public bool Activate()
        {
            if (!PermissionManager.HasPermission("Members.Activate"))
                return false;

            return MembersData.Activate(MemberID);
        }

        public bool Deactivate()
        {
            if (!PermissionManager.HasPermission("Members.Deactivate"))
                return false;

            return MembersData.Deactivate(MemberID);
        }

        public bool HasOutstandingDebt()
        {
            return MembersData.HasOutstandingDebt(MemberID);
        }
    }
}