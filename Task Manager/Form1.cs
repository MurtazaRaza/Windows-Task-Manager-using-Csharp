using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Task_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateP()
        {
            listBox1.Items.Clear();
                foreach(Process p in Process.GetProcesses())
                {
                    listBox1.Items.Add(p.ProcessName + " - " +  p.Id);
                }
        }

        public void KillP()
        { 
            foreach(Process P in Process.GetProcesses())
            {
                string[] arr = listBox1.SelectedItem.ToString().Split('-');
                string sProcess = arr[0].Trim();
                int iId = Convert.ToInt32(arr[1].Trim());
                if(P.ProcessName == sProcess && P.Id == iId)
                {
                    P.Kill();
                    MessageBox.Show("Process Killed", "Task Manager");
                    
                    
                }
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KillP();
        }
        
    }
}
