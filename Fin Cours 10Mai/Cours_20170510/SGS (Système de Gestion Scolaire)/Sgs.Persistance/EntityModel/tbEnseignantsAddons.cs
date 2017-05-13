using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Persistance.EntityModel
{
    public partial class tbEnseignants
    {
        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
        public tbEnseignants(string nom, string prenom) : this()
        {
            Nom = nom;
            Prenom = prenom;
        }
    }
}

