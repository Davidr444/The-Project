using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Mother
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
        public string LastName { get { return LastName; } set { LastName = value; } }
        public string FirstName { get { return FirstName; } set { FirstName = value; } }
        public int Phone { get { return Phone; } set { Phone = value; } }
        public string Adress
        {
            get { return Adress; }
            set
            {
                int counter = 0, helpChar = value.IndexOf(',',2);

                if (helpChar == -1)
                    throw new FormatException("The string is not in the format: Street, City, State");
               
                for (; helpChar != -1 ;counter++)
                {
                    helpChar = value.IndexOf(',', helpChar + 1);
                }
               
                if(counter != 3)
                    throw new FormatException("The string is not in the format: Street, City, State");

                Adress = value;
            }
        }
        public string DesiredAddressOfNanny
        {
            get { return DesiredAddressOfNanny; }
            set
            {
                int counter = 0, helpChar = value.IndexOf(',', 2);

                if (helpChar == -1)
                    throw new FormatException("The string is not in the format: Street, City, State");

                for (; helpChar != -1; counter++)
                {
                    helpChar = value.IndexOf(',', helpChar + 1);
                }

                if (counter != 3)
                    throw new FormatException("The string is not in the format: Street, City, State");

                DesiredAddressOfNanny = value;
            }
        }
        public bool[] DaysOfNeedingNanny
        {
            get { return DaysOfNeedingNanny; }
            set
            {
                if (value.Length != 7)
                    throw new ArgumentException("The array is not the right size (7)");
                DaysOfNeedingNanny = value;
            }
        }
        public DateTime[,] HoursOfNeedingNanny
        {
            get { return HoursOfNeedingNanny; }
            set
            {
                if (value.GetLength(0) != 6 || value.GetLength(2) != 2)
                    throw new ArgumentException("The array is not of the appropriate size (6,2)");
                HoursOfNeedingNanny = value;
            }
        }
        public string Recommendations { get { return Recommendations; } set { Recommendations = value; } }

        public override string ToString()
        {
            return "I am the mother: " + FirstName + ' ' + LastName + ", ID: " + ID;
        }
        //מאפיינים נוספים לפי הצורך
    }
}
