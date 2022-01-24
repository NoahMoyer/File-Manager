using System;
using System.IO;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using File_Manager.FileManagerScripts;
using File_Manager.Scripts;
using System.Collections.Generic;
using System.Diagnostics;

namespace File_Manager.Views
{
    public partial class AboutPage : ContentPage
    {
        FileManager fileManager = new FileManager();
        public AboutPage()
        {
            InitializeComponent();
            
            initializeDisplay();


        }

        public void initializeDisplay()
        {
            directoryDisplay.Text = fileManager.getCurrentDirectory().FullName; //get current directory
            //get files
            FileInfo[] files = fileManager.getFiles();
            //get directories
            DirectoryInfo[] directories = fileManager.getDirectories();
            //sorts directories in alphabetic order by name
            Array.Sort(directories, new DirectoryComparer());


            //display directories
            foreach (DirectoryInfo dir in directories)
            {
                Button button = new Button
                {
                    Text = dir.Name
                };
                Display.Children.Add(button);
                //clicked action
                button.Clicked += (object sender, System.EventArgs e) =>
                {
                    Debug.WriteLine(dir.Name + " button clicked!");
                    fileManager.updateDirectory(dir); //update directory based on button
                    Display.Children.Clear();
                    initializeDisplay();
                };
            }
            //display files
            foreach (FileInfo file in files)
            {
                //fileDisplay.Text += file.ToString() + "\n";

                //newFileButton.Text = file.Name;
                //buttons.Add(newFileButton);

                Button button = new Button
                {
                    Text = file.Name
                };
                Display.Children.Add(button);
                //clicked action
                button.Clicked += (object sender, System.EventArgs e) =>
                {
                    Debug.WriteLine(file.Name + " button clicked!");
                };
            }
        }

        //code used with buttons and labels to learn file info
        //public void OnClick(object sender, EventArgs e)
        //{
        //    //rest display
        //    fileDisplay.Text = "";
        //    FileInfo[] files = file.getFiles();

        //    foreach (FileInfo file in files)
        //    {
        //        fileDisplay.Text += file.ToString() + "\n";
        //    }

        //}

        //public void DirectoryButtonClick(object sender, EventArgs e)
        //{
        //    //rest display
        //    fileDisplay.Text = "";
        //    DirectoryInfo[] directories = file.getDirectories();
        //    //sorts directories in alphabetic order by name
        //    Array.Sort(directories, new DirectoryComparer());

        //    int i = 0;
        //    foreach (DirectoryInfo dir in directories)
        //    {
        //        fileDisplay.Text +=  dir.Name + "\n";
        //        i++;
        //    }
        //}


    }
}