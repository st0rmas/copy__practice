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

namespace app_main
{
    /// <summary>
    /// Логика взаимодействия для CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {

        public CustomMessageBox messageBox;

        public CustomMessageBox(string message)
        {
            InitializeComponent();
            TextBlockMessage.Text = message;

        }
        private void Button_CloseMessageBox(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
