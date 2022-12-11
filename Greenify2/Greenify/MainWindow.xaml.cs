using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //DECLARAERA STRUCTURILOR IN CARE STOCAM DATELE PRELUATE DIN FORMULARUL DE ENTRY
        public struct DateInfo
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public int metal_rec;
            public int paper_rec;
        }
        public struct e1
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public double carbon;
            public int metal_rec;
            public int paper_rec;
        }
        public struct e2
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public double carbon;
            public int metal_rec;
            public int paper_rec;
        }
        public struct e3
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public double carbon;
            public int metal_rec;
            public int paper_rec;
        }
        public struct e4
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public double carbon;
            public int metal_rec;
            public int paper_rec;
        }
        DateInfo dateUser;

        e1 be1;
        e2 be2;
        e3 be3; 
        e4 be4; 

        public MainWindow()
        {
            InitializeComponent();
        }
        //BUTOANE PENTRU NAVIGARE, COMUTAREA INTRE PAGINI
        private void Entry_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new InfoEntry();
            User.Visibility = Visibility.Collapsed;
            Sugestii.Visibility = Visibility.Collapsed;
            Sugests.Visibility = Visibility.Collapsed;
            Statistici.Visibility = Visibility.Collapsed;
            Stats.Visibility = Visibility.Collapsed;
            Sageata.Visibility = Visibility.Collapsed;
            Goods.Visibility = Visibility.Collapsed;
            Bads.Visibility = Visibility.Collapsed;
            Impacts.Visibility = Visibility.Collapsed;
            UserBtn.Visibility = Visibility.Collapsed;
            Impacturi.Visibility = Visibility.Collapsed;
            Goodies.Visibility = Visibility.Collapsed;
            Baddies.Visibility = Visibility.Collapsed;
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Details();
            User.Visibility = Visibility.Collapsed;
            Sugestii.Visibility = Visibility.Collapsed; 
            Sugests.Visibility = Visibility.Collapsed;
            Statistici.Visibility = Visibility.Collapsed;
            Stats.Visibility = Visibility.Collapsed;  
            Sageata.Visibility = Visibility.Collapsed;
            Goods.Visibility = Visibility.Collapsed;
            Bads.Visibility = Visibility.Collapsed;
            Impacts.Visibility = Visibility.Collapsed;
            UserBtn.Visibility = Visibility.Collapsed;
            Goodies.Visibility = Visibility.Collapsed;
            Baddies.Visibility = Visibility.Collapsed;
            Impacturi.Visibility = Visibility.Collapsed;
        }

        public void Home_Click(object sender, RoutedEventArgs e)
        {
            
            Main.Content = null;
            User.Visibility = Visibility.Visible;
            Sugestii.Visibility =  Visibility.Visible;
            Sugests.Visibility = Visibility.Visible;
            Statistici.Visibility = Visibility.Visible;
            Stats.Visibility = Visibility.Visible;
            Sageata.Visibility= Visibility.Visible;
            Goods.Visibility = Visibility.Visible;
            Bads.Visibility = Visibility.Visible;
            Impacts.Visibility = Visibility.Visible;
            UserBtn.Visibility = Visibility.Visible;
            Goodies.Visibility = Visibility.Visible;
            Baddies.Visibility = Visibility.Visible;
            Impacturi.Visibility = Visibility.Visible;  
            //Sugests.Text = "- Mai putin petrol\n- Hi";
            ///carbon calculate
            
            
            bool metal_rec = false, paper_rec = false;
            double carbon = 0;
            int nr_persoane, renew, car_type;

            //PRELUAREA DATELOR PRINCIPALE DE LA UTILIZATOR
            StreamReader citeste = new StreamReader("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\user.txt");
            string cit;
            cit = citeste.ReadLine();
            User.Text ="Hello "+cit+",";

            cit = citeste.ReadLine();
            nr_persoane = Convert.ToInt32(cit);

            cit = citeste.ReadLine();
            renew = Convert.ToInt32(cit);

            cit = citeste.ReadLine();
            car_type=Convert.ToInt32(cit); 

            citeste.Close();

            StreamReader sr = new StreamReader("Base.txt");
            string line;
            string entry;
            line = sr.ReadLine();
            Console.WriteLine(line);
            dateUser.electricity_bill=Convert.ToDouble(line);
            line = sr.ReadLine();
            dateUser.gas_bill = Convert.ToDouble(line);
            line= sr.ReadLine();
            dateUser.oil_bill = Convert.ToDouble(line);
            line = sr.ReadLine(); 
            dateUser.yearly_milage = Convert.ToDouble(line);
            line = sr.ReadLine();
            dateUser.flights = Convert.ToDouble(line);
            line = sr.ReadLine();
            dateUser.paper_rec = Convert.ToInt32(line);
            line = sr.ReadLine();
            dateUser.metal_rec = Convert.ToInt32(line);
           

            sr.Close();
            //---------------------------------------------------
            
            //CALCULAREA AMPRENTEI DE CARBON SI STOCAREA ACESTEIA IN MEMORIA PERMANENTA
            StreamReader sri = new StreamReader("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\baza.txt");
            string linia;
            linia = sri.ReadLine();
            sri.Close();
            int nr = Convert.ToInt32(linia);
            sri.Close();
            
            carbon = ((dateUser.electricity_bill * 105) / 52) + ((dateUser.gas_bill * 105) / 52)+ ((dateUser.oil_bill * 105) / 52) + ((dateUser.yearly_milage / 52) * 0.79) + dateUser.flights * 1100;
            if (dateUser.paper_rec==1)
                carbon += 184;
            if (dateUser.metal_rec==1)
                carbon += 166;

            carbon = Math.Round(carbon, 2);
            Stats.Text = "Amprenta de carbon: " + carbon;

            if (nr == 1)
            {
                StreamWriter sw1 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e1.txt");
                sw1.WriteLine(carbon);
                sw1.Close();
            }

            if (nr == 2)
            {
                StreamWriter sw2 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e1.txt");
                sw2.WriteLine(carbon);
                sw2.Close();
            }

            if (nr == 3)
            {
                StreamWriter sw3 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e1.txt");
                sw3.WriteLine(carbon);
                sw3.Close();
            }

            if (nr == 4)
            {
                StreamWriter sw4 = new StreamWriter("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e1.txt");
                sw4.WriteLine(carbon);
                sw4.Close();
            }
            ///--------------------------------------------------------------------------------------------------------------
            
            //INTRODUCEREA INFORMATIILOR STOCATE PERMANENT INAPOI IN RAM PENTRU COMPARATIA ACESTORA 

            ///1
            StreamReader e1 = new StreamReader("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e1.txt");
                string line1;
                line1 = e1.ReadLine();
                be1.electricity_bill = Convert.ToDouble(line1);
                line1 = e1.ReadLine();
                be1.gas_bill = Convert.ToDouble(line1);
                line1 = e1.ReadLine();
                be1.oil_bill = Convert.ToDouble(line1);
                line1 = e1.ReadLine();
                be1.yearly_milage = Convert.ToDouble(line1);
                line1 = e1.ReadLine();
                be1.flights = Convert.ToDouble(line1);
                line1 = e1.ReadLine();
                be1.paper_rec = Convert.ToInt32(line1);
                line1 = e1.ReadLine();
                be1.metal_rec = Convert.ToInt32(line1);
                e1.Close();
            ///------

            ///2
            StreamReader e2 = new StreamReader("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e2.txt");
                string line2;
                line2 = e2.ReadLine();
                be2.electricity_bill = Convert.ToDouble(line2);
                line2 = e2.ReadLine();
                be2.gas_bill = Convert.ToDouble(line2);
                line2 = e2.ReadLine();
                be2.oil_bill = Convert.ToDouble(line2);
                line2 = e2.ReadLine();
                be2.yearly_milage = Convert.ToDouble(line2);
                line2 = e2.ReadLine();
                be2.flights = Convert.ToDouble(line2);
                line2 = e2.ReadLine();
                be2.paper_rec = Convert.ToInt32(line2);
                line2 = e2.ReadLine();
                be2.metal_rec = Convert.ToInt32(line2);
                line2 = e2.ReadLine();
                be2.carbon = Convert.ToDouble(line2);
            e2.Close();
            ///------

            ///3
            StreamReader e3 = new StreamReader("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e3.txt");
            string line3;
            line3 = e3.ReadLine();
            be3.electricity_bill = Convert.ToDouble(line3);
            line3 = e3.ReadLine();
            be3.gas_bill = Convert.ToDouble(line3);
            line3 = e3.ReadLine();
            be3.oil_bill = Convert.ToDouble(line3);
            line3 = e3.ReadLine();
            be3.yearly_milage = Convert.ToDouble(line3);
            line3 = e3.ReadLine();
            be3.flights = Convert.ToDouble(line3);
            line3 = e3.ReadLine();
            be3.paper_rec = Convert.ToInt32(line3);
            line3 = e3.ReadLine();
            be3.metal_rec = Convert.ToInt32(line3);
            line3 = e3.ReadLine();
            be3.carbon = Convert.ToDouble(line3);
            e3.Close();
            ///-----

            ///4
            StreamReader e4 = new StreamReader("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e4.txt");
            string line4;
            line4 = e4.ReadLine();
            be4.electricity_bill = Convert.ToDouble(line4);
            line4 = e4.ReadLine();
            be4.gas_bill = Convert.ToDouble(line4);
            line4 = e4.ReadLine();
            be4.oil_bill = Convert.ToDouble(line4);
            line4 = e4.ReadLine();
            be4.yearly_milage = Convert.ToDouble(line4);
            line4 = e4.ReadLine();
            be4.flights = Convert.ToDouble(line4);
            line4 = e4.ReadLine();
            be4.paper_rec = Convert.ToInt32(line4);
            line4 = e4.ReadLine();
            be4.metal_rec = Convert.ToInt32(line4);
            line4 = e4.ReadLine();
            be4.carbon = Convert.ToDouble(line4);

            e4.Close();
            /// -----------
            /*
            if (nr == 1)
            {
                if (carbon > be1.carbon)
                {
                   Sageata.Text = " ▲";
                    Sageata.Foreground = new SolidColorBrush(Colors.Red);

                }
                else
                {
                    Sageata.Text = " ▼";
                    Sageata.Foreground = new SolidColorBrush(Colors.Green);
                }
            }

            if (nr == 2)
            {
                if (carbon > be1.carbon)
                {
                    Sageata.Text = " ▲";
                    Sageata.Foreground = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Sageata.Text = " ▼";
                    Sageata.Foreground = new SolidColorBrush(Colors.Green);
                }
            }

            if (nr == 3)
            {
                if (carbon > be2.carbon)
                {
                    Sageata.Text = " ▲";
                    Sageata.Foreground = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Sageata.Text = " ▼";
                    Sageata.Foreground = new SolidColorBrush(Colors.Green);
                }
            }

            if (nr == 4)
            {
                if (carbon > be3.carbon)
                {
                    Sageata.Text = " ▲";
                    Sageata.Foreground = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    Sageata.Text = " ▼";
                    Sageata.Foreground = new SolidColorBrush(Colors.Green);

                }
            }
            */
            ///----------------------------------------------------------------------------------------------------------------------
            


            //COMPARAREA NOILOR VALORI INTRODUSE DE UTILIZATOR CU CELE INTRODUSE IN SAPTAMANILE ANTERIOARE
            //PENTRU AFISAREA SCHIMBARILOR IN BINE DAR SI REGRESELOR ACESTUIA

            if (nr == 2)
            {
                ///1
                if (dateUser.electricity_bill > be1.electricity_bill)
                {
                    Goods.Text = "Lower electricity consumption!";
                }
                else if(dateUser.electricity_bill < be1.electricity_bill)
                {
                    Bads.Text = "Higher electricity consumption";
                }
                ///2
                if (dateUser.gas_bill > be1.gas_bill)
                {
                    Goods.Text = "Lower gas consumption!";
                }
                else if (dateUser.gas_bill < be1.gas_bill)
                {
                    Bads.Text = "Higher gas consumption";
                }
                ///3
                if (dateUser.oil_bill > be1.oil_bill)
                {
                    Goods.Text = "Lower oil consumption!";
                    Impacts.Text = "Improoved air quality!";
                }
            
                else if (dateUser.oil_bill < be1.oil_bill)
                {
                    Bads.Text = "Higher oil consumption";
                }
                ///4
                if (dateUser.yearly_milage > be1.yearly_milage)
                {
                    Goods.Text = "Smaller distance driven!";
                }
                else if (dateUser.yearly_milage < be1.yearly_milage)
                {
                    Bads.Text = "More distance driven";
                }
                //5
                if (dateUser.flights > be1.flights)
                {
                    Goods.Text = "Less flights taken!";
                }
                else if (dateUser.flights < be1.flights)
                {
                    Bads.Text = "More flights taken!";
                }
                //6
                if (dateUser.paper_rec == 0)
                {
                    Goods.Text = "Recycled paper!";
                }
                else 
                {
                    Bads.Text = "Didn't recycle paper!";
                }
                //7
                if (dateUser.metal_rec ==0)
                {
                    Goods.Text = "Recycled metal!";
                }
                else 
                {
                    Bads.Text = "Didn't recycle paper!";
                }


            }

            if (nr == 3)
            {
                ///1
                if (dateUser.electricity_bill > be2.electricity_bill)
                {
                    Goods.Text = "Lower electricity consumption!";
                }
                else if (dateUser.electricity_bill < be2.electricity_bill)
                {
                    Bads.Text = "Higher electricity consumption";
                }
                ///2
                if (dateUser.gas_bill > be2.gas_bill)
                {
                    Goods.Text = "Lower gas consumption!";
                }
                else if (dateUser.gas_bill < be2.gas_bill)
                {
                    Bads.Text = "Higher gas consumption";
                }
                ///3
                if (dateUser.oil_bill > be2.oil_bill)
                {
                    Goods.Text = "Lower oil consumption!";
                    Impacts.Text = "Improoved air quality!";
                }

                else if (dateUser.oil_bill < be2.oil_bill)
                {
                    Bads.Text = "Higher oil consumption";
                }
                ///4
                if (dateUser.yearly_milage > be2.yearly_milage)
                {
                    Goods.Text = "Smaller distance driven!";
                }
                else if (dateUser.yearly_milage < be2.yearly_milage)
                {
                    Bads.Text = "More distance driven";
                }
                //5
                if (dateUser.flights > be2.flights)
                {
                    Goods.Text = "Less flights taken!";
                }
                else if (dateUser.flights < be2.flights)
                {
                    Bads.Text = "More flights taken!";
                }
                //6
                if (dateUser.paper_rec == 0)
                {
                    Goods.Text = "Recycled paper!";
                }
                else
                {
                    Bads.Text = "Didn't recycle paper!";
                }
                //7
                if (dateUser.metal_rec == 0)
                {
                    Goods.Text = "Recycled metal!";
                }
                else
                {
                    Bads.Text = "Didn't recycle paper!";
                }

            }

            if (nr == 4)
            {
                ///1
                if (dateUser.electricity_bill > be3.electricity_bill)
                {
                    Goods.Text = "Lower electricity consumption!";
                }
                else if (dateUser.electricity_bill < be3.electricity_bill)
                {
                    Bads.Text = "Higher electricity consumption";
                }
                ///2
                if (dateUser.gas_bill > be3.gas_bill)
                {
                    Goods.Text = "Lower gas consumption!";
                }
                else if (dateUser.gas_bill < be3.gas_bill)
                {
                    Bads.Text = "Higher gas consumption";
                }
                ///3
                if (dateUser.oil_bill > be3.oil_bill)
                {
                    Goods.Text = "Lower oil consumption!";
                    Impacts.Text = "Improoved air quality!";
                }

                else if (dateUser.oil_bill < be3.oil_bill)
                {
                    Bads.Text = "Higher oil consumption";
                }
                ///4
                if (dateUser.yearly_milage > be3.yearly_milage)
                {
                    Goods.Text = "Smaller distance driven!";
                }
                else if (dateUser.yearly_milage < be1.yearly_milage)
                {
                    Bads.Text = "More distance driven";
                }
                //5
                if (dateUser.flights > be3.flights)
                {
                    Goods.Text = "Less flights taken!";
                }
                else if (dateUser.flights < be3.flights)
                {
                    Bads.Text = "More flights taken!";
                }
                //6
                if (dateUser.paper_rec == 0)
                {
                    Goods.Text = "Recycled paper!";
                }
                else
                {
                    Bads.Text = "Didn't recycle paper!";
                }
                //7
                if (dateUser.metal_rec == 0)
                {
                    Goods.Text = "Recycled metal!";
                }
                else
                {
                    Bads.Text = "Didn't recycle paper!";
                }

            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            //GENERAREA UNOR SUGESTII PENTRU IMBUNATATIRE BAZATE PE DATELE INTRODUSE DE UTILIZATOR IN SAPTAMANA CURENTA
            if (nr == 1)
            {


                if (be1.gas_bill > 300 * 0.092 * nr_persoane)
                    Sugests.Text += "-Reduce your gas consumption. You can take shorter showers and make sure water heating is not set too high. Old appliances or ones in need of repair can also use excess gas in the home."+ "\n\n";
                  if (be1.electricity_bill > 80 * 0.162 * nr_persoane)
                    Sugests.Text += "-Reduce your electricity consumption. You can replace standard lightbulbs with LEDs, only charge electric devices when needed and keep your fridge at a decent temperature (1.5-3C).\n\n";
                  if (car_type == 1 && be1.oil_bill > 20 * 0.971)
                    Sugests.Text += "-Reduce fuel consumption. Consider alternative means of transport such as bikes, electric scooters or walking for commuting short distances. Take alternative routes if the route to work includes numerous stop signs, hills, or traffic lights.\n\n";
                  if (be1.metal_rec==1 && be1.paper_rec==1)
                    Sugests.Text = "23e3e2Ws";
                  if (be1.paper_rec==1 && be1.metal_rec==0)
                    Sugests.Text += "-Recycle paper more effectively. Reduces greenhouse gas emissions that can contribute to climate change by avoiding methane emissions.\n\n";
                  if (be1.paper_rec==0 && be1.metal_rec==1)
                    Sugests.Text += "-Recycle metal more effectively. Ferrous metals, steel and iron, are commonly recycled. Also, metal does not biodegrade quickly, if at all, so it important to ensure metal does not end up in landfill.\n\n";
                  if (be1.gas_bill / 0.092 + be1.electricity_bill / 0.162 > 400)
                    Sugests.Text += "-Reduce your energy bill. Investing in energy-efficient appliances and making sure your home is well-insulated makes a significant difference in the electricity and gas bills.\n\n";
                  if (be1.yearly_milage > 100)
                    Sugests.Text += "-Use the car less. Consider alternative means of transport such as bikes, electric scooters or walking for commuting short distances. Using the car for unnecessary trips can greatly increase pollution, as well as the fuel and maintenance costs.\n\n";
                if (be1.flights >= 4)
                    Sugests.Text += "-Fly more responsible. Air travel is quickly becoming one of the worst contributors to climate change. Even driving is less carbon intensive than flying, so consider using alternative means of transport such as trains or buses.\n\n";
                
            }

            if (nr == 2)
            {
                if (be2.gas_bill > 300 * 0.092 * nr_persoane)
                    Sugests.Text += "-Reduce your gas consumption. You can take shorter showers and make sure water heating is not set too high. Old appliances or ones in need of repair can also use excess gas in the home.\n\n";
                  if (be2.electricity_bill > 80 * 0.162 * nr_persoane)
                    Sugests.Text += "-Reduce your electricity consumption. You can replace standard lightbulbs with LEDs, only charge electric devices when needed and keep your fridge at a decent temperature (1.5-3C).\n\n";
                  if (car_type == 1 && be2.oil_bill > 20 * 0.971)
                    Sugests.Text += "-Reduce fuel consumption. Consider alternative means of transport such as bikes, electric scooters or walking for commuting short distances. Take alternative routes if the route to work includes numerous stop signs, hills, or traffic lights.\n\n";
                  if (be2.metal_rec == 1 && be2.paper_rec == 1)
                    Sugests.Text += "-Recycle more. The amount of lost energy from throwing away recyclable commodities is equivalent to the annual output of 15 power plants. Read your local recycling guide and find local recycling facilities.\n\n";
                  if (be2.paper_rec == 1 && be2.metal_rec == 0)
                    Sugests.Text += "-Recycle paper more effectively. Reduces greenhouse gas emissions that can contribute to climate change by avoiding methane emissions.\n\n";
                  if (be2.paper_rec == 0 && be2.metal_rec == 1)
                    Sugests.Text += "-Recycle metal more effectively. Ferrous metals, steel and iron, are commonly recycled. Also, metal does not biodegrade quickly, if at all, so it important to ensure metal does not end up in landfill.\n\n";
                  if (be2.gas_bill / 0.092 + be2.electricity_bill / 0.162 > 400)
                    Sugests.Text += "-Reduce your energy bill. Investing in energy-efficient appliances and making sure your home is well-insulated makes a significant difference in the electricity and gas bills.\n\n";
                  if (be2.yearly_milage > 100)
                    Sugests.Text += "-Use the car less. Consider alternative means of transport such as bikes, electric scooters or walking for commuting short distances. Using the car for unnecessary trips can greatly increase pollution, as well as the fuel and maintenance costs.\n\n";
                  if (be2.flights >4)
                    Sugests.Text =Sugests.Text + "-Fly more responsible. Air travel is quickly becoming one of the worst contributors to climate change. Even driving is less carbon intensive than flying, so consider using alternative means of transport such as trains or buses.\n\n";
                 
            }

            if (nr == 3)
            {
                if (be3.gas_bill > 300 * 0.092 * nr_persoane)
                    Sugests.Text += "-Reduce your gas consumption. You can take shorter showers and make sure water heating is not set too high. Old appliances or ones in need of repair can also use excess gas in the home.\n\n";
                  if (be3.electricity_bill > 80 * 0.162 * nr_persoane)
                    Sugests.Text += "-Reduce your electricity consumption. You can replace standard lightbulbs with LEDs, only charge electric devices when needed and keep your fridge at a decent temperature (1.5-3C).\n\n";
                  if (car_type == 1 && be3.oil_bill > 20 * 0.971)
                    Sugests.Text += "-Reduce fuel consumption. Consider alternative means of transport such as bikes, electric scooters or walking for commuting short distances. Take alternative routes if the route to work includes numerous stop signs, hills, or traffic lights.\n\n";
                  if (be3.metal_rec == 1 && be3.paper_rec == 1)
                    Sugests.Text += "-Recycle more. The amount of lost energy from throwing away recyclable commodities is equivalent to the annual output of 15 power plants. Read your local recycling guide and find local recycling facilities.\n\n";
                  if (be3.paper_rec == 1 && be3.metal_rec == 0)
                    Sugests.Text += "-Recycle paper more effectively. Reduces greenhouse gas emissions that can contribute to climate change by avoiding methane emissions.\n\n";
                  if (be3.paper_rec == 0 && be3.metal_rec == 1)
                    Sugests.Text += "-Recycle metal more effectively. Ferrous metals, steel and iron, are commonly recycled. Also, metal does not biodegrade quickly, if at all, so it important to ensure metal does not end up in landfill.\n\n";
                  if (be3.gas_bill / 0.092 + be3.electricity_bill / 0.162 > 400)
                    Sugests.Text += "-Reduce your energy bill. Investing in energy-efficient appliances and making sure your home is well-insulated makes a significant difference in the electricity and gas bills.\n\n";
                  if (be3.yearly_milage > 100)
                    Sugests.Text += "-Use the car less. Consider alternative means of transport such as bikes, electric scooters or walking for commuting short distances. Using the car for unnecessary trips can greatly increase pollution, as well as the fuel and maintenance costs.\n\n";
                  if (be3.flights >= 4)
                    Sugests.Text += "-Fly more responsible. Air travel is quickly becoming one of the worst contributors to climate change. Even driving is less carbon intensive than flying, so consider using alternative means of transport such as trains or buses.\n\n";
                
            }

            if (nr == 4)
            {
                if (be4.gas_bill > 300 * 0.092 * nr_persoane)
                    Sugests.Text += "-Reduce your gas consumption. You can take shorter showers and make sure water heating is not set too high. Old appliances or ones in need of repair can also use excess gas in the home.\n\n";
                  if (be4.electricity_bill > 80 * 0.162 * nr_persoane)
                    Sugests.Text += "-Reduce your electricity consumption. You can replace standard lightbulbs with LEDs, only charge electric devices when needed and keep your fridge at a decent temperature (1.5-3C).\n\n";
                  if (car_type == 1 && be4.oil_bill > 20 * 0.971)
                    Sugests.Text += "-Reduce fuel consumption. Consider alternative means of transport such as bikes, electric scooters or walking for commuting short distances. Take alternative routes if the route to work includes numerous stop signs, hills, or traffic lights.\n\n";
                  if (be4.metal_rec == 1 && be4.paper_rec == 1)
                    Sugests.Text += "-Recycle more. The amount of lost energy from throwing away recyclable commodities is equivalent to the annual output of 15 power plants. Read your local recycling guide and find local recycling facilities.\n\n";
                  if (be4.paper_rec == 1 && be4.metal_rec == 0)
                    Sugests.Text += "-Recycle paper more effectively. Reduces greenhouse gas emissions that can contribute to climate change by avoiding methane emissions.\n\n";
                  if (be4.paper_rec == 0 && be4.metal_rec == 1)
                    Sugests.Text += "-Recycle metal more effectively. Ferrous metals, steel and iron, are commonly recycled. Also, metal does not biodegrade quickly, if at all, so it important to ensure metal does not end up in landfill.\n\n";
                  if (be4.gas_bill / 0.092 + be4.electricity_bill / 0.162 > 400)
                    Sugests.Text += "-Reduce your energy bill. Investing in energy-efficient appliances and making sure your home is well-insulated makes a significant difference in the electricity and gas bills.\n\n";
                  if (be4.yearly_milage > 100)
                    Sugests.Text += "-Use the car less. Consider alternative means of transport such as bikes, electric scooters or walking for commuting short distances. Using the car for unnecessary trips can greatly increase pollution, as well as the fuel and maintenance costs.\n\n";
                  if (be4.flights >= 4)
                    Sugests.Text += "-Fly more responsible. Air travel is quickly becoming one of the worst contributors to climate change. Even driving is less carbon intensive than flying, so consider using alternative means of transport such as trains or buses.\n\n";
                 
            }

            ///------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new User();
            User.Visibility = Visibility.Collapsed;
            Sugestii.Visibility = Visibility.Collapsed;
            Sugests.Visibility = Visibility.Collapsed;
            Statistici.Visibility = Visibility.Collapsed;
            Stats.Visibility = Visibility.Collapsed;
            Sageata.Visibility = Visibility.Collapsed;
            Goods.Visibility = Visibility.Collapsed;
            Bads.Visibility = Visibility.Collapsed;
            Impacts.Visibility = Visibility.Collapsed;
            UserBtn.Visibility = Visibility.Collapsed;
            Goodies.Visibility = Visibility.Collapsed;
            Baddies.Visibility = Visibility.Collapsed;
            Impacturi.Visibility = Visibility.Collapsed;
        }

       
    }
}
