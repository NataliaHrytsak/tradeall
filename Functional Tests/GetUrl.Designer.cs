namespace UnitTestProject2
{
    partial class GetUrl
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
            this.components = new System.ComponentModel.Container();
            this.Links = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.get = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Links
            // 
            this.Links.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Links.FormattingEnabled = true;
            this.Links.Location = new System.Drawing.Point(12, 65);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(535, 329);
            this.Links.TabIndex = 0;
            this.Links.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // get
            // 
            this.get.BackColor = System.Drawing.Color.Teal;
            this.get.Location = new System.Drawing.Point(558, 12);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(61, 34);
            this.get.TabIndex = 2;
            this.get.Text = "Get";
            this.get.UseVisualStyleBackColor = false;
            this.get.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(12, 402);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(535, 36);
            this.progressBar1.TabIndex = 3;
            // 
            // GetUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.get);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Links);
            this.Name = "GetUrl";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GetUrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Links;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}