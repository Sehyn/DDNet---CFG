namespace DDNet___CFG
{
    partial class Installer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_modifypath = new Button();
            lblgithub = new Label();
            lblpath = new Label();
            lbldefaultpath = new Label();
            groupBox1 = new GroupBox();
            btn_validatepath = new Button();
            btn_configurator = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_modifypath
            // 
            btn_modifypath.Location = new Point(116, 60);
            btn_modifypath.Name = "btn_modifypath";
            btn_modifypath.Size = new Size(193, 23);
            btn_modifypath.TabIndex = 1;
            btn_modifypath.Text = "Modify DDNet path";
            btn_modifypath.UseVisualStyleBackColor = true;
            btn_modifypath.Click += btn_modifypath_Click;
            // 
            // lblgithub
            // 
            lblgithub.AutoSize = true;
            lblgithub.Location = new Point(12, 158);
            lblgithub.Name = "lblgithub";
            lblgithub.Size = new Size(106, 15);
            lblgithub.TabIndex = 2;
            lblgithub.Text = "github.com/Sehyn";
            // 
            // lblpath
            // 
            lblpath.AutoSize = true;
            lblpath.Location = new Point(2, 32);
            lblpath.Name = "lblpath";
            lblpath.Size = new Size(34, 15);
            lblpath.TabIndex = 3;
            lblpath.Text = "Path:";
            // 
            // lbldefaultpath
            // 
            lbldefaultpath.AutoSize = true;
            lbldefaultpath.Location = new Point(34, 32);
            lbldefaultpath.Name = "lbldefaultpath";
            lbldefaultpath.Size = new Size(79, 15);
            lbldefaultpath.TabIndex = 4;
            lbldefaultpath.Text = "$default_path";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_configurator);
            groupBox1.Controls.Add(lblpath);
            groupBox1.Controls.Add(lbldefaultpath);
            groupBox1.Controls.Add(btn_validatepath);
            groupBox1.Controls.Add(btn_modifypath);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 143);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Config Installer:";
            // 
            // btn_validatepath
            // 
            btn_validatepath.Location = new Point(116, 88);
            btn_validatepath.Name = "btn_validatepath";
            btn_validatepath.Size = new Size(193, 23);
            btn_validatepath.TabIndex = 2;
            btn_validatepath.Text = "Install to current path";
            btn_validatepath.UseVisualStyleBackColor = true;
            btn_validatepath.Click += btn_validatepath_Click;
            // 
            // btn_configurator
            // 
            btn_configurator.Location = new Point(116, 114);
            btn_configurator.Name = "btn_configurator";
            btn_configurator.Size = new Size(193, 23);
            btn_configurator.TabIndex = 5;
            btn_configurator.Text = "Go to configurator";
            btn_configurator.UseVisualStyleBackColor = true;
            btn_configurator.Click += btn_configurator_Click;
            // 
            // Installer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 180);
            Controls.Add(lblgithub);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Installer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DDNet - CFG | Installer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_modifypath;
        private Label lblgithub;
        private Label lblpath;
        private Label lbldefaultpath;
        private GroupBox groupBox1;
        private Button btn_validatepath;
        private Button btn_configurator;
    }
}
