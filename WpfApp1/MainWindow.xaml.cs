using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> listHome = new ObservableCollection<string>();
        public ObservableCollection<string> listWork= new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            lbx_home.ItemsSource = listHome;
            lbx_work.ItemsSource = listWork;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if(txtbxInput.Text == "")
            {
                lbl_error_msg.Visibility = Visibility.Visible;
            } else
            {
                lbl_error_msg.Visibility= Visibility.Hidden;
            }

            if(rbtnHome.IsChecked == true)
            {
                listHome.Add(txtbxInput.Text);
            } else
            {
                listWork.Add(txtbxInput.Text);
            }

        }
    }
}
