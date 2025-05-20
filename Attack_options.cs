using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__Analiza
{
    abstract class Attack_options
    {
        protected string aunique_name;
        protected int Ammunition_capacity;
        protected int Fuel_supply;
        protected object[] Effective_target;  

        public Attack_options(string aunique_name , int Ammunition_capacity, int Fuel_supply , object[] Effective_target) {
            this.aunique_name = aunique_name;
            this.Ammunition_capacity = Ammunition_capacity;
            this.Fuel_supply = Fuel_supply;
            this.Effective_target = Effective_target;

        }
       

    }
}
