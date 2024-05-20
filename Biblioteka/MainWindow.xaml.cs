using System;
using System.Collections.Generic;
using System.Data;
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

namespace Biblioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Knjiga> knjige;
        public MainWindow()
        {
            InitializeComponent();
            knjige = new List<Knjiga>();
            UcitajPodatke();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            knjige.Add(new Knjiga (txtNazivKnjige.Text, txtNazivAutora.Text, DateTime.Now));
            UcitajPodatke();
            

        }

        private void UcitajPodatke()
        {
            dataGridCentralni.ItemsSource = null;  // Resetovanje izvora podataka
            dataGridCentralni.ItemsSource = knjige;

        }
    }
}
