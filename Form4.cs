using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class Form4 : Form
  {
    public Form4()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      if ((button2.Enabled == false) & (button3.Enabled == false))
      {
        button1.Enabled = false;
      }
      button2.Enabled = false;
        }

    private void button2_Click(object sender, EventArgs e)
    {
      if ((button1.Enabled == false) & (button3.Enabled == false))
      {
        button2.Enabled = false;
      }
      button3.Enabled = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if ((button1.Enabled == false)&(button2.Enabled == false))
      {
        button3.Enabled = false;
      }
      button1.Enabled = false;
    }


    private void button5_Click(object sender, EventArgs e)
    {
      button1.Enabled = true;
      button2.Enabled = true;
      button3.Enabled = true;
    }
  }
}
