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
using static Greenify.MainWindow;

namespace Greenify
{
    public partial class Details : Page
    {

        public struct e1
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public double carbon;
            public bool metal_rec;
            public bool paper_rec;
        }
        public struct e2
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public double carbon;
            public bool metal_rec;
            public bool paper_rec;
        }
        public struct e3
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public double carbon;
            public bool metal_rec;
            public bool paper_rec;
        }
        public struct e4
        {
            public double electricity_bill;
            public double gas_bill;
            public double oil_bill;
            public double yearly_milage;
            public double flights;
            public double carbon;
            public bool metal_rec;
            public bool paper_rec;
        }

        e1 be1;
        e2 be2;
        e3 be3;
        e4 be4;
        public Details()
        {
            InitializeComponent();
            /*
            elec_bill1.Inlines.Add(new Run(b1.electricity_bill.ToString()));
            gas_bill1.Inlines.Add(new Run(eb1.gas_bill.ToString()));
            oil_bill1.Inlines.Add(new Run(eb1.oil_bill.ToString()));
            wk_mil1.Inlines.Add(new Run(eb1.weekly_milage.ToString()));
            nr_fl1.Inlines.Add(new Rune(b1.flights.ToString()));

            elec_bill2.Inlines.Add(new Run(eb2.electricity_bill.ToString()));
            gas_bill2.Inlines.Add(new Run(eb2.gas_bill.ToString()));
            oil_bill2.Inlines.Add(new Run(eb2.oil_bill.ToString()));
            wk_mil2.Inlines.Add(new Run(eb2.weekly_milage.ToString()));
            nr_fl2.Inlines.Add(new Run(eb2.flights.ToString()));

            elec_bill3.Inlines.Add(new Run(eb3.electricity_bill.ToString()));
            gas_bill3.Inlines.Add(new Run(eb3.gas_bill.ToString()));
            oil_bill3.Inlines.Add(new Run(eb3.oil_bill.ToString()));
            wk_mil3.Inlines.Add(new Rune(b3.weekly_milage.ToString()));
            nr_fl3.Inlines.Add(new Rune(b3.flights.ToString()));

            elec_bill4.Inlines.Add(new Run(b4.electricity_bill.ToString()));
            gas_bill4.Inlines.Add(new Run(eb4.gas_bill.ToString()));
            oil_bill4.Inlines.Add(new Run(eb4.oil_bill.ToString()));
            wk_mil4.Inlines.Add(new Run(eb4.weekly_milage.ToString()));
            nr_fl4.Inlines.Add(new Run(eb4.flights.ToString()));

            elec_bill5.Inlines.Add(new Run(((eb1.electricity_bill + eb2.electricity_bill + eb3.electricity_bill + b4.electricity_bill) / 4).ToString()));
            gas_bill5.Inlines.Add(new Run(((eb1.gas_bill + eb2.gas_bill + eb3.gas_bill + b4.gas_bill) / 4).ToString()));
            oil_bill5.Inlines.Add(new Run(((eb1.oil_bill + eb2.oil_bill + eb3.oil_bill + eb4.oil_bill) / 4).ToString()));
            wk_mil5.Inlines.Add(new Run(((eb1.weekly_milage + eb2.weekly_milage + eb3.weekly_milage + eb4.weekly_milage) / 4).ToString()));
            nr_fl5.Inlines.Add(new Run(((eb1.flights + eb2.flights + eb3.flights + eb4.flights) / 4).ToString()));

            elec_bill6.Inlines.Add(new Run((1.674*0.162).ToString()));
            gas_bill6.Inlines.Add(new Run((250*2.28).ToString());
            oil_bill6.Inlines.Add(new Run((nr_persoane*1.73*0.971).ToString());
            wk_mil6.Inlines.Add(new Run("14"));
            nr_fl6.Inlines.Add(new Run("0"));
            */
        }

       

        
        private void Date_Click(object sender, RoutedEventArgs e)
        {
            ///CITIREA VALORILOR STOCATE DE PROGRAM IN SAPTAMANILE ANTERIOARE
            ///1
            StreamReader reading1 = new StreamReader("D:\\Coding\\C#\\Polihack\\Main\\MainProject\\Normal\\DB_txt\\e1.txt");
            string line1;
            line1 = reading1.ReadLine();
            be1.electricity_bill = Convert.ToDouble(line1);
            line1 = reading1.ReadLine();
            be1.gas_bill = Convert.ToDouble(line1);
            line1 = reading1.ReadLine();
            be1.oil_bill = Convert.ToDouble(line1);
            line1 = reading1.ReadLine();
            be1.yearly_milage = Convert.ToDouble(line1);
            line1 = reading1.ReadLine();
            be1.flights = Convert.ToDouble(line1);
            line1 = reading1.ReadLine();
            be1.paper_rec = Convert.ToBoolean(line1);
            line1 = reading1.ReadLine();
            be1.metal_rec = Convert.ToBoolean(line1);
            reading1.Close();
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
                be2.paper_rec = Convert.ToBoolean(line2);
                line2 = e2.ReadLine();
                be2.metal_rec = Convert.ToBoolean(line2);
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
            be3.paper_rec = Convert.ToBoolean(line3);
            line3 = e3.ReadLine();
            be3.metal_rec = Convert.ToBoolean(line3);
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
            be4.paper_rec = Convert.ToBoolean(line4);
            line4 = e4.ReadLine();
            be4.metal_rec = Convert.ToBoolean(line4);
            line4 = e4.ReadLine();
            be4.carbon = Convert.ToDouble(line4);

            e4.Close();
        }
    }
}
