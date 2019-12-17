using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int numero1, ris, numero2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Thread mythread1 = new Thread(() =>
            {
              
                int da = 1;
                int a = 7;
               
                numero1 = random.Next(da, a);
                numero2 = random.Next(da, a);
                ris = numero1 + numero2;
                

            });
            //esecuzione di my thread
            mythread1.Start();

            Dispatcher.Invoke(Aggiorna);
        }

        
        private void Aggiorna()
        {
            if (numero1 == 0 || numero2 == 0)
            {

            }
            else
            {
                img1.Source = new BitmapImage(new Uri($"{numero1}.jfif", UriKind.Relative));
                img2.Source = new BitmapImage(new Uri($"{numero2}.jfif", UriKind.Relative));
                Lbl_num1.Content = numero1;
                Lbl_num2.Content = numero2;
                Lbl_risultato.Content = ris;
            }
            
        }
    }
}
