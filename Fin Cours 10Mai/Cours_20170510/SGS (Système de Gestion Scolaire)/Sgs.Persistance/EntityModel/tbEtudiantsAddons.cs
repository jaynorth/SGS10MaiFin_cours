using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Persistance.EntityModel
{
    public partial class tbEtudiants
    {
        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
        public tbEtudiants(string nom, string prenom):this()
        {
            Nom = nom;
            Prenom = prenom;
        }
    }
}
