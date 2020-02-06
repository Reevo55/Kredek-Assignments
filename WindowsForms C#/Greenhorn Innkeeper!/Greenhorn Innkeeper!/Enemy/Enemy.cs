using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenhorn_Innkeeper_.Enemy
{
    abstract class Enemy
    {
        protected string name;

        public Enemy(string name)
        {
            this.name = name;
        }

        abstract public void DoDamage(Tavern tavern);


        public string GetName() { return name; }
    }
}
