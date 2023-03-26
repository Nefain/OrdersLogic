using OrdersLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrdersLogic.Managers;
using System.Windows.Controls;
using Newtonsoft.Json;
using System.Windows;

namespace OrdersLogic.ViewModels
{
    public class PaymentVM : INotifyPropertyChanged
    {
        private PaymentModel _paymentModel = new PaymentModel();
        public List<TrancheModel> Tranches { get; set; }
        public List<OrderModel> Orders { get; set; }

        OrderManager order = new OrderManager();
        TrancheManager tranche = new TrancheManager();

        PaymentManager payment;
        public PaymentModel PaymentModel
        {
            get { return _paymentModel; }
            set
            {
                _paymentModel.IdOrder = value.IdOrder;
                _paymentModel.IdTranche = value.IdTranche;
                _paymentModel.TotalPayment = value.TotalPayment;
                payment = new PaymentManager();
                OnPropertyChanged(nameof(PaymentModel));
            }
        }

        public PaymentVM()
        {
            PaymentModel = new PaymentModel();
        }
        
        public PaymentModel FindPayment()
        {
            return payment.GetId(_paymentModel);
        }
        public List<PaymentModel> GetAllPayment()
        {
            return payment.Get().ToList();
        }

        public void AddPayment(UserVM user)
        {
            if(user.UserModel.UserOrdersIdGuid != _paymentModel.IdOrder)
            {
                user.UserModel.UserOrdersIdGuid = _paymentModel.IdOrder;
            }
            try
            {
                user.UpdateUser();
            }
            catch
            {
                MessageBox.Show("Вы выбрали заказ, который оплачивает другой пользователь", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var alluser = user.GetAllUsers();
            payment.Post(_paymentModel);
        }

        public List<OrderModel> OrderComBoxList()
        {
            Orders = order.Get().ToList();
            return Orders; 
        }

        public OrderModel GetOrderDataGrid(string Gid)
        {
            OrderModel newModel = new OrderModel();
            newModel.IdOrder = Guid.Parse(Gid);
            var result = order.GetId(newModel);
            return result;
        }

        public List<TrancheModel> TrancheComBoxList()
        {
            Tranches = tranche.Get().ToList();
            return Tranches;
        }

        public TrancheModel GetTrancheDataGrid(string Gid)
        {
            TrancheModel newModel = new TrancheModel();
            newModel.IdTranche = Guid.Parse(Gid);
            var result = tranche.GetId(newModel);
            return result;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
