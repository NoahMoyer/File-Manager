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
        DirectoryInfo currentDirectory = new DirectoryInfo(@"/storage/emulated/0/");
        List<DirectoryInfo> previousDirectories = new List<DirectoryInfo>();

        //variable for directory name
        //List<String> directories = new List<string>;


        //gets the files of the current directory
        public FileInfo[] getFiles()
        {
            return currentDirectory.GetFiles();
        }

        public DirectoryInfo[] getDirectories()
        {

            return currentDirectory.GetDirectories();
        }

        public DirectoryInfo getCurrentDirectory()
        {
            
            return currentDirectory;
        }
        public void updateDirectory(DirectoryInfo newDir)
        {
            previousDirectories.Add(currentDirectory);
            currentDirectory = newDir;
        }

        public void goToPreviousDirectory()
        {
            currentDirectory = previousDirectories.Last();
            previousDirectories.Remove(previousDirectories.Last());
        }

        public List<DirectoryInfo> getPreviousDirectoryList()
        {
            return previousDirectories;
        }

        public void goUpToParentDirectory()
        {
            previousDirectories.Add(currentDirectory);
            currentDirectory = currentDirectory.Parent;

        }
    }
}