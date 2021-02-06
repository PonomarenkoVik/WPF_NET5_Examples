using CommonEntities;
using CommonEntities.ModelViewInterfaces;
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

namespace LibraryView
{
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window, IDialogProvider<object>
    {
        public AddBookWindow(ILibraryAddBookWindowModelView viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
        }

        public void Show(object param) => Show();
       
        public void ShowDialog(object param) => ShowDialog();
    }
}
