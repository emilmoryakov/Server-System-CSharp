using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Picasso.View;
using System.Windows;

namespace Picasso
{
    public class LoginViewModel : ViewModelBase
    {
        public RelayCommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            // Implement login logic here
            // For example, you can check if username and password are valid

            MessageBox.Show("Logged in successfully!");
        }

        // Handle navigation to registration view
        private void OpenRegistration()
        {
            var registrationView = new RegisterView();
            var registrationViewModel = new RegisterViewModel();
            registrationView.DataContext = registrationViewModel;
            registrationView.Show();












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
