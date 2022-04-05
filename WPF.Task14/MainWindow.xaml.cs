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

namespace WPF.Task14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Холодильник",
                Price = 60000,
                ImgPath = "Data/fridge.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                Name = "Микроволновка",
                Price = 10000,
                ImgPath = "Data/microwave.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                Name = "Креветки",
                Price = 1000,
                ImgPath = "Data/prawns.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                Name = "Авокадо",
                Price = 500,
                ImgPath = "Data/avocado.jpg",
                ProductCategory = ProductCategories.Food
            });
            listBox.ItemsSource = products;
        }
    }
}
