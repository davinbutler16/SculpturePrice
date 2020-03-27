using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SculpturePrice
{
    public partial class Program : Form
    {
        private TextBox Copper;
        private Label label1;
        private Label stone;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Gas;
        private Label rate;
        private Label hours;
        private Label label2;
        private Label label3;
        private Label totalPrice;
        private Label messageText;
        private Button button_1;

        public Program()
        {
            InitializeComponent();
        }

        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());



        }

        private void InitializeComponent()
        {
            this.button_1 = new System.Windows.Forms.Button();
            this.Copper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Gas = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(364, 232);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(68, 23);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "Calculate";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Copper
            // 
            this.Copper.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Copper.Location = new System.Drawing.Point(364, 12);
            this.Copper.Name = "Copper";
            this.Copper.Size = new System.Drawing.Size(68, 20);
            this.Copper.TabIndex = 1;
            this.Copper.TextChanged += new System.EventHandler(this.Copper_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight of copper in KG:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stone
            // 
            this.stone.AutoSize = true;
            this.stone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stone.Location = new System.Drawing.Point(79, 56);
            this.stone.Name = "stone";
            this.stone.Size = new System.Drawing.Size(160, 15);
            this.stone.TabIndex = 3;
            this.stone.Text = "Value of the stone base in €:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(364, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(364, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 7;
            // 
            // Gas
            // 
            this.Gas.AutoSize = true;
            this.Gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gas.Location = new System.Drawing.Point(79, 99);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(233, 15);
            this.Gas.TabIndex = 8;
            this.Gas.Text = "Hours of gas usage (i.e 1/2 of total hours):";
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(79, 185);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(211, 15);
            this.rate.TabIndex = 9;
            this.rate.Text = "Your hourly rate (€35 recommended):";
            this.rate.Click += new System.EventHandler(this.rate_Click);
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(79, 142);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(256, 15);
            this.hours.TabIndex = 10;
            this.hours.Text = "Amount of hours you worked on this sculpture:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "The price of this sculpture should be:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter the:";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(361, 281);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(0, 20);
            this.totalPrice.TabIndex = 13;
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageText.ForeColor = System.Drawing.Color.Red;
            this.messageText.Location = new System.Drawing.Point(79, 239);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(0, 15);
            this.messageText.TabIndex = 14;
            this.messageText.UseWaitCursor = true;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(494, 342);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.Gas);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Copper);
            this.Controls.Add(this.button_1);
            this.Name = "Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sculpture Pricing";
            this.Load += new System.EventHandler(this.Program_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string copperPrice = Copper.Text.Trim().ToString();
            string stonePrice = textBox1.Text.Trim().ToString();
            string gasPrice = textBox2.Text.Trim().ToString();
            string hours = textBox3.Text.Trim().ToString();
            string rate = textBox4.Text.Trim().ToString();


            if(!string.IsNullOrEmpty(copperPrice) && !string.IsNullOrEmpty(stonePrice) && !string.IsNullOrEmpty(gasPrice) && !string.IsNullOrEmpty(hours) && !string.IsNullOrEmpty(rate))
            {
                double doubleCopperPrice = 0;
                int intStonePrice = 0;
                double doubleGasPrice = 0;
                double doubleHours = 0;
                int intRate = 0;

                if (double.TryParse(copperPrice, out doubleCopperPrice) && int.TryParse(stonePrice, out intStonePrice) && double.TryParse(gasPrice, out doubleGasPrice) && double.TryParse(hours, out doubleHours) && int.TryParse(rate, out intRate))
                {
                    double Result = (doubleCopperPrice * 8) + intStonePrice + (doubleGasPrice * 8) + (doubleHours * intRate);
                    totalPrice.Text = Result.ToString("#,# euro");
                    messageText.Text = "";

                }
                else
                {
                    MessageBox.Show("Failed.", "Sculpture Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                messageText.Text = "Please Complete all fields";
            }


        }

        private void Copper_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rate_Click(object sender, EventArgs e)
        {

        }
    }
}
