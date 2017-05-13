using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Sgs.Business.Model;
using System.Collections.ObjectModel;
using Sgs.Persistance.EntityModel;
using GalaSoft.MvvmLight.CommandWpf;
using Sgs.Presentation.Helpers;

namespace Sgs.Presentation.ViewModel
{

    public class EtudiantListViewModel: BaseViewModel
    {
        private ObservableCollection<tbEtudiants> _etudiants;

        public ICommand AddNew { get { return new ExecutableCommand(_addNew); } }

        public ICommand DeleteCurrent { get { return new ExecutableCommand(_deleteCurrent); } }

        private void _addNew()
        {
            tbEtudiants newItem = new tbEtudiants("Duss", "Jean");
            Etudiants.Add(newItem);
            CurrentItem = newItem;
        }


        private tbEtudiants _currentItem;

        public tbEtudiants CurrentItem
        {
            get {return _currentItem; }

            set { _currentItem = value;
                FirePropertyChanged();
            }
            
        }

        public void _deleteCurrent()
        {
            Etudiants.Remove(CurrentItem);
            FirePropertyChanged();
        }

        public EtudiantListViewModel()
        {

            EntityModelConnexion context = new EntityModelConnexion();

            _etudiants = new ObservableCollection<tbEtudiants>(context.tbEtudiants);

            //foreach (tbEtudiants etudiant in context.tbEtudiants.ToList<tbEtudiants>()) 
            //    _etudiants.Add(etudiant);
        }

        public ObservableCollection<tbEtudiants> Etudiants
        {
            get { return _etudiants; }
            set
            {
                _etudiants.Clear();
                _etudiants = value;
            }
        }
    }

    //public class EtudiantListViewModel
    //{
    //    private ObservableCollection<Etudiant> _etudiants;

    //    public EtudiantListViewModel()
    //    {
    //        _etudiants = new ObservableCollection<Etudiant>();

    //        _etudiants.Add(new Etudiant("Holmes", "Sherlok", "Baker street", "121b", "1000", "London"));
    //        _etudiants.Add(new Etudiant("Newton", "Isac", "Gravity street", "1", "1232", "London"));
    //    }

    //    public ObservableCollection<Etudiant> Etudiants
    //    {
    //        get { return _etudiants; }
    //        set
    //        {
    //            _etudiants.Clear();
    //            _etudiants = value;
    //        }
    //    }
    //}
}
