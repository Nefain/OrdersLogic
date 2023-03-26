using OrdersLogic.Managers;
using OrdersLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLogic.ViewModels
{
    public class TrancheVM : INotifyPropertyChanged
    {
        private TrancheModel _trancheModel = new TrancheModel();

        TrancheManager tranche = new TrancheManager();
        public TrancheModel TrancheModel
        {
            get { return _trancheModel; }
            set
            {
                _trancheModel.IdTranche = value.IdTranche;
                _trancheModel.TrancheDate = value.TrancheDate;
                _trancheModel.Sum = value.Sum;
                _trancheModel.Residual = value.Residual;
                OnPropertyChanged(nameof(PaymentModel));
            }
        }

        public TrancheVM()
        {
            TrancheModel = new TrancheModel();
        }
        public void AddTranche()
        {
            tranche.Post(_trancheModel);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
