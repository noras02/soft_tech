namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal loanAmount = decimal.Parse(tbloanAmount.Text);
            decimal monthlyInterest = decimal.Parse(tbMonthlyInterest.Text);
            decimal monthlyPayment = decimal.Parse(tbMonthlyPayment.Text);

            decimal balance = loanAmount;
            decimal totalPaid = 0;
            int month = 1;
            List<Row> rows = new List<Row>();
            while (balance > 0)
            {
                balance += (monthlyInterest / 100m) * balance;
                balance -= monthlyPayment;
                totalPaid += monthlyPayment;
                month++;
                Row r = new();
                r.Balance = balance;
                r.Month = month;

                rows.Add(r);
                // if (1 == 1) { return; }
            }

            tbMonthcount.Text = month.ToString();
            dataGridView1.DataSource = rows; 
        }

        private TextBox tbloanAmount; //??
        private TextBox tbMonthlyInterest;
        private TextBox tbMonthlyPayment;
        private TextBox tbMonthcount;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3; //??
        private DataGridView dataGridView1;
    }
}