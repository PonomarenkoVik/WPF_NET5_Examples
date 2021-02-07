using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public interface ILibraryData : IDisposable
    {
        bool TryAddBook(Book book, out string mess);
    }
}
