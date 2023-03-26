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
    public partial class LoginWindow : Window
    {
        UserVM userModel = new UserVM();

        public LoginWindow()
        {
            InitializeComponent();
            DataContext = userModel;
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            UserVM userVM = (UserVM)DataContext;
            userVM.UserModel.Name = LoginBox.Text;
            userVM.UserModel.Password = newPasswordBox.Password;
            var userChek = userVM.IsOkay();
            if(userChek == null) 
            {
                MessageBox.Show("Неправильно введенный пароль или логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            userVM.UserModel = userChek;
            PaymentWindow taskWindow = new PaymentWindow(userVM);
            taskWindow.Show();
            Close();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
