using CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBusinessLayer
{
    public class LibraryBL : ILibraryBL
    {
        ILibraryData _dataLayer;
        public LibraryBL(ILibraryData data)
        {
            _dataLayer = data;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool TryAddBook(Book book, out string mess)
        {
            mess = null;
            return /*_dataLayer.TryAddBook(book, out mess)*/ true;
        }
    }
}
