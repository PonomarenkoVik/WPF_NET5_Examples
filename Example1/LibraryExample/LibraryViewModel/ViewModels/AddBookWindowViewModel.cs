using CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryViewModel.ViewModels
{
    public class AddBookWindowViewModel : ViewModelBase
    {
        private ILibraryBL _bl;
        public AddBookWindowViewModel(ILibraryBL bl)
        {
            _bl = bl;
        }
    }
}
