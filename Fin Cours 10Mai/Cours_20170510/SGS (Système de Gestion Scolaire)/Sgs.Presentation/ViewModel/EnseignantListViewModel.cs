using Sgs.Persistance.EntityModel;
using Sgs.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Presentation.ViewModel
{
    class EnseignantListViewModel: BaseViewModel
    {

        private ObservableCollection<tbEnseignants> _enseignants;
        public ObservableCollection<tbEnseignants> Enseignants
        {
            get { return _enseignants; }
            set
            {
                _enseignants.Clear();
                _enseignants = value;
            }
        }

        //public ICommand AddNew { get { return new ExecutableCommand(_addNew); } }
        //
        //public ICommand DeleteCurrent { get { return new ExecutableCommand(_deleteCurrent); } }

        //private void _addNew()
        //{
        //    tbEtudiants newItem = new tbEtudiants("Duss", "Jean");
        //    Etudiants.Add(newItem);
        //    CurrentItem = newItem;
        //}


        private tbEtudiants _currentItem;

        public tbEtudiants CurrentItem
        {
            get { return _currentItem; }

            set
            {
                _currentItem = value;
                FirePropertyChanged();
            }

        }

        //public void _deleteCurrent()
        //{
        //    Etudiants.Remove(CurrentItem);
        //    FirePropertyChanged();
        //}

        public EnseignantListViewModel()
        {

            EntityModelConnexion context = new EntityModelConnexion();

            _enseignants = new ObservableCollection<tbEnseignants>(context.tbEnseignants);

            //foreach (tbEtudiants etudiant in context.tbEtudiants.ToList<tbEtudiants>()) 
            //    _etudiants.Add(etudiant);
        }

    
    }

}

