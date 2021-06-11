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
    public partial class EventoMain : Form
    {
        private SqlConnection cn;
        private int currentEvent;

        public EventoMain()
        {
            InitializeComponent();
        }

        // event handler
        private void Form1_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            adicionar.Visible = false;
            Update.Visible = false;
            HideOverviewSection();
            HideConcertosSection();
            loadEventos();
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (searchbar.Text != "")
            {
                String str = "";
                if (idrb.Checked)
                {
                    str = "id LIKE '%" + searchbar.Text + "%'";
                }
                else if (namerb.Checked)
                {
                    str = "nome LIKE '%" + searchbar.Text + "%'";
                }
                else if (promotorrb.Checked)
                {
                    str = "cc_promotor LIKE '%" + searchbar.Text + "%'";
                }
                else if (stageManagerrb.Checked)
                {
                    str = "cc_stageManager LIKE '%" + searchbar.Text + "%'";
                }
                else
                {
                    MessageBox.Show("Please select a filter!");
                }
                loadEventos("SELECT * FROM EM.EVENTO WHERE " + str);
            }
            else
            {
                loadEventos();
            }
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
            deleteEvento.Visible = false;
            EditEvent.Visible = false;
            ClearFields();
            if (reader.Read())
            {
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
            E.Datafim = datefim.Text;
            E.DataProposta = dataproposta.Text;
            E.Cc_stageManager = ccstageManager.Text;
            E.Cc_promotor = ccpromotor.Text;
            // adicionar evento à bd
            SubmitEvento(E);
        }

        // db interation
        private void loadEventos()
        {
            loadEventos("SELECT * FROM EM.EVENTO ORDER BY id");
        }

        private void loadEventos(String query)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            listBox1.Items.Add(Evento.Fline());
            while (reader.Read())
            {
                Evento E = new Evento();
                E.Id = reader["id"].ToString();
                E.Name = reader["nome"].ToString();
                E.Numdias = reader["numdias"].ToString();
                E.NumBilhetes = reader["numbilhetes"].ToString();
                E.Dataini = reader["dataini"].ToString().Split(' ')[0];
                E.Datafim = reader["datafim"].ToString().Split(' ')[0]; ;
                E.Cc_promotor = reader["cc_promotor"].ToString();
                E.DataProposta = reader["dataproposta"].ToString().Split(' ')[0]; ;
                E.Cc_stageManager = reader["cc_stageManager"].ToString();
                listBox1.Items.Add(E);
            }
            cn.Close();
        }

        private void LoadConcertos()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("select * from EM.V_CONCERTOS", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox3.Items.Clear();
            listBox3.Items.Add(Concerto.Fline());
            while (reader.Read())
            {
                Concerto C = new Concerto();
                C.Id = reader["id"].ToString();
                C.Nome = reader["nome"].ToString();
                C.Id_evento = reader["id_evento"].ToString();
                C.Banda = reader["banda"].ToString();
                C.Id_banda = reader["id_banda"].ToString().Split(' ')[0];
                C.Dataini = reader["datatimeini"].ToString().Split(' ')[0];
                C.Duracao = reader["duracao"].ToString();
                listBox3.Items.Add(C);
            }
            cn.Close();
        }


        private void SubmitEvento(Evento E)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT EM.EVENTO (id, nome, numdias, dataini, numbilhetes, datafim, dataproposta, cc_promotor, cc_stageManager) VALUES (@ID, @Nome, @Numdias, @Dataini, @Numbilhetes, @datafim, @dataproposta, @cc_promotor, @cc_sM)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", E.Id);
            cmd.Parameters.AddWithValue("@Nome", E.Name);
            cmd.Parameters.AddWithValue("@Numdias", E.Numdias);
            cmd.Parameters.AddWithValue("@Dataini", DateTime.Parse(E.Dataini));
            cmd.Parameters.AddWithValue("@Numbilhetes", E.NumBilhetes);
            cmd.Parameters.AddWithValue("@datafim", DateTime.Parse(E.Datafim));
            cmd.Parameters.AddWithValue("@dataproposta", DateTime.Parse(E.DataProposta));
            cmd.Parameters.AddWithValue("@cc_promotor", E.Cc_promotor);
            cmd.Parameters.AddWithValue("@cc_sM", E.Cc_stageManager);
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
                MessageBox.Show("Event \"" + E.Name + "\" with succsess");
                cn.Close();
            }
            adicionar.Visible = false;
            adicionarEvento.Visible = true;
            EditEvent.Visible = true;
            deleteEvento.Visible = true;
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
                E.Datafim = datefim.Text;
                E.DataProposta = dataproposta.Text;
                E.Cc_stageManager = ccstageManager.Text;
                E.Cc_promotor = ccpromotor.Text;

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

            cmd.CommandText = "UPDATE EM.EVENTO " + "SET nome = @Nome, numdias = @Numdias, dataini = @Dataini, numbilhetes = @Numbilhetes, datafim = @datafim, dataproposta = @dataproposta, cc_promotor = @cc_promotor, cc_stageManager = @cc_sM WHERE id = @Id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", E.Id);
            cmd.Parameters.AddWithValue("@Nome", E.Name);
            cmd.Parameters.AddWithValue("@Numdias", E.Numdias);
            cmd.Parameters.AddWithValue("@Dataini", DateTime.Parse(E.Dataini));
            cmd.Parameters.AddWithValue("@Numbilhetes", E.NumBilhetes);
            cmd.Parameters.AddWithValue("@datafim", DateTime.Parse(E.Datafim));
            cmd.Parameters.AddWithValue("@dataproposta", DateTime.Parse(E.DataProposta));
            cmd.Parameters.AddWithValue("@cc_promotor", E.Cc_promotor);
            cmd.Parameters.AddWithValue("@cc_sM", E.Cc_stageManager);
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

        public void RemoveEvent(String eventoId)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE EM.EVENTO WHERE id=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", eventoId);
            cmd.Connection = cn;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
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
            datefim.Text = E.Datafim;
            ccpromotor.Text = E.Cc_promotor;
            ccstageManager.Text = E.Cc_stageManager;
            dataproposta.Text = E.DataProposta;
        }
        public void ClearFields()
        {
            idEvento.Text = "";
            nomeEvento.Text = "";
            datainicio.Text = "";
            numdias.Text = "";
            numbilhetes.Text = "";
            datefim.Text = "";
            ccpromotor.Text = "";
            ccstageManager.Text = "";
            dataproposta.Text = "";
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
            deleteEvento.Visible = false;
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
            deleteEvento.Visible = true;
        }

        private void deleteEvento_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                try
                {
                    RemoveEvent(((Evento)listBox1.SelectedItem).Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (currentEvent == listBox1.Items.Count)
                    currentEvent = listBox1.Items.Count - 1;
                if (currentEvent == -1)
                {
                    ClearFields();
                    MessageBox.Show("There are no more Eventos");
                }
                else
                {
                    ShowEvent();
                }
            }
            EditEvent.Visible = true;
            adicionarEvento.Visible = true;
            adicionar.Visible = false;
            Update.Visible = false;
            deleteEvento.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideEventoSection();
            listBox2.Show();
            groupboxOverview.Show();
            LoadOverview();

        }

        private void LoadOverview()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM EM.V_OVERVIEW", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox2.Items.Clear();
            listBox2.Items.Add(Overview.Fline());
            while (reader.Read())
            {
                Overview O = new Overview();
                O.Nome = reader["nome"].ToString();
                O.Numdias = reader["numdias"].ToString();
                O.Numbilhetes = reader["numbilhetes"].ToString();
                O.Dataini = reader["dataini"].ToString().Split(' ')[0];
                O.Banda = reader["BANDA"].ToString();
                O.Promotor = reader["PROMOTOR"].ToString().Split(' ')[0]; ;
                O.Duracao = reader["duracao"].ToString();
                listBox2.Items.Add(O);
            }
            cn.Close();
        }

        private void HideEventoSection()
        {
            listBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            Label1X.Hide();
            nomeEvento.Hide();
            idEvento.Hide();
            datainicio.Hide();
            datefim.Hide();
            dataproposta.Hide();
            numdias.Hide();
            numbilhetes.Hide();
            ccpromotor.Hide();
            ccstageManager.Hide();
            groupBox1.Hide();
            idrb.Hide();
            namerb.Hide();
            promotorrb.Hide();
            stageManagerrb.Hide();
            searchbar.Hide();
            button2.Hide();
            deleteEvento.Hide();
            adicionarEvento.Hide();
            EditEvent.Hide();
            Update.Hide();
            adicionar.Hide();
        }

        private void HideOverviewSection()
        {
            listBox2.Hide();
            groupboxOverview.Hide();
        }

        private void HideConcertosSection()
        {
            listBox3.Hide();
            listBox2.Hide();
            editConcertoBtn.Hide();
            deleteConcertoBtn.Hide();
            addConcertoBtn.Hide();
            editConcertoBtn.Hide();
            UpdateConcertoBtn.Hide();
            adicionarConcertoBtn.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideOverviewSection();
            HideConcertosSection();
            listBox1.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            Label1X.Show();
            nomeEvento.Show();
            idEvento.Show();
            datainicio.Show();
            datefim.Show();
            dataproposta.Show();
            numdias.Show();
            numbilhetes.Show();
            ccpromotor.Show();
            ccstageManager.Show();
            groupBox1.Show();
            idrb.Show();
            namerb.Show();
            promotorrb.Show();
            stageManagerrb.Show();
            searchbar.Show();
            button2.Show();
            deleteEvento.Show();
            adicionarEvento.Show();
            EditEvent.Show();
        }

        private void concertobtn_Click(object sender, EventArgs e)
        {
            HideOverviewSection();
            HideEventoSection();
            listBox3.Show();
            deleteConcertoBtn.Show();
            editConcertoBtn.Show();
            deleteConcertoBtn.Show();
            adicionarConcertoBtn.Show();
            LoadConcertos();
        }
    }
}
