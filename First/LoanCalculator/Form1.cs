namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tbloanAmount = new TextBox();
            tbMonthlyInterest = new TextBox();
            tbMonthlyPayment = new TextBox();
            tbMonthcount = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            this.dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbloanAmount
            // 
            tbloanAmount.Location = new Point(100, 30);
            tbloanAmount.Name = "tbloanAmount";
            tbloanAmount.Size = new Size(316, 23);
            tbloanAmount.TabIndex = 0;
            tbloanAmount.Text = "10000000";
            // 
            // tbMonthlyInterest
            // 
            tbMonthlyInterest.Location = new Point(94, 89);
            tbMonthlyInterest.Name = "tbMonthlyInterest";
            tbMonthlyInterest.Size = new Size(328, 23);
            tbMonthlyInterest.TabIndex = 1;
            tbMonthlyInterest.Text = "1";
            // 
            // tbMonthlyPayment
            // 
            tbMonthlyPayment.Location = new Point(95, 150);
            tbMonthlyPayment.Name = "tbMonthlyPayment";
            tbMonthlyPayment.Size = new Size(329, 23);
            tbMonthlyPayment.TabIndex = 2;
            tbMonthlyPayment.Text = "20000";
            // 
            // tbMonthcount
            // 
            tbMonthcount.BackColor = Color.Yellow;
            tbMonthcount.Location = new Point(622, 49);
            tbMonthcount.Name = "tbMonthcount";
            tbMonthcount.Size = new Size(333, 23);
            tbMonthcount.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(509, 49);
            button1.Name = "button1";
            button1.Size = new Size(61, 31);
            button1.TabIndex = 4;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 5;
            label1.Text = "Loan amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 132);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Monthly payment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 65);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 7;
            label3.Text = "Monthly interest";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new Point(666, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new Size(155, 77);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            ClientSize = new Size(1291, 261);
            Controls.Add(this.dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(tbMonthcount);
            Controls.Add(tbMonthlyPayment);
            Controls.Add(tbMonthlyInterest);
            Controls.Add(tbloanAmount);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}