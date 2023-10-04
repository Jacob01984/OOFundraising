namespace OOFundraising
{
    public partial class Form1 : Form
    {
        List<Donation> donations = new List<Donation>();
        List<TextBox> nameBoxes = new List<TextBox>();
        List<TextBox> amountBoxes = new List<TextBox>();
        List<Label> labels = new List<Label>();
        Button btnReport;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputTxtboxCount = (int)donationCount.Value;

            label1.Visible = false;
            donationCount.Visible = false;
            btnGo.Visible = false;

            for (int i = 0; i < inputTxtboxCount; i++)
            {
                Label label = new Label
                {
                    Location = new System.Drawing.Point(150, 200 + (30 * i)),
                    Size = new System.Drawing.Size(50, 25),
                    Text = i.ToString(),
                };
                this.Controls.Add(label);
                labels.Add(label);

                TextBox txtboxName = new TextBox
                {
                    Location = new System.Drawing.Point(200, 200 + (30 * i)),
                    Size = new System.Drawing.Size(100, 45),
                    PlaceholderText = "Enter Name...",
                    Name = "txtboxInputName" + i,
                };
                this.Controls.Add(txtboxName);
                nameBoxes.Add(txtboxName);

                TextBox txtboxAmount = new TextBox
                {
                    Location = new System.Drawing.Point(300, 200 + (30 * i)),
                    Size = new System.Drawing.Size(100, 45),
                    PlaceholderText = "Enter Amount...",
                    Name = "txtboxInputAmount" + i,
                };
                this.Controls.Add(txtboxAmount);
                amountBoxes.Add(txtboxAmount);
            }

            btnReport = new Button
            {
                Location = new System.Drawing.Point(250, 50),
                Size = new System.Drawing.Size(120, 35),
                Text = "Create Report",
                Name = "btnReport"
            };
            btnReport.Click += BtnReport_Click;
            this.Controls.Add(btnReport);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            double totalAmount = 0;
            double totalTransFee = 0;

            foreach (TextBox txtbox in nameBoxes) 
            {
                txtbox.Visible = false;
            }
            foreach (TextBox txtbox in amountBoxes)
            {
                txtbox.Visible = false;
            }
           foreach (Label lbl in labels)
            {
                lbl.Visible = false;
            }
           

            for (int i = 0; i < nameBoxes.Count; i++)
            {
                string name = nameBoxes[i].Text;
                if (double.TryParse(amountBoxes[i].Text, out double amount))
                {
                    Donation donation = new Donation
                    {
                        donorName = name,
                        amount = amount,
                    };
                    donations.Add(donation);

                    totalAmount += amount;
                    totalTransFee += donation.calculateTransFee();
                }
            }

            TextBox multilinetxtbox = new TextBox
            {
                Multiline = true,
                Location = new Point(10, 50),
                Size = new System.Drawing.Size(600, 200),
                ScrollBars = ScrollBars.Vertical,
            };
            this.Controls.Add(multilinetxtbox);

            string report = "Donor\t\tAmount\t\tTrans fee\t\tCategory\r\n";
            foreach (var donation in donations)
            {
                report += $"{donation.donorName}\t\t{donation.amount}\t\t{donation.calculateTransFee()}\t\t{donation.getCategory()}\r\n";
            }
            report += $"Totals\t\t{totalAmount}\t\t{totalTransFee}";
            multilinetxtbox.Text = report;

            btnReport.Visible = false;
        }
    }
}