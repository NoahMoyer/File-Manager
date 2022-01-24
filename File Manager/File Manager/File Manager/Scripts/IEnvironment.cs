using System;
using System.Collections.Generic;
using System.Text;

namespace File_Manager.Scripts
{
    public interface IEnvironment
    {
        void SetStatusBarColor(System.Drawing.Color color, bool darkStatusBarTint);
    }
}
