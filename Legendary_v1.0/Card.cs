using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_v1._0
{
    class Card
    {
        //Attributes
        String name;


        //Contstructors
        public Card()
        {
            this.name = " ";
        }

        public Card(String n)
        {
            this.name = n;
        }


        //Accessor
        public String getName()
        {
            return this.name;
        }


        //Mutator
        public void setName(String n)
        {
            this.name = n;
        }
    }
}
