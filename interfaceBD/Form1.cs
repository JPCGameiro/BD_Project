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
using Eventos;

namespace interfaceBD
{
    public partial class Form1 : Form
    {
        private SqlConnection cn;
        private int currentEvent;

        public Form1()
        {
            InitializeComponent();
        }

        // event handler
        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            adicionar.Visible = false;
            Update.Visible = false;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadEventos();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                currentEvent = listBox1.SelectedIndex;
                ShowEvent();
            }
        }

        private void adicionarEvento_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT count(*) as entry from EM.EVENTO", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            adicionar.Visible = true;
            adicionarEvento.Visible = false;
            ClearFields();
            if (reader.Read()) {
                idEvento.Text = ((int)(reader["entry"]) + 1).ToString();
            }
            cn.Close();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            Evento E = new Evento();
            E.Id = idEvento.Text;
            E.Name = nomeEvento.Text;
            E.NumBilhetes = numbilhetes.Text;
            E.Numdias = numdias.Text;
            E.Dataini = datainicio.Text;
            // adicionar evento à bd
            SubmitEvento(E);
        }

        // db interation
        private void loadEventos()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM EM.EVENTO ORDER BY id", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                Evento E = new Evento();
                E.Id = reader["id"].ToString();
                E.Name = reader["nome"].ToString();
                E.Numdias = reader["numdias"].ToString();
                E.NumBilhetes = reader["numbilhetes"].ToString();
                E.Dataini = reader["dataini"].ToString().Split(' ')[0];
                E.Datafim = reader["datafim"].ToString();
                E.Cc_promotor = reader["cc_promotor"].ToString();
                E.DataProposta = reader["dataproposta"].ToString();
                E.Cc_stageManager = reader["cc_stageManager"].ToString();
                listBox1.Items.Add(E);
            }
            cn.Close();
        }


        private void SubmitEvento(Evento E)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT EM.EVENTO (id, nome, numdias, dataini, numbilhetes) VALUES (@ID, @Nome, @Numdias, @Dataini, @Numbilhetes)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", E.Id);
            cmd.Parameters.AddWithValue("@Nome", E.Name);
            cmd.Parameters.AddWithValue("@Numdias", E.Numdias);
            cmd.Parameters.AddWithValue("@Dataini", DateTime.Parse(E.Dataini));
            cmd.Parameters.AddWithValue("@Numbilhetes", E.NumBilhetes);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                MessageBox.Show("Event \""+ E.Name + "\" with succsess");
                cn.Close();
            }
        }

        public void UpdateEvent()
        {
            Evento E = new Evento();
            try
            {
                E.Id = idEvento.Text;
                E.Name = nomeEvento.Text;
                E.NumBilhetes = numbilhetes.Text;
                E.Numdias = numdias.Text;
                E.Dataini = datainicio.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            int rows = 0;

            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE EM.EVENTO " + "SET nome = @Nome, numdias = @Numdias, dataini = @Dataini, numbilhetes = @Numbilhetes WHERE id = @Id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", E.Id);
            cmd.Parameters.AddWithValue("@Nome", E.Name);
            cmd.Parameters.AddWithValue("@Numdias", E.Numdias);
            cmd.Parameters.AddWithValue("@Dataini", DateTime.Parse(E.Dataini));
            cmd.Parameters.AddWithValue("@Numbilhetes", E.NumBilhetes);
            cmd.Connection = cn;

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 1)
                    MessageBox.Show("Update OK");
                else
                    MessageBox.Show("Update NOT OK");

                cn.Close();
            }
        }

        // aux
        public void ShowEvent()
        {
            if (listBox1.Items.Count == 0 | currentEvent < 0)
                return;
            Evento E = new Evento();
            E = (Evento)listBox1.Items[currentEvent];
            idEvento.Text = E.Id;
            nomeEvento.Text = E.Name;
            datainicio.Text = E.Dataini;
            numdias.Text = E.Numdias;
            numbilhetes.Text = E.NumBilhetes;

        }
        public void ClearFields()
        {
            idEvento.Text = "";
            nomeEvento.Text = "";
            datainicio.Text= "";
            numdias.Text = "";
            numbilhetes.Text = "";
        }

        private SqlConnection getSGBDConnection()
        {
            string dbServer = "tcp:mednat.ieeta.pt\\SQLSERVER,8101";
            string dbName = "p2g5";
            string userName = "p2g5";
            string userPass = "PedroJoaoS_Q_L";
            return new SqlConnection("Data Source = " + dbServer + " ;" + "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass);

        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            currentEvent = listBox1.SelectedIndex;
            if (currentEvent <= 0)
            {
                MessageBox.Show("Please select a contact to edit");
                return;
            }
            else
            {
                ShowEvent();
            }
            EditEvent.Visible = false;
            adicionarEvento.Visible = false;
            adicionar.Visible = false;
            Update.Visible = true;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            EditEvent.Visible = true;
            adicionarEvento.Visible = true;
            adicionar.Visible = false;
            Update.Visible = false;
        }
    }
}
