using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.BLL.Entities
{
    public class Plan
    {
        public int ID { get; private set; }
        public string Name {  get; private set; }
        public int DurationInDays { get; private set; }
        public float Price { get; private set; }
        public bool IsActive { get; private set; }

        public Plan(int planID, string planName, int durationInDays, float price, bool isActive) 
        {
            ID = planID;
            Name = planName;
            DurationInDays = durationInDays;
            Price = price;
            IsActive = isActive;
        }

    }
}
