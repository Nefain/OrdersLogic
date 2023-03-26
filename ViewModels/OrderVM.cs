using OrdersLogic.Managers;
using OrdersLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLogic.ViewModels
{
    public class OrderVM : INotifyPropertyChanged
    {
        private OrderModel _orderModel = new OrderModel();

        OrderManager order = new OrderManager();
        public OrderModel OrderModel
        {
            get { return _orderModel; }
            set
            {
                _orderModel.IdOrder = value.IdOrder;
                _orderModel.OrderDate = value.OrderDate;
                _orderModel.Sum = value.Sum;
                _orderModel.Balance = value.Balance;
                OnPropertyChanged(nameof(PaymentModel));
            }
        }

        public OrderVM()
        {
            OrderModel = new OrderModel();
        }
        public void AddOrder()
        {
            order.Post(_orderModel);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
