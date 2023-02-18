namespace _04_linq
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
            this.numberList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.topNumeric = new System.Windows.Forms.NumericUpDown();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(772, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "LINQ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number list:";
            // 
            // numberList
            // 
            this.numberList.FormattingEnabled = true;
            this.numberList.ItemHeight = 32;
            this.numberList.Location = new System.Drawing.Point(26, 167);
            this.numberList.Name = "numberList";
            this.numberList.Size = new System.Drawing.Size(787, 644);
            this.numberList.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show even numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FilterEvenClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operations:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(902, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(363, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Show two-digits numbers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.FilterTwoDigitsClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show negatives";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FilterNegativeClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1104, 765);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(299, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ResetClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(902, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 188);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorting";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(202, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(299, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "Sort by abs ascending";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OrderByAbsAscClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(377, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(299, 46);
            this.button6.TabIndex = 4;
            this.button6.Text = "Sort by descending";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OrderByDescClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(299, 46);
            this.button7.TabIndex = 3;
            this.button7.Text = "Sort by ascending";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OrderByAscClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(902, 599);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(299, 46);
            this.button8.TabIndex = 6;
            this.button8.Text = "Count of negative";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.CountEvenClick);
            // 
            // topNumeric
            // 
            this.topNumeric.Location = new System.Drawing.Point(1295, 604);
            this.topNumeric.Name = "topNumeric";
            this.topNumeric.Size = new System.Drawing.Size(211, 39);
            this.topNumeric.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1529, 599);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 46);
            this.button9.TabIndex = 8;
            this.button9.Text = "TOP";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.TopClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(902, 682);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(299, 46);
            this.button10.TabIndex = 9;
            this.button10.Text = "Group by last digit";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.GroupByClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1295, 682);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(323, 46);
            this.button11.TabIndex = 10;
            this.button11.Text = "Get first element";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.FirstClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 843);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.topNumeric);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox numberList;
        private Button button1;
        private Label label3;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button4;
        private GroupBox groupBox2;
        private Button button6;
        private Button button7;
        private Button button5;
        private Button button8;
        private NumericUpDown topNumeric;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}