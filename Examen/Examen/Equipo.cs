using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Equipo
    {
        private string teamName;
        private string kindTeam;
        private List<Jugadores> regPlayers;
        private List<Jugadores> keepPlayers;
        private Entrenador coach;
        private Medico doctor;

        public void SetTeam(List<Jugadores> regPlayers, List<Jugadores> keepPlayers, Entrenador coach, Medico doctor, string teamName, string kindTeam )
        {
            this.regPlayers = regPlayers;
            this.keepPlayers = keepPlayers;
            this.coach = coach;
            this.doctor = doctor;
            this.teamName = teamName;
            this.kindTeam = kindTeam;
        }

        public List<Jugadores> GetRegPlayer()
        {
            return this.regPlayers;
        }
        public string GetKeepPlayer()
        {
            string keeper = "";
            for (int x = 0; x < keepPlayers.Count(); x++)
            {
                keeper += keepPlayers[x].GetName();
            }
            return keeper;
        }
        public string GetName()
        {
            return teamName;
        }
        public string GetKindTeam()
        {
            return kindTeam;
        }
        public Entrenador GetCoach()
        {
            return coach;
        }
        public Medico GetDoctor()
        {
            return doctor;
        }
        public bool CheckKindTeam()
        {
            if (kindTeam == "Nacional" || kindTeam == "nacional")
            {
                bool check = true;
                string nation = regPlayers[0].GetNation();
                for ( int x = 1; x < regPlayers.Count(); x++)
                {
                    if (regPlayers[x].GetNation() == regPlayers[x - 1].GetNation())
                    {
                        continue;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == true)
                {
                    for (int y = 0; y < keepPlayers.Count(); y++)
                    {
                        if (keepPlayers[y].GetNation() == nation)
                        {
                            continue;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                }
                return check;
            }
            else
            {
                return false;
            }
        }
        
        
    }
}
