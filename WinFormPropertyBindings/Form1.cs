using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPropertyBindings
{
    public partial class Form1 : Form
    {
        private Class1 _class1 = new Class1();

        public Form1()
        {
            InitializeComponent();

            Binding binding = new Binding("Text", textBox2, "Text", 
                true, DataSourceUpdateMode.OnPropertyChanged);


            textBox1.DataBindings.Add(binding);

            this.DataBindings.Add("Size", textBox3, "Text",
                true, DataSourceUpdateMode.OnPropertyChanged);

            textBox4.DataBindings.Add("Size", _class1 , "MyStr",
                true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _class1.MyStr = "Hey";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = _class1.MyStr;
        }
    }
}
