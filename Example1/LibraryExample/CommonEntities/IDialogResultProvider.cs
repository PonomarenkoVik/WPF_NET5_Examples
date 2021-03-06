﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public interface IDialogResultProvider<T, R>
    {
        R ShowDialog(T param);
    }
}
