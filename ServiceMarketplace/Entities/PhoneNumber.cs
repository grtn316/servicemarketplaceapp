using Microsoft.EntityFrameworkCore;

namespace ServiceMarketplace.Entities
{
    //Use this class as a utility to format phone numbers before submitting to the database instead
    public class PhoneNumber
    {
        public string Number { get; set; }

        public PhoneNumber() {
            Number = new string('5', 10);
        }
        public PhoneNumber(string Number)
        {
            this.Number = Number;
        }
        public string Print() // Needs to be tested
        {
            //  This function returns a phone number as a string, formatted "(xxx)-xxx-xxxx".

            string num = "";

            for (int i = 0; i < this.Number.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        num = "(";
                        break;
                    case 2:
                        num += ")-";
                        break;
                    case 6:
                        num += "-";
                        break;
                }
                num += Number[i];
            }
            return num;
        }
    }
}
