﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    interface IObserver
    {
        void Update();
        void UpdateDel();
    }
}
