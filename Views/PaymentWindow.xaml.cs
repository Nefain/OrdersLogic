using OrdersLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
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
using OrdersLogic.Views;
using System.Windows.Ink;
using OrdersLogic.Models;
using System.ComponentModel;

namespace OrdersLogic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        PaymentVM viewModel = new PaymentVM();
        UserVM _crurrenUser = new UserVM();
        public PaymentWindow(UserVM currentUser)
        {
            InitializeComponent();
            DataContext = viewModel;
            var strOrd = viewModel.OrderComBoxList();
            foreach (var i in strOrd)
            {
                OrderComboBox.Items.Add($"{i.IdOrder}\n");
            }
            var strTran = viewModel.TrancheComBoxList();
            foreach (var i in strTran)
            {
                TrancheComboBox.Items.Add($"{i.IdTranche}\n");
            }
            _crurrenUser = currentUser;
            Closing += OnWindowClosing;
        }
        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            LoginWindow taskWindow = new LoginWindow();
            taskWindow.Show();
        }
        private void AddPayment_Click(object sender, RoutedEventArgs e)
        {
            SumWindow sumWindow = new SumWindow();
            PaymentVM mainVM = (PaymentVM)DataContext;
            if (OrderComboBox.SelectedValue == null || TrancheComboBox.SelectedValue == null)
            {
                MessageBox.Show("Вы не выбрали Заказ или Приход Денег", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            mainVM.PaymentModel.IdOrder = Guid.Parse(OrderComboBox.SelectedValue.ToString());
            mainVM.PaymentModel.IdTranche = Guid.Parse(TrancheComboBox.SelectedValue.ToString());
            if (sumWindow.ShowDialog() == true)
            {
                mainVM.PaymentModel.TotalPayment = decimal.Parse(sumWindow.SumPaymentBox.Text);
            }
            mainVM.AddPayment(_crurrenUser);

            //OrderComboBox.Items.Add(ordersAsString.ToString());
            //string strTra = viewModel.TrancheComBoxList();
        }

        private void OrderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderComboBox.SelectedValue == null)
            {
                return;
            }
            var dataOrder = viewModel.GetOrderDataGrid(OrderComboBox.SelectedValue.ToString());
            List<OrderModel> AddList = new List<OrderModel>();
            AddList.Add(dataOrder);
            OrderList.ItemsSource = AddList;
        }

        private void TrancheComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TrancheComboBox.SelectedValue == null)
            {
                return;
            }
            var dataTranche = viewModel.GetTrancheDataGrid(TrancheComboBox.SelectedValue.ToString());
            List<TrancheModel> AddList = new List<TrancheModel>();
            AddList.Add(dataTranche);
            TrancheList.ItemsSource = AddList;
        }

        private void ShowPayment_Click(object sender, RoutedEventArgs e)
        {
            PaymentVM mainVM = (PaymentVM)DataContext;
            if (OrderComboBox.SelectedValue == null || TrancheComboBox.SelectedValue == null)
            {
                MessageBox.Show("Вы не выбрали Заказ или Приход Денег", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            mainVM.PaymentModel.IdOrder = Guid.Parse(OrderComboBox.SelectedValue.ToString());
            mainVM.PaymentModel.IdTranche = Guid.Parse(TrancheComboBox.SelectedValue.ToString());
            var allPayments = mainVM.GetAllPayment();
            PaymentsList.ItemsSource = allPayments;

        }

        private void ShowOrderTranche_Click(object sender, RoutedEventArgs e)
        {
            var strTran = viewModel.TrancheComBoxList();
            var oldValueOrder = OrderComboBox.SelectedValue;
            var oldValueTranche = TrancheComboBox.SelectedValue;
            TrancheComboBox.Items.Clear();
            foreach (var i in strTran)
            {
                TrancheComboBox.Items.Add($"{i.IdTranche}\n");
            }
            TrancheComboBox.SelectedItem = oldValueTranche;

            var strOrd = viewModel.OrderComBoxList();
            OrderComboBox.Items.Clear();
            foreach (var i in strOrd)
            {
                OrderComboBox.Items.Add($"{i.IdOrder}\n");
            }
            OrderComboBox.SelectedItem = oldValueOrder;
        }
    }
}
