using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavD
{
    public struct Name
    {
        private string first;
        private string middle;
        private string last;

        public Name(string firstName, string middleName, string lastName )
        {
            this.first = firstName;
            this.middle = middleName;
            this.last = lastName;
        }
        public string FirstName
        {
            get { return  FirstName; }
            set { first = FirstName; }
        }
        public string MiddleName
        {
            get { return MiddleName; }
            set { middle = MiddleName; }
        }
        public string LastName
        {
            get { return LastName; }
            set { last = LastName; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", first, middle, last);
        }
        public string Initials()
        {
            return string.Format("{0}{1}{2}", first.Substring(0,1), middle.Substring(0,1), last.Substring(0,1));
        }

        public static void Main()
        {
            Name getname = new Name("MIROSLAV", "JIVKOV", "DIMITROV");
            string fullname = getname.ToString();
            string inits = getname.Initials();
            Console.WriteLine("Name: " + fullname);
            Console.WriteLine("Initials: " + inits);

        }
    }
}
