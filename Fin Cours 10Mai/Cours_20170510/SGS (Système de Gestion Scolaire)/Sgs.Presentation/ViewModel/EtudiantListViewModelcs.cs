using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sgs.Business.Model;
using System.Collections.ObjectModel;

namespace Sgs.Presentation.ViewModel
{
    public class EtudiantListViewModel
    {
        private ObservableCollection<Etudiant> _etudiants;

        public EtudiantListViewModel()
        {
            _etudiants = new ObservableCollection<Etudiant>();

            _etudiants.Add(new Etudiant("Holmes", "Sherlok", "Baker street", "121b", "1000", "London"));
            _etudiants.Add(new Etudiant("Newton", "Isac", "Gravity street", "1", "1232", "London"));
        }

        public ObservableCollection<Etudiant> Etudiants
        {
            get { return _etudiants; }
            set
            {
                _etudiants.Clear();
                _etudiants = value;
            }
        }
    }
}
