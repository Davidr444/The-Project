using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Contract
    {
        public int Num { get { return Num; } set { } }
        public int NannyID { get { return NannyID; } set { } }
        public int ChildID { get { return NannyID; } set { } }
        public bool IntroductoryMeeting { get { return IntroductoryMeeting; }  set { } }
        public bool ContractSigned { get { return ContractSigned; } set { } }
        public int HourlyWages { get { return HourlyWages; } set { } }
        public int MonthlySalary { get { return MonthlySalary; } set { } }
        public string HourOrMonth { get { return HourOrMonth; } set { /*לעשות שאפשרי להכניס רק הוור או מנס*/ } }
        public DateTime DateOfStartContract { get { return DateOfStartContract; } set { } }
        public DateTime DateOfEndContract { get { return DateOfEndContract; } set { } }
        public override string ToString()
        {

        }
        //מאפיינים נוספים לפי הצורך
    }
}
