using System;
using System.IO;
using System.Windows.Forms;
using consoleAppTest;


namespace VTT2SRT_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        

    }

        static class GlobalVariables
        {
            public static string SelectedPath { get; set; } //As a property
           // private static string SomeOtherVariable; //As a field
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //folderBrowser.ShowDialog();
            //if (folderBrowser.ShowDialog() == DialogResult.Cancel)
            //{
            //    MessageBox.Show("you have to select a Folder");
            //}

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                GlobalVariables.SelectedPath = folderBrowser.SelectedPath;
                path_lbl.Text = GlobalVariables.SelectedPath;
                MessageBox.Show(GlobalVariables.SelectedPath);
            }
            
            
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (GlobalVariables.SelectedPath !=null)
            {
                foreach (var VARIABLE in Directory.GetFiles(GlobalVariables.SelectedPath,"*.vtt",subFolder_cbx.Checked?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly))
                {
                    VttConverter.ConvertToSrt(VARIABLE,
                        Path.GetDirectoryName(VARIABLE) + @"\" + Path.GetFileNameWithoutExtension(VARIABLE) + ".srt");
                    textBox1.Text += VARIABLE+"\r\n";
                }
            }
            else
            {

                MessageBox.Show("you have to select a Folder");
            }
        }
    }
}
