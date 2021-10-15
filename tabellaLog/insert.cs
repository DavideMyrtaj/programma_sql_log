using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tabellaLog
{
    public partial class insert : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        Account account;
        public insert(SqlConnection conAperta,Account persona)
        {
            account = persona;
            conn = conAperta;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(textBox2.Text);
                double.Parse(textBox3.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show($"valori non validi:\n{err.Message}");
                return;
               
            }
            string query = $"Insert into TabellaProdotti(Prodotto,Quantità,Prezzo) VALUES('{textBox1.Text}','{int.Parse(textBox2.Text)}','{double.Parse(textBox3.Text.Replace('.',',')).ToString().Replace(',','.')}')";
            cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserimento del prodotto riuscito");
                cmd.Dispose();
                InserimentoDb();

            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
                cmd.Dispose();

            }
            
            
        }
        void InserimentoDb()
        {
            Random r = new Random();

            string query = $"INSERT INTO LogTable (Utente,Ora,Azione,Valore) VALUES('{account.Username}','{DateTime.Now}','inserimento prodotto','{r.Next(1,1000)}');";
            cmd = new SqlCommand(query, conn);

            try
            {
                
                cmd.ExecuteNonQuery();


            }
            catch (SqlException error)
            {
                MessageBox.Show($"errore durante l'aggiunta nella tabella log:\n{error.Message}");

            }
            cmd.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
