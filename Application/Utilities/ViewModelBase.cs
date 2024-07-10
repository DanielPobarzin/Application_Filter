using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows;

namespace FiltersApplication.Utilities
{
    public class ViewModelBase : INotifyPropertyChanged
    {
		private ICommand _closeCommand;
		private ICommand _maxCommand;
		public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propName ) );
        }
        public void CloseApp(object obj)
        {
            MainProject win = obj as MainProject;
            win.Close();
        }
        public ICommand CloseAppCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(p => CloseApp(p));
                }
                return _closeCommand;
            }
        }
        public void MaxApp(object obj)
        {
            MainProject win = obj as MainProject;

            if (win.WindowState == WindowState.Normal)
            {
                win.WindowState = WindowState.Maximized;
            }
            else if (win.WindowState == WindowState.Maximized)
            {
                win.WindowState = WindowState.Normal;
            }
        }
        public ICommand MaxAppCommand
        {
            get
            {
                if (_maxCommand == null)
                {
                    _maxCommand = new RelayCommand(p => MaxApp(p));
                }
                return _maxCommand;
            }
        }

    }
}
