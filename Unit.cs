using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__Analiza
{
    abstract class Unit
    {
        protected List<Person> peoples;
        public Unit() {
            peoples = new List<Person> { };
        }

        public void Add_Person(Person person)
        {
            peoples.Add(person);
        }

    }
}
