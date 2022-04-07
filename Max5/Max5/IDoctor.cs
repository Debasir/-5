using System;
using System.Collections.Generic;
using System.Text;

namespace Max5
{
    interface IDoctor
    {
        string WorkState
        {
            get;
            set;
        }

        void Work();

        void StopWork();
    }
}
