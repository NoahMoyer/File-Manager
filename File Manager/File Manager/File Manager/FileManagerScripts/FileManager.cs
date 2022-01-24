//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace File_Manager.FileManagerScripts
{
    class FileManager
    {
        //Default directory
        DirectoryInfo dir = new DirectoryInfo(@"/storage/emulated/0/");


        //variable for directory name
        //List<String> directories = new List<string>;


        //gets the files of the current directory
        public FileInfo[] getFiles()
        {
            return dir.GetFiles();
        }

        public DirectoryInfo[] getDirectories()
        {

            return dir.GetDirectories();
        }

        public DirectoryInfo getCurrentDirectory()
        {
            return dir;
        }
        public void updateDirectory(DirectoryInfo newDir)
        {
            dir = newDir;
        }
    }
}