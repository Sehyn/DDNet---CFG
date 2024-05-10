namespace DDNet___CFG
{
    partial class Configurator
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
            lblpath = new Label();
            lbldefaultpath = new Label();
            groupBox1 = new GroupBox();
            cb_dummyspawn = new ComboBox();
            lbldummyspawn = new Label();
            cb_triplefly = new ComboBox();
            lbltriplefly = new Label();
            cb_pseudofly = new ComboBox();
            lblpseudofly = new Label();
            cb_deepfly = new ComboBox();
            lbldeepfly = new Label();
            btn_help = new Button();
            btn_credits = new Button();
            btn_supportme = new Button();
            lblversion = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblpath
            // 
            lblpath.AutoSize = true;
            lblpath.Location = new Point(11, 9);
            lblpath.Name = "lblpath";
            lblpath.Size = new Size(34, 15);
            lblpath.TabIndex = 5;
            lblpath.Text = "Path:";
            // 
            // lbldefaultpath
            // 
            lbldefaultpath.AutoSize = true;
            lbldefaultpath.Location = new Point(43, 9);
            lbldefaultpath.Name = "lbldefaultpath";
            lbldefaultpath.Size = new Size(79, 15);
            lbldefaultpath.TabIndex = 6;
            lbldefaultpath.Text = "$default_path";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_dummyspawn);
            groupBox1.Controls.Add(lbldummyspawn);
            groupBox1.Controls.Add(cb_triplefly);
            groupBox1.Controls.Add(lbltriplefly);
            groupBox1.Controls.Add(cb_pseudofly);
            groupBox1.Controls.Add(lblpseudofly);
            groupBox1.Controls.Add(cb_deepfly);
            groupBox1.Controls.Add(lbldeepfly);
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 112);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurator:";
            // 
            // cb_dummyspawn
            // 
            cb_dummyspawn.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_dummyspawn.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            cb_dummyspawn.Location = new Point(387, 54);
            cb_dummyspawn.Name = "cb_dummyspawn";
            cb_dummyspawn.Size = new Size(121, 23);
            cb_dummyspawn.TabIndex = 7;
            // 
            // lbldummyspawn
            // 
            lbldummyspawn.AutoSize = true;
            lbldummyspawn.Location = new Point(387, 36);
            lbldummyspawn.Name = "lbldummyspawn";
            lbldummyspawn.Size = new Size(143, 15);
            lbldummyspawn.TabIndex = 6;
            lbldummyspawn.Text = "DummySpawn [ON/OFF]:";
            // 
            // cb_triplefly
            // 
            cb_triplefly.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_triplefly.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            cb_triplefly.Location = new Point(260, 54);
            cb_triplefly.Name = "cb_triplefly";
            cb_triplefly.Size = new Size(121, 23);
            cb_triplefly.TabIndex = 5;
            // 
            // lbltriplefly
            // 
            lbltriplefly.AutoSize = true;
            lbltriplefly.Location = new Point(260, 36);
            lbltriplefly.Name = "lbltriplefly";
            lbltriplefly.Size = new Size(108, 15);
            lbltriplefly.TabIndex = 4;
            lbltriplefly.Text = "TripleFly [ON/OFF]:";
            // 
            // cb_pseudofly
            // 
            cb_pseudofly.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pseudofly.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            cb_pseudofly.Location = new Point(133, 54);
            cb_pseudofly.Name = "cb_pseudofly";
            cb_pseudofly.Size = new Size(121, 23);
            cb_pseudofly.TabIndex = 3;
            // 
            // lblpseudofly
            // 
            lblpseudofly.AutoSize = true;
            lblpseudofly.Location = new Point(133, 36);
            lblpseudofly.Name = "lblpseudofly";
            lblpseudofly.Size = new Size(119, 15);
            lblpseudofly.TabIndex = 2;
            lblpseudofly.Text = "PseudoFly [ON/OFF]:";
            // 
            // cb_deepfly
            // 
            cb_deepfly.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_deepfly.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            cb_deepfly.Location = new Point(6, 54);
            cb_deepfly.Name = "cb_deepfly";
            cb_deepfly.Size = new Size(121, 23);
            cb_deepfly.TabIndex = 1;
            cb_deepfly.SelectedIndexChanged += cb_deepfly_SelectedIndexChanged_1;
            // 
            // lbldeepfly
            // 
            lbldeepfly.AutoSize = true;
            lbldeepfly.Location = new Point(6, 36);
            lbldeepfly.Name = "lbldeepfly";
            lbldeepfly.Size = new Size(107, 15);
            lbldeepfly.TabIndex = 0;
            lbldeepfly.Text = "DeepFly [ON/OFF]:";
            // 
            // btn_help
            // 
            btn_help.Location = new Point(472, 9);
            btn_help.Name = "btn_help";
            btn_help.Size = new Size(111, 23);
            btn_help.TabIndex = 8;
            btn_help.Text = "Help";
            btn_help.UseVisualStyleBackColor = true;
            btn_help.Click += btn_help_Click;
            // 
            // btn_credits
            // 
            btn_credits.Location = new Point(472, 67);
            btn_credits.Name = "btn_credits";
            btn_credits.Size = new Size(111, 23);
            btn_credits.TabIndex = 9;
            btn_credits.Text = "Credits";
            btn_credits.UseVisualStyleBackColor = true;
            btn_credits.Click += btn_credits_Click;
            // 
            // btn_supportme
            // 
            btn_supportme.Location = new Point(472, 38);
            btn_supportme.Name = "btn_supportme";
            btn_supportme.Size = new Size(111, 23);
            btn_supportme.TabIndex = 10;
            btn_supportme.Text = "Support me";
            btn_supportme.UseVisualStyleBackColor = true;
            btn_supportme.Click += btn_supportme_Click;
            // 
            // lblversion
            // 
            lblversion.AutoSize = true;
            lblversion.Location = new Point(9, 209);
            lblversion.Name = "lblversion";
            lblversion.Size = new Size(36, 15);
            lblversion.TabIndex = 11;
            lblversion.Text = "[v1.0]";
            // 
            // Configurator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 233);
            Controls.Add(lblversion);
            Controls.Add(btn_supportme);
            Controls.Add(btn_credits);
            Controls.Add(btn_help);
            Controls.Add(groupBox1);
            Controls.Add(lblpath);
            Controls.Add(lbldefaultpath);
            Name = "Configurator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DDNet - CFG | Configurator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblpath;
        private Label lbldefaultpath;
        private GroupBox groupBox1;
        private Button btn_help;
        private Button btn_credits;
        private Button btn_supportme;
        private ComboBox cb_deepfly;
        private Label lbldeepfly;
        private Label lblversion;
        private ComboBox cb_dummyspawn;
        private Label lbldummyspawn;
        private ComboBox cb_triplefly;
        private Label lbltriplefly;
        private ComboBox cb_pseudofly;
        private Label lblpseudofly;
    }
}