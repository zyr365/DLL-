using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DLL实例
{
    public partial class DLL实例窗体 : Form
    {
        public DLL实例窗体()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operation operate = new operation();
            int c;
            
             c = operate.getSum(199, 9);
            
            richTextBox1.Text = c.ToString();

        }
    }
}
