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
using transport.Types;

namespace transport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Vehicles> vehiclesList = new();
        List<string> namesVehiclesList = new();

        byte carsCount;
        byte bicyclesCount;
        byte airplanesCount;

        private string GetCount => "Машины\tВелосипеды\tСамолёты\n" +
                                  $"{carsCount}\t\t{bicyclesCount}\t\t{airplanesCount}";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rewrite_Button_Click(object sender, RoutedEventArgs e)
        {
            
            CreateList();

            ListView.Items.Refresh();
            ListView.ItemsSource = namesVehiclesList;
        }

        private void CreateList()
        {
            vehiclesList.Clear();
            namesVehiclesList.Clear();

            carsCount = 0;
            bicyclesCount = 0;
            airplanesCount = 0;

            for (var i = 0; i < 10; ++i)
            {
                var random = new Random();

                switch (random.Next() % 3)
                {
                    case 0:
                        vehiclesList.Add(new Car(1, 2.5f, 4));
                        namesVehiclesList.Add("Машина");
                        carsCount++;
                        break;
                    case 1:
                        vehiclesList.Add(new Bicycle(2, 27));
                        namesVehiclesList.Add("Велосипед");
                        bicyclesCount++;
                        break;
                    case 2:
                        vehiclesList.Add(new Airplane(1, 11.4f));
                        namesVehiclesList.Add("Самолёт");
                        airplanesCount++;
                        break;
                }

                Count_Label.Content = GetCount;  
            }
        }

        private void TakeVehicles()
        {
            if (vehiclesList.Count == 0)
            {
                Name_Label.Content = "Пусто `(*>﹏<*)′";
                return;
            }
            
            var vehicles = vehiclesList[0];
           
            vehiclesList.RemoveAt(0);

            if (vehicles is Car)
            {
                Name_Label.Content = "Машина";
            }
            else if (vehicles is Bicycle)
            {
                Name_Label.Content = "Велосипед";
            }
            else if (vehicles is Airplane)
            {
                Name_Label.Content = "Самолет";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TakeVehicles();
        }
    }
}