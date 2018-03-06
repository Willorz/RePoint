using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RePoint
{
    public partial class Form1 : Form
    {

        public static string readpath, savepath;
        public static double ratio;
        public static int move_x, move_y;



        public Form1()
        {
            InitializeComponent();
        }

        private void trans_btn_Click(object sender, EventArgs e)
        {
            readpath = readpath_tb.Text;
            savepath = savepath_tb.Text;
            ratio = double.Parse(ratio_tb.Text);

            move_x = Int32.Parse(move_x_tb.Text);
            move_y = Int32.Parse(move_y_tb.Text);

            string text = ReadTxt(readpath);

            MessageBox.Show("转换完成"); 
        
            Console.Read();

        }


        public static void WriteTxt(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(text);
            }
        }

        private static string ReadTxt(string path)
        {

            
             int i = 2;
            StringBuilder text = new StringBuilder();
            string temp = string.Empty;
            DirectoryInfo folder = new DirectoryInfo(path);
            FileInfo[] files = folder.GetFiles("*.txt", SearchOption.AllDirectories);
            foreach (FileInfo file in files)
            {

                using (StreamReader sr = file.OpenText())
                {
                    while (sr.Peek() > 0)
                    {


                        if (i % 2 == 0)
                        {
                            temp = sr.ReadLine();
                            temp = Math.Floor(Int32.Parse(temp) * ratio+move_x) + "";
                            text.AppendLine(temp);
                            i++;
                        }
                        else
                        {
                            temp = sr.ReadLine();
                            temp = Math.Floor(Int32.Parse(temp) * ratio+move_y) + "";
                            text.AppendLine(temp);
                            i++;
                        }

                       
                    }
                }

                StreamWriter strmsave = new StreamWriter(savepath+"/"+file.Name, false, System.Text.Encoding.Default);
                strmsave.Write(text);
                strmsave.Close();

                text.Clear();
            }

            return text.ToString();
        }

      
    }
}
