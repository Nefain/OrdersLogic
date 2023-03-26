using OrdersLogic.Models;
using OrdersLogic.ViewModels;
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
using System.Windows.Shapes;

namespace OrdersLogic.Views
{
    /// <summary>
    /// Логика взаимодействия для OrderView.xaml
    /// </summary>
    public partial class OrderView : Window
    {
        public OrderView()
        {
            InitializeComponent();
            OrderVM viewModel = new OrderVM();
            DataContext = viewModel;
        }
        

        private void AddNewOrder_Click(object sender, RoutedEventArgs e)
        {
            decimal sum = decimal.Parse(SumOrderTextBox.Text);
            DateTime orderDate = DateOrderDatePicker.SelectedDate.Value;

            OrderVM orderVM = (OrderVM)DataContext;
            orderVM.OrderModel.Sum = sum;
            orderVM.OrderModel.OrderDate = orderDate;

            orderVM.AddOrder();
            Close();
        }
    }
}
