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

namespace Mobilek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBaseTest();
        }
        public void DataBaseTest()
        {
            MobilekEntities entities = new MobilekEntities();

            Station newStation = new Station();
            newStation.city = "Wwa";
            newStation.street = "Powsinska";
            newStation.streetNumer = 40;
            newStation.zipCode = "0,7";

            entities.Stations.Add(newStation);

            entities.SaveChanges();
        }
    }
}
