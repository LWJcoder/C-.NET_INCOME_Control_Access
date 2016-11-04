namespace INCOME
{
    partial class income
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
            this.label1 = new System.Windows.Forms.Label();
            this.INCOME_NUM = new System.Windows.Forms.TextBox();
            this.INCOME_R = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OUTCOME_R = new System.Windows.Forms.TextBox();
            this.OUTCOME_NUM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收入 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // INCOME_NUM
            // 
            this.INCOME_NUM.Location = new System.Drawing.Point(99, 21);
            this.INCOME_NUM.Name = "INCOME_NUM";
            this.INCOME_NUM.Size = new System.Drawing.Size(100, 21);
            this.INCOME_NUM.TabIndex = 1;
            this.INCOME_NUM.TextChanged += new System.EventHandler(this.INCOME_NUM_TextChanged);
            // 
            // INCOME_R
            // 
            this.INCOME_R.Location = new System.Drawing.Point(99, 68);
            this.INCOME_R.Name = "INCOME_R";
            this.INCOME_R.Size = new System.Drawing.Size(100, 21);
            this.INCOME_R.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "事项";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "支出(数字)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OUTCOME_R
            // 
            this.OUTCOME_R.Location = new System.Drawing.Point(99, 154);
            this.OUTCOME_R.Name = "OUTCOME_R";
            this.OUTCOME_R.Size = new System.Drawing.Size(100, 21);
            this.OUTCOME_R.TabIndex = 6;
            // 
            // OUTCOME_NUM
            // 
            this.OUTCOME_NUM.Location = new System.Drawing.Point(99, 115);
            this.OUTCOME_NUM.Name = "OUTCOME_NUM";
            this.OUTCOME_NUM.Size = new System.Drawing.Size(100, 21);
            this.OUTCOME_NUM.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "收入(数字)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "事项";
            // 
            // income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OUTCOME_NUM);
            this.Controls.Add(this.OUTCOME_R);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.INCOME_R);
            this.Controls.Add(this.INCOME_NUM);
            this.Controls.Add(this.label1);
            this.Name = "income";
            this.Text = "income";
            this.Load += new System.EventHandler(this.income_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INCOME_NUM;
        private System.Windows.Forms.TextBox INCOME_R;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OUTCOME_R;
        private System.Windows.Forms.TextBox OUTCOME_NUM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}