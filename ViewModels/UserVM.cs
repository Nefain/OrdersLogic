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
    public class UserVM : INotifyPropertyChanged
    {
        private UserModel _userModel = new UserModel();
        UserManager user;
        public UserModel UserModel
        {
            get { return _userModel; }
            set
            {
                _userModel.UserId = value.UserId;
                _userModel.Name = value.Name;
                _userModel.Password = value.Password;
                _userModel.UserOrdersIdGuid = value.UserOrdersIdGuid;
                user = new UserManager();
                OnPropertyChanged(nameof(PaymentModel));
            }
        }

        public UserVM()
        {
            UserModel = new UserModel();
        }

        public List<UserModel> GetAllUsers()
        {
            return user.Get().ToList();
        }

        public UserModel IsOkay()
        {
            var alluser = user.Get();
            foreach(var i in alluser.Where(b => b.Name == _userModel.Name && b.Password == _userModel.Password))
            {
                return i;
            }
            return null;
        }
        public void UpdateUser()
        {
            user.Update(_userModel);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
