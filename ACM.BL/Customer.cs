using System;
namespace ACM.BL
{
    public class Customer
    {
        public int  CustomerId{
            get;
            private set;
        }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }


        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }

        private string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }




        public Customer()
        {
        }
    }
}
