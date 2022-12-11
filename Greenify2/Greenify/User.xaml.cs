using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
using static System.Net.Mime.MediaTypeNames;

namespace Greenify
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : Page
    {
        public User()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw2 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\user.txt");
            sw2.WriteLine(Prenume.Text);
            sw2.WriteLine(nr_pers.Text);
            if (Panouri.Text == "Renewable")
                sw2.WriteLine("1");
            else
                sw2.WriteLine("0");

            if (CarP.Text == "Electric")
                sw2.WriteLine("0");
            else
                sw2.WriteLine("1");
            sw2.Close();
            Username.Content = Nume.Text +" "+ Prenume.Text;
            Locatie.Content = Tara.Text +", "+Orasul.Text;
        }
    }
}
