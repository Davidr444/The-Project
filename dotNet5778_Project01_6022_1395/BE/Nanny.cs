using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nanny
    {
        public int ID { get { return ID; } set{}}
        public string LastName{get { return LastName; } set {}}
        public string FirstName{get { return FirstName; } set {}}
        public string DateOfBirth{get { return DateOfBirth; } set {}} //maybe not string? maybe Date?
        public int Phone{get { return Phone; } set {}}
        public string Adress{get { return Adress; } set {}}
        public bool Elevator{get { return Elevator; } set {}}
        public int Floor{get { return Floor; } set {}}
        public int YearsOfExperience{get { return YearsOfExperience; } set {}}
        public int MaxChilds{get { return MaxChilds; } set {}}
        public int MinAgeOfChild{get { return MinAgeOfChild; } set {}}
        public int MaxAgeOfChild{get { return MaxAgeOfChild; } set {}}
        public  bool HourlyRate{get { return HourlyRate; } set {}}
        public double PricePerHour{get { return PricePerHour; } set {}}
        public double PricePerMonth{get { return PricePerMonth; } set {}}
        public bool[] WorkDays{get { return WorkDays; } set {}}
        public int [,] WorkHours{get { return WorkHours; } set {}}
        public bool StateDaysOff{get { return StateDaysOff; } set {}}
        public string Recommendations{get { return Recommendations; } set {}}
        
        public override string ToString()
        {

        }
        //מאפיינים נוספים לפי הצורך



    }
}
