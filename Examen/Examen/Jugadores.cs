using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Jugadores : Persona
    {
        private int attackPoints;
        private int defensePoints;
        private int shirtNumber;
        private bool kindPlayer;

        public void SetPlayer(int attackPoints, int defensePoints, int shirtNumber, bool kindPlayer)
        {
            this.attackPoints = attackPoints;
            this.defensePoints = defensePoints;
            this.shirtNumber = shirtNumber;
            this.kindPlayer = kindPlayer;

        }
        public int GetAttack()
        {
            return attackPoints;
        }
        public int GetDefense()
        {
            return defensePoints;
        }
        public int GetNumber()
        {
            return shirtNumber;
        }
        public bool CheckPlayer()
        {
            return kindPlayer;
        }
    }
}
