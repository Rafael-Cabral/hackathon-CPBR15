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
    /// Lógica interna para Start3.xaml
    /// Esta classe representa a terceira etapa de um processo (Start3) do aplicativo Futuro.
    /// A janela "Start3" permite continuar o processo e passar para a próxima etapa.
    /// </summary>
    public partial class Start3 : Window
    {
        /// <summary>
        /// Construtor da classe Start3.
        /// Inicializa a janela e define sua posição inicial.
        /// </summary>
        public Start3()
        {
            InitializeComponent();

            // Define a posição desejada da janela principal
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 100;
            this.Top = 100;
        }

        /// <summary>
        /// Manipulador de evento para o botão não nomeado (Button_Click).
        /// Cria uma instância da próxima etapa (SignUp), fecha a janela atual e mostra a nova janela "SignUp".
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUp objTutorial = new SignUp();
            this.Close();
            objTutorial.Show();
        }
    }
}
