namespace OOFundraising
{
    partial class Form1
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
            label1 = new Label();
            donationCount = new NumericUpDown();
            btnGo = new Button();
            ((System.ComponentModel.ISupportInitialize)donationCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 181);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 0;
            label1.Text = "How many donations to process? ";
            // 
            // donationCount
            // 
            donationCount.Location = new Point(468, 179);
            donationCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            donationCount.Name = "donationCount";
            donationCount.Size = new Size(56, 27);
            donationCount.TabIndex = 1;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(332, 218);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(94, 29);
            btnGo.TabIndex = 2;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGo);
            Controls.Add(donationCount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)donationCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown donationCount;
        private Button btnGo;
    }
}