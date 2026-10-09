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
            string.Empty)
        {
            this.MemberID = 0;
            this.EmergencyPhone = string.Empty;
            this.JoinDate = DateTime.MinValue;
            this.IsActive = false;
            _Mode = eMode.Add;
        }
        protected Member(int memberID,int personID,string firstName,string secondName,string thirdName,
            string lastName,string phoneNumber,DateTime birthDate,Gender gender,string area,
            string emergencyPhone,DateTime joinDate,bool isActive)
            : base(personID,firstName,secondName,thirdName,lastName,phoneNumber,birthDate,gender,area)
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

            if (row == null) return null;

            return new Member(
                (int)row["MemberID"],
                (int)row["PersonID"],
                (string)row["FirstName"],
                (string)row["SecondName"],
                row["ThirdName"] == DBNull.Value ? null : (string)row["ThirdName"],
                (string)row["LastName"],
                (string)row["PhoneNumber"],
                (DateTime)row["BirthDate"],
                (bool)row["Gender"] ? Gender.Female : Gender.Male,
                (string)row["Area"],
                (string)row["EmergencyPhone"],
                (DateTime)row["JoinDate"],
                (bool)row["IsActive"]
            );
        }

        private bool _Add()
        {
            var result = MembersData.Create(
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.PhoneNumber,
                this.BirthDate,
                this.Gender == Gender.Male,
                this.Area,
                this.EmergencyPhone,
                this.IsActive);

            if (!result.HasValue) return false;

            this.PersonID = result.Value.PersonID;
            this.MemberID = result.Value.MemberID;

            return true;
        }
        private bool _Update()
        {
            return MembersData.Update(
                this.MemberID,
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.PhoneNumber,
                this.BirthDate,
                this.Gender == Gender.Female,
                this.Area,
                this.EmergencyPhone,
                this.IsActive);
        }

        public bool Save()
        {
            bool IsSaved = false;


            
            switch(_Mode)
            {
                 
                case eMode.Add:
                {
                    if (!PermissionManager.HasPermission("Members.Create")) return false;

                    if (_Add())
                    {
                        _Mode = eMode.Update;
                        IsSaved = true;
                    }

                    else IsSaved = false;

                    break;
                }

                case eMode.Update:
                {
                    if (!PermissionManager.HasPermission("Members.Update")) return false;

                    if (_Update()) IsSaved = true;

                    else IsSaved = false;

                    break;
                }
            }

            return IsSaved;
        }

        public bool Activate()
        {
            if (!PermissionManager.HasPermission("Members.Activate")) return false;            
            
            return MembersData.Activate(this.MemberID);
        }
        public bool Deactivate()
        {
            if (!PermissionManager.HasPermission("Members.Deactivate")) return false;            
            
            return MembersData.Deactivate(this.MemberID);
        }
    }
}