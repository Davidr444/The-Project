using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Child 
    {
        public int ID
        {
            get { return ID; }
            set
            {
                string num = Convert.ToString(value);
                num.Trim();//Erases all spaces entered in front or back
                if (num.Length != 9)////Check whether the ID entered is exactly 9 digits:
                    throw new FormatException("The ID entered is less than 9 digits long.");

                //Validation of ID (According to the algorithm of the integrity of an Israeli ID)
                char[] propriety = { '1', '2', '1', '2', '1', '2', '1', '2', '1' };
                int validation = 0;

                for (int i = 0; i < 9; ++i)
                {
                    validation += ((int)num[i] * (int)propriety[i]);
                }

                if (validation % 10 != 0)
                    throw new ArgumentException("The ID that was entered illegally in Israel");

                ID = value;
            }
        }
        public int MotherID
        {
            get { return MotherID; }
            set
            {
                string num = Convert.ToString(value);
                num.Trim();//Erases all spaces entered in front or back
                if (num.Length != 9)////Check whether the ID entered is exactly 9 digits:
                    throw new FormatException("The ID entered is less than 9 digits long.");

                //Validation of ID (According to the algorithm of the integrity of an Israeli ID)
                char[] propriety = { '1', '2', '1', '2', '1', '2', '1', '2', '1' };
                int validation = 0;

                for (int i = 0; i < 9; ++i)
                {
                    validation += ((int)num[i] * (int)propriety[i]);
                }

                if (validation % 10 != 0)
                    throw new ArgumentException("The ID that was entered illegally in Israel");

                MotherID = value;
            }
        }
        public string FirstName { get { return FirstName; } set { FirstName = value; } }
        public DateTime DateOfBirth { get { return DateOfBirth; } set { DateOfBirth = value; } }
        public bool SpecialNeeds { get { return SpecialNeeds; } set { SpecialNeeds = value; } }
        public string TheSpecialNeeds { get { return TheSpecialNeeds; } set { TheSpecialNeeds = value; } }

        public override string ToString()
        {
            return "I am the child: " + FirstName + ", ID: " + ID + ", Date of birth: " + DateOfBirth.ToShortDateString() + ", My mother ID: " + MotherID;
        }
        //מאפיינים נוספים לפי הצורך
    }
}
