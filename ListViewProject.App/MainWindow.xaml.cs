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

namespace ListViewProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Order> Orders { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            Orders = new ObservableCollection<Order>()
                {
                    new Order()
                    {
                        ConfirmationID = Guid.NewGuid(),
                        Products = new ObservableCollection<Product>
                        {
                           new Product
                           {
                               Name = "Font bumper",
                               Description = "1/4 steel bumper designed for offroad capiblies",
                               LocationHistory = new ObservableCollection<Location>
                                 {
                                  new Location
                                    {
                                       Address = "909 N Riverfront Blvd, Dallas, TX 75207",
                                       Status = DeliveryStatus.OrderConfirmed
                                    },
                                   new Location
                                   {
                                       Address = "909 N Riverfront Blvd, Dallas, TX 75207",
                                      Status = DeliveryStatus.Shipped
                                   },
                                   new Location
                                   {
                                       Address = "Home address",
                                      Status = DeliveryStatus.Delivered
                                   }
                               },
                               Price = 149.99m
                           },
                           new Product
                           {
                                Name = "50 inch Light bar",
                               Description = "Light up the night with this light bar",
                               LocationHistory = new ObservableCollection<Location>
                                 {
                                  new Location
                                    {
                                       Address = "909 N Riverfront Blvd, Dallas, TX 75207",
                                       Status = DeliveryStatus.OrderConfirmed
                                    },
                                   new Location
                                   {
                                       Address = "909 N Riverfront Blvd, Dallas, TX 75207",
                                      Status = DeliveryStatus.Shipped
                                   },
                               },
                               Price = 89.00m
                           }
                        }
                    },
                };
            _listView.ItemsSource = Orders;

        }
    }
 
    public class Order
    {
        public Guid ConfirmationID { get; set; }
        public ObservableCollection<Product> Products { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantiy { get; set; }
        public decimal Price { get; set; }
        public ObservableCollection<Location> LocationHistory { get; set; }

    }
    public class Location
    {
        public string Address { get; set; }
        public DeliveryStatus Status { get; set; }
    }
    public enum DeliveryStatus
    {
        OrderConfirmed = 1,
        Shipped = 2,
        Delivered = 3

    }


}

