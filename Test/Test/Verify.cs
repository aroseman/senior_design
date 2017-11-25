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
    public partial class Verify : Form
    {
        public Verify()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void OnSubmenuClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Overview frm = new Overview();

            this.Hide();
            frm.Show();
        }

        private void Verify_Load(object sender, EventArgs e)
        {
            MyConfiguration.architecture = Overview.MyConfiguration.architecture;
            architectureText.Text = MyConfiguration.architecture;


            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(65, 172, 65));
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 52, 1980, 50));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        public static class MyConfiguration
        {
            public static string architecture { get; set; }
        }
    }
}
