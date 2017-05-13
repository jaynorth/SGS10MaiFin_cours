using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Business.Model
{
    public class Etudiant
    {
        public Etudiant(string nom, string prenom, string rue, string num, string npa, string localite)
        {
            Nom = nom;
            Prenom = prenom;
            Rue = rue;
            RueNum = num;
            Npa = npa;
            Localite = localite;
        }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Rue { get; set; }

        public string RueNum { get; set; }

        public string Npa { get; set; }

        public string Localite { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Prenom, Nom);
        }

    }
}
