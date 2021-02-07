using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public interface ILibraryBL : IDisposable
    {
        bool TryAddBook(Book book, out string mess);
    }
}
