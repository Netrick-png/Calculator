namespace Calculator2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_Expression;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Button button1, button2, button3, button4, button5, button6, button7, button8, button9, button0;
        private System.Windows.Forms.Button buttonAdd, buttonSub, buttonMul, buttonDiv, buttonEquals, buttonClear;
        private System.Windows.Forms.Button buttonSqrt, buttonPower; 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_Expression = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_Result.Location = new System.Drawing.Point(12, 50);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(260, 29);
            this.textBox_Result.TabIndex = 3;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            
            this.label_Expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Expression.Location = new System.Drawing.Point(12, 90);
            this.label_Expression.Name = "label_Expression";
            this.label_Expression.Size = new System.Drawing.Size(260, 20);
            this.label_Expression.TabIndex = 4;
            this.label_Expression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            this.label_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_Author.Location = new System.Drawing.Point(12, 12);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(260, 20);
            this.label_Author.TabIndex = 2;
            this.label_Author.Text = "Межов Дмитрий ИСП(11)-23-2";
            this.label_Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.button1.Location = new System.Drawing.Point(12, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button2.Location = new System.Drawing.Point(68, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button3.Location = new System.Drawing.Point(124, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button4.Location = new System.Drawing.Point(12, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button5.Location = new System.Drawing.Point(68, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button6.Location = new System.Drawing.Point(124, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button7.Location = new System.Drawing.Point(12, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button8.Location = new System.Drawing.Point(68, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 12;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button9.Location = new System.Drawing.Point(124, 242);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.button0.Location = new System.Drawing.Point(68, 298);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            
            this.buttonAdd.Location = new System.Drawing.Point(180, 130);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "+";
            this.buttonAdd.Click += new System.EventHandler(this.buttonOperator_Click);
            
            this.buttonSub.Location = new System.Drawing.Point(180, 186);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(50, 50);
            this.buttonSub.TabIndex = 16;
            this.buttonSub.Text = "-";
            this.buttonSub.Click += new System.EventHandler(this.buttonOperator_Click);
             
            this.buttonMul.Location = new System.Drawing.Point(180, 242);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(50, 50);
            this.buttonMul.TabIndex = 17;
            this.buttonMul.Text = "*";
            this.buttonMul.Click += new System.EventHandler(this.buttonOperator_Click);
            
            this.buttonDiv.Location = new System.Drawing.Point(180, 298);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(50, 50);
            this.buttonDiv.TabIndex = 18;
            this.buttonDiv.Text = "/";
            this.buttonDiv.Click += new System.EventHandler(this.buttonOperator_Click);
            
            this.buttonEquals.Location = new System.Drawing.Point(124, 298);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(50, 50);
            this.buttonEquals.TabIndex = 19;
            this.buttonEquals.Text = "=";
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            
            this.buttonClear.Location = new System.Drawing.Point(12, 298);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 50);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "C";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            
            this.buttonSqrt.Location = new System.Drawing.Point(236, 130);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(50, 50);
            this.buttonSqrt.TabIndex = 1;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            
            this.buttonPower.Location = new System.Drawing.Point(236, 186);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(50, 50);
            this.buttonPower.TabIndex = 0;
            this.buttonPower.Text = "^";
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            
            this.ClientSize = new System.Drawing.Size(300, 361);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label_Expression);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonClear);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}