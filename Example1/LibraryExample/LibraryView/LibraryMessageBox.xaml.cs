using CommonEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace LibraryView
{
    /// <summary>
    /// Interaction logic for LibraryMessageBox.xaml
    /// </summary>
    public partial class LibraryMessageBox : Window, INotifyPropertyChanged, IDialogProvider<(string title, string message)>
    {
        public LibraryMessageBox()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string _messageTitle;
        public string MessageTitle
        {
            get { return _messageTitle; }
            set 
            { 
                _messageTitle = value;
                OnPropertyChanged();
            }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public void ShowDialog((string title, string message) param)
        {
            MessageTitle = param.title;
            Message = param.message;
            ShowDialog();
        }

        public void Show((string title, string message) param)
        {
            throw new NotImplementedException();
        }
    }
}
