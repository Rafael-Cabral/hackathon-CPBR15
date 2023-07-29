﻿using System;
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
    /// Lógica interna para Profile.xaml
    /// Esta classe representa a janela "Profile" do aplicativo Futuro.
    /// A janela apresenta o perfil do usuário com informações pessoais e opções de navegação.
    /// </summary>
    public partial class Profile : Window
    {
        /// <summary>
        /// Construtor da classe Profile.
        /// Inicializa a janela e define sua posição inicial.
        /// </summary>
        public Profile()
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
