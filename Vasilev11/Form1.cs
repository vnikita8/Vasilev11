using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vasilev11
{
    public partial class Form1 : Form
    {
        Song[] songs;
        BankAccount[] accounts;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttGen_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int count = (int)numericUpDown1.Value;
            accounts = new BankAccount[count];
            for (int acc = 0; acc < count; acc++)
            {
                accounts[acc] = new BankAccount((AccountType)random.Next(0, 2), random.Next(100, 400000));
                comboNumbers.Items.Add(accounts[acc].GetNumber());
                comboFrom.Items.Add(accounts[acc].GetNumber());
                comboTo.Items.Add(accounts[acc].GetNumber());
                comboTransaction.Items.Add(accounts[acc].GetNumber());
            }
            DrawBankAccount();
        }

        private void buttTransfer_Click(object sender, EventArgs e)
        {

        }

        private void DrawBankAccount()
        {
            richTextBox1.Clear();
            foreach (BankAccount account in accounts)
            {
                richTextBox1.Text += $"Аккаунт: {account.GetNumber()} - <<{account.GetType()}>>. Баланс: {account.GetBalance()} (руб.)\n\n";
            }
        }

        private void buttTakePut_Click(object sender, EventArgs e)
        {
            if (accounts == null)
                return;
            foreach (BankAccount account in accounts)
            {
                if (account.GetNumber().ToString() == comboNumbers.SelectedItem.ToString())
                {
                    account.PutMoney((int)PutNum.Value);
                    bool successul = account.TryTakeMoney((int)TakeNum.Value);
                    if (!successul)
                        MessageBox.Show("Недостаточно средств", "Невозможно");
                    DrawBankAccount();
                    return;
                }
            }
        }

        private void comboTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(BankAccount account in accounts)
            {
                if (account.GetNumber().ToString() == comboTransaction.SelectedItem.ToString())
                {
                    richTransactions.Text = "Транзакции: \n";
                    try
                    {
                        foreach (BankTransaction transaction in account.getTransactions())
                            richTransactions.AppendText($"(Тут типо дата, но по заданию нет) - {transaction.TransferMoney}\n");
                    }
                    catch(Exception)
                    {
                        richTransactions.Text += "Нет транзакций";
                    }
                }
            }
        }
    }
}
