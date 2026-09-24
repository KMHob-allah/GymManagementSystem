using GymManagementSystem.BLL.Common;
using GymManagementSystem.BLL.Entities;
using GymManagementSystem.DAL;
using System;
using System.Data;

namespace GymManagementSystem.BLL.Services
{
    public enum CreateMemberOperationResult
    {
        Success,
        InvalidData,
        PhoneNumberAlreadyExists,            
        Failed
    }
    public enum UpdateMemberOperationResult
    {
        Success,
        InvalidData,
        NotExistMember,
        PhoneNumberAlreadyExists,
        Failed
    }

    public static class MemberService
    {

        /*
         
        // TODO: Authorization
        // TODO: Audit Logging
        // TODO: Exceptions

        Validating Phone Number And Emergency Phone : 

        [ (11 digit && only digits) , (010, 011, 012, 015) ] Will Be At UI Layer

        */

        private static bool ValidateRequiredFields(
            string firstName,string secondName,string lastName,
            string phoneNumber,string area,string emergencyPhone)
        {
            return
                !string.IsNullOrWhiteSpace(firstName) &&
                !string.IsNullOrWhiteSpace(secondName) &&
                !string.IsNullOrWhiteSpace(lastName) &&
                !string.IsNullOrWhiteSpace(phoneNumber) &&
                !string.IsNullOrWhiteSpace(area) &&
                !string.IsNullOrWhiteSpace(emergencyPhone);
        }

        private static bool ValidateBirthDate(DateTime birthDate)
        {
            return !(birthDate.Date > DateTime.Today);
                             
        }

        private static bool ValidateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;

            if (birthDate.Date > DateTime.Today.AddYears(-age)) age--;

            return age >= 10 && age <= 100;
        }

        private static bool ValidateEmergencyPhone(string phoneNumber,string emergencyPhone)
        {            
            return phoneNumber != emergencyPhone;
        }
        

        private static OperationResult<CreateMemberOperationResult,int> CreateFalierResult(CreateMemberOperationResult resultCode)
        {
            return new OperationResult<CreateMemberOperationResult, int>(resultCode);
        }
        
        private static OperationResult<UpdateMemberOperationResult, bool> UpdateFalierResult(UpdateMemberOperationResult resultCode)
        {
            return new OperationResult<UpdateMemberOperationResult, bool>(resultCode);
        }


        public static DataTable GetAll()
        {
            return MembersData.GetAll();
        }
        
        public static Member GetMemberByID(int memberID)
        {
            DataRow row = MembersData.GetByID(memberID);

            if (row == null) return null;

            return new Member(
                (int)row["MemberID"],
                (int)row["PersonID"],
                (string)row["FirstName"],
                (string)row["SecondName"],
                row["ThirdName"] == DBNull.Value ? null: (string)row["ThirdName"],
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

        public static OperationResult<CreateMemberOperationResult, int> CreateMember(string firstName,
            string secondName,string thirdName,string lastName,string phoneNumber,DateTime birthDate,
            Gender gender,string area,string emergencyPhone) 
        {

            if (!ValidateRequiredFields(firstName,secondName,lastName,phoneNumber,area,emergencyPhone)) CreateFalierResult(CreateMemberOperationResult.InvalidData);
            
            if (!ValidateEmergencyPhone(phoneNumber, emergencyPhone)) CreateFalierResult(CreateMemberOperationResult.InvalidData);            

            if (!ValidateBirthDate(birthDate)) CreateFalierResult(CreateMemberOperationResult.InvalidData);                
            
            if (!ValidateAge(birthDate)) CreateFalierResult(CreateMemberOperationResult.InvalidData);            

            if (PeopleData.IsPhoneNumberExists(phoneNumber)) CreateFalierResult(CreateMemberOperationResult.InvalidData);
            

            int? memberID = MembersData.Create(
                firstName,
                secondName,
                thirdName,
                lastName,
                phoneNumber,
                birthDate,
                (gender == Gender.Male),
                area,emergencyPhone
                );

            if (!memberID.HasValue) CreateFalierResult(CreateMemberOperationResult.Failed);            

            return new OperationResult<CreateMemberOperationResult, int>(
                CreateMemberOperationResult.Success,
                memberID.Value);
        }

        public static OperationResult<UpdateMemberOperationResult, bool> UpdateMember(int memberID,
            string firstName, string secondName, string thirdName, string lastName, string phoneNumber,
            DateTime birthDate, Gender gender, string area, string emergencyPhone) 
        {
            int? personID = MembersData.GetPersonID(memberID);
            
            if (!personID.HasValue) UpdateFalierResult(UpdateMemberOperationResult.NotExistMember);            

            if (!ValidateRequiredFields(firstName,secondName,lastName, phoneNumber, area,emergencyPhone)) UpdateFalierResult(UpdateMemberOperationResult.InvalidData);

            if (!ValidateEmergencyPhone(phoneNumber, emergencyPhone)) UpdateFalierResult(UpdateMemberOperationResult.InvalidData);            

            if (!ValidateBirthDate(birthDate)) UpdateFalierResult(UpdateMemberOperationResult.InvalidData);

            if (PeopleData.IsPhoneExistsForOtherPerson(phoneNumber, personID.Value)) UpdateFalierResult(UpdateMemberOperationResult.PhoneNumberAlreadyExists);
            

            bool updated = MembersData.Update(
                memberID, 
                firstName, 
                secondName,
                thirdName, 
                lastName,
                phoneNumber, 
                birthDate,
                gender == Gender.Male,
                area, 
                emergencyPhone); 

            if (!updated) UpdateFalierResult(UpdateMemberOperationResult.Failed);

            return new OperationResult<UpdateMemberOperationResult, bool>(UpdateMemberOperationResult.Success, true); 
        }

        public static bool ActivateMember(int memberID)
        {
            return MembersData.Activate(memberID);
        }

        public static bool DeactivateMember(int memberID)
        {
            return MembersData.Deactivate(memberID);
        }
    }
}