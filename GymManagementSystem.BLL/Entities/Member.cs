using System;

namespace GymManagementSystem.BLL.Entities
{
    public class Member : Person
    {
        public int MemberID { get; protected set; }

        public string EmergencyPhone { get; protected set; }

        public DateTime JoinDate { get; protected set; }

        public bool IsActive { get; protected set; }


        public Member(int memberID,int personID,string firstName,string secondName,string thirdName,
            string lastName,string phoneNumber,DateTime birthDate,Gender gender,string area,
            string emergencyPhone,DateTime joinDate,bool isActive)
            : base(personID,firstName,secondName,thirdName,lastName,phoneNumber,birthDate,gender,area)
        {
            MemberID = memberID;
            EmergencyPhone = emergencyPhone;
            JoinDate = joinDate;
            IsActive = isActive;
        }

        //public void Activate () => IsActive = true;        

        //public void Deactivate () => IsActive = false;        
    }
}