using System;
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
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            SongsAss();
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
            if (TakeNum.Value != 0 || PutNum.Value != 0)
            {
                foreach (BankAccount account in accounts)
                {
                    if (account.GetNumber().ToString() == comboNumbers.SelectedItem.ToString())
                    {
                        if (PutNum.Value != 0)
                        {
                            account.PutMoney((int)PutNum.Value);
                        }
                        if (TakeNum.Value != 0)
                        {
                            bool successul = account.TryTakeMoney((int)TakeNum.Value);
                            if (!successul)
                                MessageBox.Show("Недостаточно средств", "Невозможно");
                            DrawBankAccount();
                            return;
                        }
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            foreach (BankAccount account in accounts)
            {
                if (account.GetNumber().ToString() == comboTransaction.SelectedItem.ToString())
                {
                    account.Dispose(filename);
                    return;
                }
            }
        }

        private void SongsAss()
        {
            songs = new Song[6];
            string[] names = new string[6] { "Oxxxymiron", "Колос", "Markul", "Винтаж", "Денис Майданов", "Три дня дождя" };
            string[] values = new string[6] { "Колесо", "Бiблiотека", "10,000 Ночей", "Знак Водолея", "Пролетая над нами", "Весна" };
            songs[0] = new Song();
            songs[0].setName(values[0]);
            songs[0].setAuthor(names[0]);
            richSongs.Text = $"{songs[0].Title()}\n";
            for (int songId = 1; songId < songs.Length; songId++)
            {
                songs[songId] = new Song();
                songs[songId].setName(values[songId]);
                songs[songId].setAuthor(names[songId]);
                songs[songId].setPrev(songs[songId - 1]);
                richSongs.Text += $"{songs[songId].Title()}\n";
            }
            songs[0].setPrev(songs[songs.Length - 1]);

            richTextBox2.Text = $"{songs[0].Title()} == {songs[1].Title()} ? : {songs[0].Equals(songs[1])}";

        }
    }
}
