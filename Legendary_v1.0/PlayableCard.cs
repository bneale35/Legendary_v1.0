using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_v1._0
{
    class PlayableCard : Card
    {
        //Attributes
        int cost;
        int recruit;
        int attack;
        String color;
        String name;


        //Constructors
        public PlayableCard() : base()
        {
            this.cost = 0;
            this.recruit = 0;
            this.attack = 0;
            this.color = "";
            
        }

        public PlayableCard(int cos, int r, int a, String col, String n) : base(n)
        {
            this.cost = cos;
            this.recruit = r;
            this.attack = a;
            this.color = col;
        }


        //Accessors
        public int getCost()
        {
            return this.cost;
        }

        public int getRecruit()
        {
            return this.recruit;
        }

        public int getAttack()
        {
            return this.attack;
        }

        public String getColor()
        {
            return this.color;
        }

        

        //Mutators
        public void setCost(int cos)
        {
            this.cost = cos;
        }

        public void setRecruit(int r)
        {
            this.recruit = r;
        }

        public void setAttack(int a)
        {
            this.attack = a;
        }

        public void setColor(String col)
        {
            this.color = col;
        }
        
    }
}
