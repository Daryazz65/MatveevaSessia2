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
    /// Логика взаимодействия для UserrWindow.xaml
    /// </summary>
    public partial class UserrWindow : Window
    {
        public UserrWindow(Model.User selectedUser)
        {
            InitializeComponent();
        }

        private void OneHl_Click(object sender, RoutedEventArgs e)
        {
            JournalWindow journalWindow = new JournalWindow();
            journalWindow.Show();
            Close();
        }

        private void TwoHl_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            Close();
        }
    }
}
