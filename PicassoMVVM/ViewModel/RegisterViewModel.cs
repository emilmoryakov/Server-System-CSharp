using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Picasso.ViewModel;
using System.Windows;

namespace Picasso
{
    public class RegisterViewModel : ViewModelBase
    {
        public RelayCommand RegisterCommand { get; private set; }

        public RegisterViewModel()
        {
            RegisterCommand = new RelayCommand(Register);
        }

        private void Register()
        {
            // Implement registration logic here
            // For example, you can validate and store user information

            MessageBox.Show("Registered successfully!");
        }

        // Handle navigation to login view
        private void OpenLogin()
        {
            var loginView = new MainWindow();
            var loginViewModel = new LoginViewModel();
            loginView.DataContext = loginViewModel;
            loginView.Show();

            CloseWindow();
        }

        private void CloseWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.Close();
                    break;
                }
            }
        }
    }
}
