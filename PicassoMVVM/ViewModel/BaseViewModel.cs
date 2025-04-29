using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace Picasso
{
    public class BaseViewModel : ViewModelBase
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { Set(ref _isBusy, value); }
        }

        private string _statusMessage;
        public string StatusMessage
        {
            get { return _statusMessage; }
            set { Set(ref _statusMessage, value); }
        }

        public RelayCommand CloseWindowCommand { get; private set; }

        public BaseViewModel()
        {
            CloseWindowCommand = new RelayCommand(CloseWindow);
        }

        protected virtual void CloseWindow()
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

        protected void ShowStatusMessage(string message)
        {
            StatusMessage = message;
        }
    }
}
