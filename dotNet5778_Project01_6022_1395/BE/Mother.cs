using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Mother
    {
        public int ID { get { return ID; } set { } }
        public string LastName { get { return LastName; } set { } }
        public string FirstName { get { return FirstName; } set { } }
        public int Phone { get { return Phone; } set { } }
        public string Adress { get { return Adress; } set { } }
        public string DesiredAddressOfNanny { get { return DesiredAddressOfNanny; } set { } }
        public bool[] DaysOfNeedingNanny { get { return DaysOfNeedingNanny; } set { } }
        public int[,] HoursOfNeedingNanny { get { return HoursOfNeedingNanny; } set { } }
        public string Recommendations { get { return Recommendations; } set { } }

        public override string ToString()
        {

        }
        //מאפיינים נוספים לפי הצורך
    }
}
