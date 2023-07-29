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
    /// Lógica interna para Start1.xaml
    /// Esta classe representa a primeira etapa de um processo (Start1) do aplicativo Futuro.
    /// A janela "Start1" permite iniciar o processo e passar para a próxima etapa.
    /// </summary>
    public partial class Start1 : Window
    {
        /// <summary>
        /// Construtor da classe Start1.
        /// Inicializa a janela e define sua posição inicial.
        /// </summary>
        public Start1()
        {
            InitializeComponent();

            // Define a posição desejada da janela principal
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 100;
            this.Top = 100;
        }

        /// <summary>
        /// Manipulador de evento para o botão não nomeado (Button_Click).
        /// Cria uma instância da próxima etapa (Start2), fecha a janela atual e mostra a nova janela "Start2".
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Start2 objTutorial1 = new Start2();
            this.Close();
            objTutorial1.Show();
        }
    }
}
