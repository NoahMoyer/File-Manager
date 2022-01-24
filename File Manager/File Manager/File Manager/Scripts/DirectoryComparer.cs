using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace File_Manager.Scripts
{
    public class DirectoryComparer : IComparer
    {
        //sorts directories in alphabetic order by name
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((DirectoryInfo)x).Name, ((DirectoryInfo)y).Name);
        }
    }
}
