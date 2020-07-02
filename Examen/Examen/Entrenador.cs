using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Entrenador : Persona
    {
        private int tacticPoints;

        public void SetCoach(int tacticPoints)
        {
            this.tacticPoints = tacticPoints;
        }
        public int GetTactic()
        {
            return tacticPoints;
        }
        //public void ChangePlayer()
        
    }
}
