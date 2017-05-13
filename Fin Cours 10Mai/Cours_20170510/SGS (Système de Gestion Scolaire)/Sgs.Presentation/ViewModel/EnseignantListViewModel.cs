using Sgs.Persistance.EntityModel;
using Sgs.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public ICommand AddNew { get { return new ExecutableCommand(_addNew); } }

        public ICommand DeleteCurrent { get { return new ExecutableCommand(_deleteCurrent); } }

        private void _addNew()
        {
            tbEnseignants newItem = new tbEnseignants("Duss", "Jean");
            Enseignants.Add(newItem);
            CurrentItem = newItem;
        }


        private tbEnseignants _currentItem;

        public tbEnseignants CurrentItem
        {
            get { return _currentItem; }

            set
            {
                _currentItem = value;
                FirePropertyChanged();
            }

        }

        public void _deleteCurrent()
        {
            Enseignants.Remove(CurrentItem);
            FirePropertyChanged();
        }

        public EnseignantListViewModel()
        {

            EntityModelConnexion context = new EntityModelConnexion();

            _enseignants = new ObservableCollection<tbEnseignants>(context.tbEnseignants);

        }

    
    }

}

