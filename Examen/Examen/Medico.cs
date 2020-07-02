using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Medico : Persona 
    {
        private int expePoints;

        public void SetDoctor(int expePoints)
        {
            this.expePoints = expePoints;
        }
        public int GetExper()
        {
            return expePoints;
        }
        //public void EvaluatePlayer(bool)
        //public void HealdPlayer(bool)
    }
}
