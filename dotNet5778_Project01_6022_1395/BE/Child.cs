using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Child
    {
        public int ID { get { return ID; } set { } }
        public int MotherID { get { return MotherID; } set { } }
        public string FirstName { get { return FirstName; } set { } }
        public string DateOfBirth { get { return DateOfBirth; } set { } } //maybe not string? maybe Date?
        public bool SpecialNeeds { get { return SpecialNeeds; } set { } }
        public string TheSpecialNeeds { get { return TheSpecialNeeds; } set { } }

        public override string ToString()
        {

        }
        //מאפיינים נוספים לפי הצורך
    }
}
