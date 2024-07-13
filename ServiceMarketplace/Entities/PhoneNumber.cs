namespace ServiceMarketplace.Entities
{
    public class PhoneNumber
    {
        public int[] Number { get; set; } // Size 10 array for each digit

        public PhoneNumber() {
            Number = new int[10]{5, 5, 5, 5 ,5, 5, 5, 5, 5, 5};
        }
        public PhoneNumber(int[] Number)
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
