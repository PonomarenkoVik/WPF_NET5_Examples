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
    public partial class AddBookWindow : Window, IDialogResultProvider<object, Result<bool, string>>
    {
        ILibraryAddBookWindowModelView _viewModel;
        public AddBookWindow(ILibraryAddBookWindowModelView viewModel)
        {
            this.DataContext = _viewModel = viewModel;
            InitializeComponent();
        }


        public Result<bool, string> ShowDialog(object param)
        {
            var res = ShowDialog();
            return new Result<bool, string>(res.HasValue ? res.Value : false, _viewModel.ErrorMessage);
        }
    }
}
