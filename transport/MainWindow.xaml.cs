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

            var random = new Random();
            int count = random.Next() % 10 + 5;
            for (var i = 0; i < count; i++)
            {

                switch (random.Next() % 3)
                {
                    case 0:
                        vehiclesList.Add(new Car(4, (byte)(random.Next() % 4 + 1), (float)random.Next() % 150 / 10, (byte)(random.Next() % 3 + 2)));
                        namesVehiclesList.Add("Машина");
                        carsCount++;
                        break;
                    case 1:
                        vehiclesList.Add(new Bicycle(2, (byte)(random.Next() % 3 + 1), (byte)(random.Next() % 18 + 12)));
                        namesVehiclesList.Add("Велосипед");
                        bicyclesCount++;
                        break;
                    case 2:
                        vehiclesList.Add(new Airplane((byte)(random.Next() % 21 + 3), (byte)(random.Next() % 3 + 1), (float)(random.Next() % 100 / 10 + 10)));
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
                Info_Label.Content = "";
                Image.Source = new BitmapImage(new Uri("", UriKind.Relative));
                return;
            }
            
            var vehicles = vehiclesList[0];
           
            vehiclesList.RemoveAt(0);
            namesVehiclesList.RemoveAt(0);


            switch (vehicles)
            {
                case Car:
                    Name_Label.Content = "Машина";
                    break;
                case Bicycle:
                    Name_Label.Content = "Велосипед";
                    break;
                case Airplane:
                    Name_Label.Content = "Самолет";
                    break;
            }

            Info_Label.Content = vehicles.Info();
            Image.Source = new BitmapImage(new Uri(vehicles.Image, UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TakeVehicles();
            ListView.Items.Refresh();
        }
    }
}