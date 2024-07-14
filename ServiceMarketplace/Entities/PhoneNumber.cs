namespace ServiceMarketplace.Entities
{
    public class PhoneNumber
    {
        public string Number { get; set; } // Size 10 array for each digit

        public PhoneNumber() {
            //Number = new int[10]{5, 5, 5, 5 ,5, 5, 5, 5, 5, 5};
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
