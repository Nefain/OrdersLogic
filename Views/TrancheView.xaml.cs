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
using OrdersLogic.ViewModels;

namespace OrdersLogic.Views
{
    /// <summary>
    /// Логика взаимодействия для TrancheView.xaml
    /// </summary>
    public partial class TrancheView : Window
    {
        public TrancheView()
        {
            InitializeComponent();
            TrancheVM viewModel = new TrancheVM();
            DataContext = viewModel;
        }

        private void AddNewTrancheButton_Click(object sender, RoutedEventArgs e)
        {
            decimal sum = decimal.Parse(TrancheSumTextBox.Text);
            DateTime trancheDate = TrancheDatePicker.SelectedDate.Value;

            TrancheVM trancheVM = (TrancheVM)DataContext;
            trancheVM.TrancheModel.Sum = sum;
            trancheVM.TrancheModel.Residual = sum;
            trancheVM.TrancheModel.TrancheDate = trancheDate;

            trancheVM.AddTranche();
            Close();
        }
    }
}
