using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculytorNetForm
{
    public partial class Form1 : Form
    {
        public int countpanel { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 510;
            this.Width = 335;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
            this.Text = palHistoryMemory.Width.ToString();
            if (this.Width < 335)  this.Width = 335;
             
              // изменеие по Height
            if (this.Height >= 510)
            {
                panel3.Height = (this.Height * 20) / 100;
            }
            
            if (this.Height < 510) this.Height = 510;

            if (this.Width >= 575)
            { 
                palHistoryMemory.Visible = true;
                if (palHistoryMemory.Width >= 325)
                { 
                    palHistoryMemory.Width = 325;
                    return;
                }
                palHistoryMemory.Width = (this.Width * 42) / 100;
            } 
            else palHistoryMemory.Visible = false;
            


        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
        }
    }
}
