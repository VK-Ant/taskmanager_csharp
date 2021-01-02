using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager3
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer _refreshTimer;
        private int _thisProcess;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAllProcesses();
            
        }

        public void ListAllProcesses()
        {
            
            Process[] AllProcess = Process.GetProcesses();
            foreach(Process p1 in AllProcess)
            {
                try
                {
                    dataGridView1.Rows.Add(p1.ProcessName, p1.Id, p1.MainWindowTitle.ToString(), p1.StartTime.ToLongTimeString(),p1.PagedMemorySize64.ToString(),p1.PrivilegedProcessorTime.Add(p1.TotalProcessorTime).ToString());
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process P=Process.GetProcessById(Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
            P.Kill();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListAllProcesses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter sw = new StreamWriter(@"C:\Users\VK\Desktop\vk.txt");
            int rowcount = dataGridView1.Rows.Count;
            for(int i=0;i<rowcount-1;i++)
            {
                sw.WriteLine(dataGridView1.Columns[i].Cells[0].Value.ToString() + "\t"
                + dataGridView1.Columns[i].Cells[1].Value.ToString() + "\t"
                + dataGridView1.Columns[i].Cells[2].Value.ToString() + "\t"
                + dataGridView1.Columns[i].Cells[3].Value.ToString() + "\t"
                + dataGridView1.Columns[i].Cells[4].Value.ToString() + "\t"
                + dataGridView1.Columns[i].Cells[5].Value.ToString() + "\t");


            }

            sw.Close();
            MessageBox.Show("successfully");
            

        }
    }
}
