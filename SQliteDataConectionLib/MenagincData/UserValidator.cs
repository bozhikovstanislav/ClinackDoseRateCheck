namespace SQliteDataConectionLib.MenagincData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    
    public class CreatUser
    {
        private string firstName;
        private string lastName;
        private string password;

        public CreatUser(string firstName,string lastName,string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;

        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Pleas input firstNAme");

                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Pleas input firstNAme");
                    
                }

                lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

    }
}
