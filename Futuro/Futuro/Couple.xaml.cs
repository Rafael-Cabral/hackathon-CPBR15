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
    /// Lógica interna para Great.xaml
    /// Esta classe representa a janela "Great" do aplicativo Futuro.
    /// A janela possui três botões para navegação para outras páginas do aplicativo.
    /// </summary>
    public partial class Couple : Window
    {
        /// <summary>
        /// Construtor da classe Great.
        /// Inicializa a janela e define sua posição inicial.
        /// </summary>
        public Couple()
        {
            InitializeComponent();

            // Define a posição desejada da janela principal
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 100;
            this.Top = 100;
        }

        /// <summary>
        /// Manipulador de evento para o botão "Scan".
        /// Cria uma instância da janela "Scan", fecha a janela atual e mostra a nova janela.
        /// </summary>
        private void Button_Click_Scan(object sender, RoutedEventArgs e)
        {
            Scan objTutorial3 = new Scan();
            this.Close();
            objTutorial3.Show();
        }
    }
}
