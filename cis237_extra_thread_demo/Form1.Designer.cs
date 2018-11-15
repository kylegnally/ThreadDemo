namespace cis237_extra_thread_demo
{
    partial class ThreadForm
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.syncButton = new System.Windows.Forms.Button();
            this.asyncButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(69, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(130, 20);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Not Fetched Yet!";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(72, 44);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 1;
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(72, 85);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(100, 23);
            this.syncButton.TabIndex = 2;
            this.syncButton.Text = "Submit Sync";
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncButton_Click);
            // 
            // asyncButton
            // 
            this.asyncButton.Location = new System.Drawing.Point(72, 114);
            this.asyncButton.Name = "asyncButton";
            this.asyncButton.Size = new System.Drawing.Size(100, 23);
            this.asyncButton.TabIndex = 3;
            this.asyncButton.Text = "Submit Async";
            this.asyncButton.UseVisualStyleBackColor = true;
            this.asyncButton.Click += new System.EventHandler(this.asyncButton_Click);
            // 
            // ThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 192);
            this.Controls.Add(this.asyncButton);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputLabel);
            this.Name = "ThreadForm";
            this.Text = "Thread Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.Button asyncButton;
    }
}

