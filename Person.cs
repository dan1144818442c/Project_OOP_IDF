using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__Analiza
{
    abstract class Person
    {
        protected string first_name;
        protected string last_name;
        protected int age;

        public Person(string first_name, string last_name, int age)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
        }



    }
}


