﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities
{
    public interface IDialogProvider<P, R>
    {
        R ShowDialog(P param);
    }
}