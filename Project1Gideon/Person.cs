using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Person is the parent class of lecturer and learner. Both have an id, firstName and lastName.
/// This class creates a new Person object with an id, firstName and lastName.
/// it uses public properties to control access to protected fields, so that other classes have access to the values but cannot change them.
/// </summary>

namespace Project1Gideon
{
    public class Person
    {
        protected int id;
        protected string firstName;
        protected string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int Id
        {
            get { return id; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }
    }
}
