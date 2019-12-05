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

namespace ProgrammaPerMedie_pippi
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_calcola_Click(object sender, RoutedEventArgs e)
        {
            try//faccio il try per controllare se non ci sono problemi con la conversione
            {
                var italiano= Convert.ToInt32(txt_italiano.Text);//converto le txt (puoi usare pure "int.parse" per delle prestazione migliori)
                var matematica=Convert.ToInt32(Txt_matematica.Text);
                var risultato = 0;//creo la variabile risultato

                if (italiano < 0 || matematica < 0)//faccio un piccolo controllo perchè non puoi avere quantità -1
                {
                    MessageBox.Show("Attenzione devi inserire dei numeri superiori a 0");
                }
                else
                {
                    risultato = italiano * 5 + matematica * 10;//faccio il calcolo

                    if (Chk_vogliadistudiare.IsChecked == true) risultato += 50;//controllo i checkbutton se sono veri
                    if (Chk_voto10Sistemi.IsChecked == true) risultato += 100;

                    Lb_risultato.Content = $"Prezzo finale: {risultato} €";//stampo output
                }
            }
            catch
            {
                MessageBox.Show("Attenzione devi inserire dei numeri sulle quantità");
            }
        }
    }
}
