using GymManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.BLL.Entities
{
    // TODO: Authorization
    // TODO: Audit Logging
    // TODO: Exceptions
    public class Plan
    {
        private enum eMode { Add, Update};

        public int ID { get; private set; }
        public string Name {  get; private set; }
        public int DurationInDays { get; private set; }
        public float Price { get; private set; }
        public bool IsActive { get; private set; }

        private eMode _Mode;

        public Plan()
        {
            this.ID = 0;
            this.Name = string.Empty;
            this.DurationInDays = 0;
            this.Price = 0;
            this.IsActive = false;

            _Mode = eMode.Add
        }
        protected Plan(int planID, string planName, int durationInDays, float price, bool isActive) 
        {
            ID = planID;
            Name = planName;
            DurationInDays = durationInDays;
            Price = price;
            IsActive = isActive;

            _Mode = eMode.Update;
        }


        static public DataTable GetAll() => PlansData.GetAll();
        static public Plan GetByID(int planID)
        {
            DataRow row = PlansData.GetByID(planID);

            if (row == null) return null;

            return new Plan(
                (int)row["PlanID"],
                (string)row["PlanName"],
                (int)row["DurationInDays"],
                (float)row["Price"],
                (bool)row["IsActive"]
            );
        }


        private bool _Add()
        {
            int? PlanID = PlansData.Create(this.Name, this.DurationInDays, this.Price, this.IsActive);

            if(PlanID.HasValue)
            {
                this.ID = PlanID.Value;
                return true;
            }

            else return false;

        }
        private bool _Update()
        {
            return PlansData.Update(this.ID, this.Name, this.DurationInDays, this.Price);
        }

        public bool Save()
        {
            bool IsSaved = false;

            switch (_Mode)
            {
                case eMode.Add:
                    {
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
                        if (_Update()) IsSaved = true;

                        else IsSaved = false;

                        break;
                    }
            }

            return IsSaved;
        }

        public bool Activate() => PlansData.Activate(this.ID);
        public bool Deactivate() => PlansData.Deactivate(this.ID);



    }
}
