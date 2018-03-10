using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_v1._0
{
    class DefeatableCard : Card
    {
        //Attributes
        int victoryPoints;
        int defense;
        String name;

        //Constructors
        public DefeatableCard() : base()
        {
            this.victoryPoints = 0;
            this.defense = 0;
        }
        public DefeatableCard(int vp, int d, String n) : base(n)
        {
            this.victoryPoints = vp;
            this.defense = d;
        }

        //Accessors
        public int getVictoryPoints()
        {
            return this.victoryPoints;
        }

        public int getDefense()
        {
            return this.defense;
        }


        //Mutators
        public void setVictoryPoints(int vp)
        {
            this.victoryPoints = vp;
        }

        public void setDefense(int d)
        {
            this.defense = d;
        }
        
    }
}
