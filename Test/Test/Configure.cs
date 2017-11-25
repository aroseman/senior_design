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
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();
            InitializeComboBox();

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

        private void Configure_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;

        }

        private void OnSubmenuClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Overview frm = new Overview();
            Overview.MyConfiguration.architecture = MyConfiguration.architecture;

            this.Hide();
            frm.Show();
        }

        public static class MyConfiguration
        {
            public static string architecture { get; set; }
        }

        private void configurationSet_Click(object sender, EventArgs e)
        {
            
        }

        private void architectureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyConfiguration.architecture = architectureList.Text;
        }
    }
}
