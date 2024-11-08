﻿using MatveevaSessia2.AppData;
using MatveevaSessia2.Model;
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

namespace MatveevaSessia2.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private static MatveevaSessia2Entities _context = App.GetContext();
        public AuthorizationWindow()
        {
            List<string> roles = new List<string> {"Директор", "Сисадмин"};
            InitializeComponent();
            RoleCmb.ItemsSource = roles;
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthoriseHelper.Authorise(LoginTb.Text, PassTb.Password, RoleCmb.SelectedItem as string))
            {
                CAPTCHAWindow cAPTCHAWindow = new CAPTCHAWindow();
                if (cAPTCHAWindow.ShowDialog() == true)
                {
                    if (RoleCmb.SelectedIndex == 0)
                    {
                        UserrWindow userrWindow = new UserrWindow(AuthoriseHelper.selectedUser);
                        userrWindow.Show();
                        Close();
                    }
                }
            }
        }

        private void SignUpHl_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.Show();
            Close();
        }

        private void EnterHl_Click(object sender, RoutedEventArgs e)
        {
            // ---.
        }
    }
}
