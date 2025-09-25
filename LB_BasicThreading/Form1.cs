using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_BasicThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void BtnRUN_Click(object sender, EventArgs e)
        {
            lblThreadStatus.Text = "-Before starting thread-";
            Console.WriteLine(lblThreadStatus.Text);
            

            Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            ThreadA.Name = "Thread A";

            Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread1));
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            lblThreadStatus.Text = "-End of Thread-";
            Console.WriteLine(lblThreadStatus.Text);
            

        }
    }
}
