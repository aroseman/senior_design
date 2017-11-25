namespace Test
{
    partial class Configure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.configurationText = new System.Windows.Forms.TextBox();
            this.configurationSet = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1894, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1882, 57);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // configurationText
            // 
            this.configurationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationText.Location = new System.Drawing.Point(562, 361);
            this.configurationText.MaxLength = 10;
            this.configurationText.Name = "configurationText";
            this.configurationText.Size = new System.Drawing.Size(150, 44);
            this.configurationText.TabIndex = 7;
            // 
            // configurationSet
            // 
            this.configurationSet.Location = new System.Drawing.Point(739, 361);
            this.configurationSet.Name = "configurationSet";
            this.configurationSet.Size = new System.Drawing.Size(94, 50);
            this.configurationSet.TabIndex = 8;
            this.configurationSet.Text = "SET";
            this.configurationSet.UseVisualStyleBackColor = true;
            this.configurationSet.Click += new System.EventHandler(this.configurationSet_Click);
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.configurationSet);
            this.Controls.Add(this.configurationText);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Configure";
            this.Text = "Configure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Configure_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComboBox()
        {
            this.architectureList = new System.Windows.Forms.ComboBox();
            string[] architectures = new string[]{
                                                    "Ring",
                                                    "Linear",
                                                    "Mesh",
                                                    "Star"
                                                 };
            architectureList.Items.AddRange(architectures);
            this.architectureList.Location = new System.Drawing.Point(136, 100);
            this.architectureList.IntegralHeight = false;
            this.architectureList.MaxDropDownItems = 50;
            this.architectureList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.architectureList.Name = "architectureList";
            this.architectureList.Size = new System.Drawing.Size(300, 50);
            this.architectureList.TabIndex = 0;
            this.Controls.Add(this.architectureList);

            this.architectureList.SelectedIndexChanged += new System.EventHandler(architectureList_SelectedIndexChanged);
        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox configurationText;
        private System.Windows.Forms.Button configurationSet;
        private System.Windows.Forms.ComboBox architectureList;
    }
}