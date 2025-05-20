using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__Analiza
{
    internal class F16_Fighter_Jet : Attack_options
    {
        private string[] bomb_type = {"0.5 ton" , "1 ton"};
        private Type[] Effective_target = {typeof(Building)};
        private string Operated_by = "Pilot";
        public F16_Fighter_Jet(string aunique_name, int Fuel_supply) : base(aunique_name, 8, Fuel_supply)
        {
        }
    }


}
