namespace ClientApplicationConsole
{
    partial class HomeWindowsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mosson = new System.Windows.Forms.Button();
            this.odysseum = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mosson);
            this.groupBox1.Controls.Add(this.odysseum);
            this.groupBox1.Location = new System.Drawing.Point(71, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1441, 256);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mosson
            // 
            this.mosson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mosson.Location = new System.Drawing.Point(31, 137);
            this.mosson.Name = "mosson";
            this.mosson.Size = new System.Drawing.Size(593, 47);
            this.mosson.TabIndex = 3;
            this.mosson.Text = "Agency Mosson";
            this.mosson.UseVisualStyleBackColor = true;
            this.mosson.Click += new System.EventHandler(this.mosson_Click);
            // 
            // odysseum
            // 
            this.odysseum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.odysseum.Location = new System.Drawing.Point(773, 134);
            this.odysseum.Name = "odysseum";
            this.odysseum.Size = new System.Drawing.Size(616, 50);
            this.odysseum.TabIndex = 4;
            this.odysseum.Text = "Agency Odysseum";
            this.odysseum.UseVisualStyleBackColor = true;
            this.odysseum.Click += new System.EventHandler(this.odysseum_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.title.Location = new System.Drawing.Point(570, 117);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(307, 36);
            this.title.TabIndex = 2;
            this.title.Text = "Hotel Booking System";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(523, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose An Agency";
            // 
            // HomeWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 714);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Name = "HomeWindowsForm";
            this.Text = "HomeWindowsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mosson;
        private System.Windows.Forms.Button odysseum;
        private System.Windows.Forms.Label title;
    }
}