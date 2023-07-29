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
    /// Lógica interna para Start2.xaml
    /// Esta classe representa a segunda etapa de um processo (Start2) do aplicativo Futuro.
    /// A janela "Start2" permite continuar o processo e passar para a próxima etapa.
    /// </summary>
    public partial class Start2 : Window
    {
        /// <summary>
        /// Construtor da classe Start2.
        /// Inicializa a janela e define sua posição inicial.
        /// </summary>
        public Start2()
        {
            InitializeComponent();

            // Define a posição desejada da janela principal
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 100;
            this.Top = 100;
        }

        /// <summary>
        /// Manipulador de evento para o botão não nomeado (Button_Click).
        /// Cria uma instância da próxima etapa (Start3), fecha a janela atual e mostra a nova janela "Start3".
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Start3 objTutorial2 = new Start3();
            this.Close();
            objTutorial2.Show();
        }
    }
}
