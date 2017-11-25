using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            var File = new ToolStripMenuItem();
            menuStrip1.Items.Add(File);
            File.Name = "File";
            File.Text = "File";
            var Exit = new ToolStripMenuItem();
            File.DropDownItems.Add(Exit);
            Exit.Name = "Exit";
            Exit.Text = "Exit";
            Exit.Click += OnSubmenuClick;
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Simulate frm = new Simulate();
            this.Hide();
            frm.Show();
        }

        private void OnSubmenuClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Verify form = new Verify();
            this.Hide();
            
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Configure form = new Configure();
            Configure.MyConfiguration.architecture = MyConfiguration.architecture;

            this.Hide();

            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Review form = new Review();

            this.Hide();
            form.Show();
        }

        public static class MyConfiguration
        {
            public static string architecture { get; set; }
        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }
    }
}
