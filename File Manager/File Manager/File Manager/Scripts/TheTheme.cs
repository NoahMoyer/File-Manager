using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace File_Manager.Scripts
{
    public static class TheTheme
    {
        public static void setTheme()
        {
            var e = DependencyService.Get<IEnvironment>();
            if(App.Current.RequestedTheme == OSAppTheme.Dark)
            {
                e?.SetStatusBarColor(Color.Black, false);
            }
            else
            {
                e?.SetStatusBarColor(Color.White, true);
            }
    }
    }
        
}
