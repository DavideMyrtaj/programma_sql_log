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
    public partial class Form1 : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-MVIRBBM;Initial Catalog=sium;Integrated Security=True");
        SqlCommand cmd;
        Account account;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"CREATE TABLE dbo.LogTable(ID int IDENTITY(1,1) NOT NULL,"+
                            "Utente nchar(100) NULL,Ora datetime NULL,Azione nchar(100) NULL,"+
                            "Valore nchar(50) NULL);";
            cmd = new SqlCommand(query, Conn);
            try
            {
                Conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("tabella di log creata con successo");
                
                button1.Enabled = false;
            }
            catch (SqlException errore)
            {

                MessageBox.Show($"si è verificato un errore: {errore.Message}");
            }
            Conn.Close();
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            if (button1.Enabled==true)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //verifica se esiste tabella
            string pino;
            string query = @"SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'LogTable';";
            cmd = new SqlCommand(query, Conn);
            Conn.Open();
            SqlDataReader reader=cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
                
            else
            {
                button1.Enabled = true;
            }
                
            Conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.Account WHERE Username='{textBox1.Text}' AND Password='{textBox2.Text}';";
            cmd = new SqlCommand(query, Conn);
            Conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {

                account = new Account();
                reader.Read();
                account.Username = reader["Username"].ToString();
                account.Password = reader["Password"].ToString();
                
                MessageBox.Show("accesso eseguito correttamente");
                button2.Enabled = false;
                button3.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                Conn.Close();
                InserimentoDB("LOG IN", "");
            }
            else
            {
                MessageBox.Show("credenziali non valide");
                Conn.Close();
            }
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InserimentoDB("LOG OUT", "");
            account = null;
            button3.Enabled = false;
            button2.Enabled = true;
            MessageBox.Show("log out eseguito correttamente");
        }

        private void button2_EnabledChanged(object sender, EventArgs e)
        {
            if (button2.Enabled==true)
            {
                azione1.Enabled = false;
                azione2.Enabled = false;
                azione3.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                azione1.Enabled = true;
                azione2.Enabled = true;
                azione3.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
        }

        private void azione1_Click(object sender, EventArgs e)
        {
            InserimentoDB("inserimento", "ciao");
            MessageBox.Show("valore aggiunto correttamente");
        }

        private void azione2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            InserimentoDB("Inserimento", r.Next(1, 2000).ToString());
            MessageBox.Show("valore aggiunto correttamente");
        }

        private void azione3_Click(object sender, EventArgs e)
        {
            InserimentoDB("inserimento", ":)");
            MessageBox.Show("valore aggiunto correttamente");
        }
        void InserimentoDB(string azione, string valore)
        {
            
            string query = $"INSERT INTO LogTable (Utente,Ora,Azione,Valore) VALUES('{account.Username}','{DateTime.Now}','{azione}','{valore}');";
            cmd = new SqlCommand(query, Conn);
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
    }
    public class Account
    {
        public string Username = "";
        public string Password = "";
    }
    
}
