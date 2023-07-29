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
using System.Windows.Shapes;

namespace Futuro
{
    /// <summary>
    /// Lógica interna para Scan.xaml
    /// Esta classe representa a janela "Scan" do aplicativo Futuro.
    /// A janela permite realizar varreduras ou escaneamentos de alguma forma.
    /// </summary>
    public partial class Scan : Window
    {
        /// <summary>
        /// Construtor da classe Scan.
        /// Inicializa a janela e define sua posição inicial.
        /// </summary>
        public Scan()
        {
            InitializeComponent();

            // Define a posição desejada da janela principal
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 100;
            this.Top = 100;
        }

        /// <summary>
        /// Manipulador de evento para o botão "Home".
        /// Cria uma instância da janela "Home", fecha a janela atual e mostra a nova janela.
        /// </summary>
        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            Home objTutorial1 = new Home();
            this.Close();
            objTutorial1.Show();
        }
        private void Button_Click_GreatOnly(object sender, RoutedEventArgs e)
        {
            GreatOnly objTutorial1 = new GreatOnly();
            this.Close();
            objTutorial1.Show();
        }
    }
}
