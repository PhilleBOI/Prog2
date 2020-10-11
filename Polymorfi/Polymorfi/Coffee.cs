using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi
{
    class Coffee : Product
    {
        private string _rostyness;

        public string Rostyness
        {
            get { return _rostyness; }
            set { _rostyness = value; }
        }

    }
}
