using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sgs.Presentation.View;
using Sgs.Presentation.ViewModel;

namespace Sgs.Presentation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new EnseignantListViewModel();
           //EnseignantDetail.DataContext = EnseignantsList.DataContext; //extrait du Datacontext principal
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AboutView view = new AboutView();
            view.Owner = this;

            // view.Show();

            // Afiche une fenetre de dialigue modal
            view.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(this, "Voulez-vous quitter?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

       // private void EtudiantListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
       // {
       //     if ((sender == null) || !(sender is EtudiantListView))
       //         return;
       //
       //     EtudiantDetail.DataContext = EtudiantsList.ListViewEtudiants.SelectedItem;
       // }
    }
}
