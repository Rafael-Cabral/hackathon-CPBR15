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
    /// Lógica interna para Home.xaml
    /// Esta classe representa a janela "Home" do aplicativo Futuro.
    /// A janela possui cinco botões para navegação e funcionalidades do aplicativo.
    /// </summary>
    public partial class Home : Window
    {
        /// <summary>
        /// Construtor da classe Home.
        /// Inicializa a janela e define sua posição inicial.
        /// </summary>
        public Home()
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

        /// <summary>
        /// Manipulador de evento para o botão "Profile".
        /// Cria uma instância da janela "Profile", fecha a janela atual e mostra a nova janela.
        /// </summary>
        private void Button_Click_Profile(object sender, RoutedEventArgs e)
        {
            Profile objTutorial2 = new Profile();
            this.Close();
            objTutorial2.Show();
        }

        /// <summary>
        /// Manipulador de evento para o botão "Split".
        /// Cria uma instância da janela "NewEvent", fecha a janela atual e mostra a nova janela.
        /// </summary>
        private void Button_Click_Split(object sender, RoutedEventArgs e)
        {
            NewEvent objTutorial3 = new NewEvent();
            this.Close();
            objTutorial3.Show();
        }

        /// <summary>
        /// Manipulador de evento para o botão "Health".
        /// Cria uma instância da janela "Health", fecha a janela atual e mostra a nova janela.
        /// </summary>
        private void Button_Click_Health(object sender, RoutedEventArgs e)
        {
            Health objTutorial4 = new Health();
            this.Close();
            objTutorial4.Show();
        }

        /// <summary>
        /// Manipulador de evento para o botão "Money".
        /// Nenhuma funcionalidade implementada para este botão atualmente.
        /// </summary>
        private void Button_Click_Money(object sender, RoutedEventArgs e)
        {
            // Nenhuma funcionalidade implementada para este botão no momento.
        }

        /// <summary>
        /// Manipulador de evento para o botão "Scan".
        /// Cria uma instância da janela "Scan", fecha a janela atual e mostra a nova janela.
        /// </summary>
        private void Button_Click_Scan(object sender, RoutedEventArgs e)
        {
            Scan objTutorial5 = new Scan();
            this.Close();
            objTutorial5.Show();
        }
    }
}
