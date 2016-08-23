namespace Singleton
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.worker1 = new System.ComponentModel.BackgroundWorker();
            this.worker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(101, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 213);
            this.textBox1.TabIndex = 1;
            // 
            // worker1
            // 
            this.worker1.WorkerReportsProgress = true;
            this.worker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker1_DoWork);
            this.worker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker1_ProgressChanged);
            // 
            // worker2
            // 
            this.worker2.WorkerReportsProgress = true;
            this.worker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker2_DoWork);
            this.worker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker2_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker worker1;
        private System.ComponentModel.BackgroundWorker worker2;
    }
}

