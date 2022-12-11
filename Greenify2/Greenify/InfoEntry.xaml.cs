using System;
using System.Collections.Generic;
using System.IO;
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

namespace Greenify
{
    /// <summary>
    /// Interaction logic for InfoEntry.xaml
    /// </summary>
    public partial class InfoEntry : Page
    {
        public InfoEntry()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SendDataBtn_Click(object sender, RoutedEventArgs e)
        {
            //STOCAREA DATELOR INTRODUSE DE UTILIZATOR IN MEMORIA PERMANENTA

            StreamWriter sw = new StreamWriter("Base.txt");
            //Write a line of text
            sw.WriteLine(DateUserInfo.Text);
            //Write a second line of text
            sw.WriteLine(DateGaze.Text);

            sw.WriteLine(oil.Text);
            sw.WriteLine(milage.Text);
            sw.WriteLine(avion.Text);
            if (rec_pap.Text == "Yes")
                sw.WriteLine("0");
            else
                sw.WriteLine("1");

            if (rec_metal.Text == "Yes")
                sw.WriteLine("0");
            else
                sw.WriteLine("1");


            //Close the file
            sw.Close();

            StreamReader sri = new StreamReader("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\baza.txt");
            string linia;
            linia = sri.ReadLine();
            sri.Close();
            int nr = Convert.ToInt32(linia);
            sri.Close();

            if (nr==1)
            {
                StreamWriter sw1 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e1.txt");

                sw1.WriteLine(DateUserInfo.Text);
                sw1.WriteLine(DateGaze.Text);
                sw1.WriteLine(oil.Text);
                sw1.WriteLine(milage.Text);
                sw1.WriteLine(avion.Text);
                if (rec_pap.Text == "Yes")
                    sw1.WriteLine("0");
                else
                    sw1.WriteLine("1");

                if (rec_metal.Text == "Yes")
                    sw1.WriteLine("0");
                else
                    sw1.WriteLine("1");

                sw1.Close();
            }

            if (nr==2)
            {
                StreamWriter sw2 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e2.txt");

                sw2.WriteLine(DateUserInfo.Text);
                sw2.WriteLine(DateGaze.Text);
                sw2.WriteLine(oil.Text);
                sw2.WriteLine(milage.Text);
                sw2.WriteLine(avion.Text);
                if (rec_pap.Text == "Yes")
                    sw2.WriteLine("0");
                else
                    sw2.WriteLine("1");

                if (rec_metal.Text == "Yes")
                    sw2.WriteLine("0");
                else
                    sw2.WriteLine("1");

                sw2.Close();
            }

            if (nr==3)
            {
                StreamWriter sw3 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e3.txt");

                sw3.WriteLine(DateUserInfo.Text);
                sw3.WriteLine(DateGaze.Text);
                sw3.WriteLine(oil.Text);
                sw3.WriteLine(milage.Text);
                sw3.WriteLine(avion.Text);
                if (rec_pap.Text == "Yes")
                    sw3.WriteLine("0");
                else
                    sw3.WriteLine("1");
                if (rec_metal.Text == "Yes")
                    sw3.WriteLine("0");
                else
                    sw3.WriteLine("1");

                sw3.Close();
            }

            if (nr==4)
            {
                StreamWriter sw4 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e4.txt");

                sw4.WriteLine(DateUserInfo.Text);
                sw4.WriteLine(DateGaze.Text);
                sw4.WriteLine(oil.Text);
                sw4.WriteLine(milage.Text);
                sw4.WriteLine(avion.Text);
                if (rec_pap.Text == "Yes")
                    sw4.WriteLine("0");
                else
                    sw4.WriteLine("1");
                if (rec_metal.Text == "Yes")
                    sw4.WriteLine("0");
                else
                    sw4.WriteLine("1");

                sw4.Close();
            }
            StreamWriter srit = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\baza.txt");
            int linias;
            linias = Convert.ToInt32(linia);
            linias = linias + 1;
            srit.WriteLine(Convert.ToString(linias));
            srit.Close();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------
       

        
    }
}
