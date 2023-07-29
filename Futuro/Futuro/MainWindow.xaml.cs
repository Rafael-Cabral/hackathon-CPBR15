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

namespace Futuro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Esta classe representa a janela principal (MainWindow) do aplicativo Futuro.
    /// A janela é responsável por fornecer a interface gráfica inicial do aplicativo.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Construtor da classe MainWindow.
        /// Inicializa a janela principal e define sua posição inicial.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Define a posição desejada da janela principal
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 100;
            this.Top = 100;
        }

        /// <summary>
        /// Manipulador de evento para o botão não nomeado (Button_Click).
        /// Nenhuma funcionalidade implementada para este botão atualmente.
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Nenhuma funcionalidade implementada para este botão no momento.
        }

        /// <summary>
        /// Manipulador de evento para o botão com o nome Button_Click_1.
        /// Cria uma instância da janela "Start1", fecha a janela atual e mostra a nova janela.
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Start1 objTutorial1 = new Start1();
            this.Close();
            objTutorial1.Show();
        }
    }
}
