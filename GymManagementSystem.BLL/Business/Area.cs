
using GymManagementSystem.DAL;
using System.Collections.Generic;
using System.Data;

namespace GymManagementSystem.BLL.Entities
{
    public class Area
    {
        public int AreaID { get; set; }

        public string AreaName { get; set; }

        public Area(int areaID, string areaName)
        {
            AreaID = areaID;
            AreaName = areaName;
        }

        public static DataTable GetAll() => AreasData.GetAll();                 

        public static Area GetByID(int areaID)
        {
            DataRow row = AreasData.GetByID(areaID);

            if (row == null) return null;

            return new Area((int)row["AreaID"],row["AreaName"].ToString()
            );
        }



    }
}
