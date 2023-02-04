namespace ADO.NET_disconnected_mode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.depIdNumeric = new System.Windows.Forms.NumericUpDown();
            this.sponsorIdNumeric = new System.Windows.Forms.NumericUpDown();
            this.donateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depIdNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorIdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sponsor ID:";
            // 
            // amountNumeric
            // 
            this.amountNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNumeric.Location = new System.Drawing.Point(255, 173);
            this.amountNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.amountNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(347, 39);
            this.amountNumeric.TabIndex = 4;
            this.amountNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // depIdNumeric
            // 
            this.depIdNumeric.Location = new System.Drawing.Point(255, 254);
            this.depIdNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.depIdNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depIdNumeric.Name = "depIdNumeric";
            this.depIdNumeric.Size = new System.Drawing.Size(347, 39);
            this.depIdNumeric.TabIndex = 5;
            this.depIdNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sponsorIdNumeric
            // 
            this.sponsorIdNumeric.Location = new System.Drawing.Point(255, 348);
            this.sponsorIdNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.sponsorIdNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sponsorIdNumeric.Name = "sponsorIdNumeric";
            this.sponsorIdNumeric.Size = new System.Drawing.Size(347, 39);
            this.sponsorIdNumeric.TabIndex = 6;
            this.sponsorIdNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // donateBtn
            // 
            this.donateBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.donateBtn.ForeColor = System.Drawing.Color.White;
            this.donateBtn.Location = new System.Drawing.Point(180, 483);
            this.donateBtn.Name = "donateBtn";
            this.donateBtn.Size = new System.Drawing.Size(342, 54);
            this.donateBtn.TabIndex = 7;
            this.donateBtn.Text = "Make Donation";
            this.donateBtn.UseVisualStyleBackColor = false;
            this.donateBtn.Click += new System.EventHandler(this.donateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 622);
            this.Controls.Add(this.donateBtn);
            this.Controls.Add(this.sponsorIdNumeric);
            this.Controls.Add(this.depIdNumeric);
            this.Controls.Add(this.amountNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depIdNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorIdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown amountNumeric;
        private NumericUpDown depIdNumeric;
        private NumericUpDown sponsorIdNumeric;
        private Button donateBtn;
    }
}