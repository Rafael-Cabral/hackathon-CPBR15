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
    /// Lógica interna para SignUp.xaml
    /// Esta classe representa a janela de cadastro "SignUp" do aplicativo Futuro.
    /// A janela permite que o usuário faça um cadastro.
    /// </summary>
    public partial class SignUp : Window
    {
        /// <summary>
        /// Construtor da classe SignUp.
        /// Inicializa a janela e define sua posição inicial.
        /// </summary>
        public SignUp()
        {
            InitializeComponent();

            // Define a posição desejada da janela principal
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 100;
            this.Top = 100;
        }

        /// <summary>
        /// Manipulador de evento para a caixa de seleção "CheckBox".
        /// Nenhuma funcionalidade implementada para esta caixa de seleção atualmente.
        /// </summary>
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Nenhuma funcionalidade implementada para esta caixa de seleção no momento.
        }

        /// <summary>
        /// Manipulador de evento para o botão não nomeado (Button_Click).
        /// Cria uma instância da janela "Home", fecha a janela atual e mostra a nova janela "Home".
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Home objTutorial1 = new Home();
            this.Close();
            objTutorial1.Show();
        }

        /// <summary>
        /// Manipulador de evento para o botão com o nome "Button_Click2".
        /// Altera a cor de fundo do botão para verde quando clicado.
        /// </summary>
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = Brushes.Green;
        }
    }
}
