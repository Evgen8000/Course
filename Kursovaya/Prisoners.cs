using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    [Serializable]
   public class Prisoner
    {
        public string First_Name;
        public string Second_Name;
        public int Room;
        public string Criminality;
        public Date DateOfJailed;
        public string PITPH;
        public string Relatives;
        public string Temper;

        public Prisoner()
        {
            this.First_Name = "";
            this.Second_Name = "";
            this.Room = 0;
            this.Criminality = "";
            this.PITPH = "";
            this.Relatives = "";
            this.Temper = "";
            this.DateOfJailed = new Date();


        }

        public Prisoner(string First_Name,string Second_Name,int Room, string Criminality, Date DateOfJailed, string PITPH, string Relatives, string Temper)
        {
            this.First_Name = First_Name;
            this.Second_Name = Second_Name;
            this.Room = Room;
            this.Criminality = Criminality;
            this.PITPH = PITPH;
            this.Relatives = Relatives;
            this.Temper = Temper;
            this.DateOfJailed = DateOfJailed;
        }

    }
    [Serializable]
    public class Date
    {
        public int Day;
        public int Month;
        public int Year;

        public Date()
        {
        }

        public Date(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
            
        
    }
}
