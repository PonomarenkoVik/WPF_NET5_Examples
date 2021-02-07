using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommonEntities.ModelViewInterfaces
{
    public interface ILibraryAddBookWindowModelView
    {
        string BookName { get; set; }
        string BookId { get; set; }
        string ICBN { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        string Edition { get; set; }
        string BookShelf { get; set; }
        string Row { get; set; }
        string Column { get; set; }
        string AddButtonTooltip { get; set; }
        ICommand Add { get; set; }
        string ErrorMessage { get; }
    }
}
