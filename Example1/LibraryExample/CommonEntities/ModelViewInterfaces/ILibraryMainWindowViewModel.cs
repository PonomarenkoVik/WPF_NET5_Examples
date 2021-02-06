using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommonEntities
{
    public interface ILibraryMainWindowViewModel : IDisposable
    {
        void SetView(ILibraryMainWindowView view);
        ICommand AddBook { get; set; }
    }
}
