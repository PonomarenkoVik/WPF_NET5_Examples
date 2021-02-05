using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public interface IDialogProvider<T>
    {
        void ShowDialog(T param);
    }
}
