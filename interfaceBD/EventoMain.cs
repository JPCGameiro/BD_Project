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
        private int currentConcerto;

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
            HideBandasSection();
            HideMusicosSection();
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

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > 0)
            {
                currentConcerto = listBox3.SelectedIndex;
                ShowConcerto();
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
        public void ShowConcerto()
        {
            if (listBox3.Items.Count == 0 | currentConcerto < 0)
                return;
            Concerto C = new Concerto();
            C = (Concerto)listBox1.Items[currentConcerto];
            id_concerto_input.Text = C.Id;
            dataini_dtpicker_data_input.Text = C.Dataini;
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
        public void ClearConcertosFields()
        {
            id_concerto_input.Text = "";
            dataini_dtpicker_data_input.Text = "";
            horaini_concerto_dtpicker.Text = "";
            duracao_dtpicker_hora.Text = "";
            id_banda_input.Text = "";
            id_evento_input.Text = "";
            id_soundcheck_input.Text = "";
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

        // adicionar, editar, remover evento
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
        // adicionar, editar, remover Concerto
        private void adicionarConcertoBtn_Click(object sender, EventArgs e)
        {
            addConcertoBtn.Visible = true;
            adicionarConcertoBtn.Visible = false;
            editConcertoBtn.Visible = false;
            deleteConcertoBtn.Visible = false;
            ClearConcertosFields();
        }
        private void addConcertoBtn_Click(object sender, EventArgs e)
        {
            Concerto C = new Concerto();
            C.Id = idEvento.Text;
            C.Dataini = dataini_dtpicker_data_input.Text + horaini_concerto_dtpicker.Text;
            C.Duracao = duracao_dtpicker_hora.Text;
            C.Id_banda = id_banda_input.Text;
            C.Id_evento = id_evento_input.Text;
            C.Id_scheck = id_soundcheck_input.Text;
            // adicionar evento à bd
            SubmitConcerto(C);
        }
        private void SubmitConcerto(Concerto C)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT EM.EVENTO (id, datatimeini, duracao, id_banda, id_evento, id_soundcheck) VALUES (@ID, @Data, @dur, @id_b, @id_e, @id_s)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", C.Id);
            cmd.Parameters.AddWithValue("@Data", DateTime.Parse(C.Dataini));
            cmd.Parameters.AddWithValue("@dur", C.Duracao);
            cmd.Parameters.AddWithValue("@id_b", C.Id_banda);
            cmd.Parameters.AddWithValue("@id_e", C.Id_evento);
            cmd.Parameters.AddWithValue("@id_s", C.Id_scheck);
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
                MessageBox.Show("Concerto \"" + C.Id + "\" with succsess");
                cn.Close();
            }
            addConcertoBtn.Visible = false;
            adicionarConcertoBtn.Visible = true;
            editConcertoBtn.Visible = true;
            deleteConcertoBtn.Visible = true;
        }

        


        // load from database
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
        private void LoadBandas()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM EM.V_BANDAS", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox_bandas.Items.Clear();
            listBox_bandas.Items.Add(Banda.Fline());
            while (reader.Read())
            {
                Banda B = new Banda();
                B.Id = reader["id"].ToString();
                B.Nome = reader["nome"].ToString();
                B.Telefone = "+" + reader["telefone"].ToString();
                B.Email = reader["email"].ToString();
                B.NumElem = reader["numElem"].ToString();
                B.Genero = reader["genero"].ToString();
                listBox_bandas.Items.Add(B);
            }
            cn.Close();
        }
        private void LoadMusicos()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM EM.V_MUSICOS", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listBox_musicos.Items.Clear();
            listBox_musicos.Items.Add(Musico.Fline());
            while (reader.Read())
            {
                Musico M = new Musico();
                M.NumCC = reader["numCC"].ToString();
                M.Nome = reader["nome"].ToString();
                M.NomeArt = reader["nomeArst"].ToString();
                M.Email = reader["email"].ToString();
                M.Sexo = reader["sexo"].ToString();
                M.Banda = reader["banda"].ToString();
                listBox_musicos.Items.Add(M);
            }
            cn.Close();
        }

        // menu buttons
        private void button1_Click(object sender, EventArgs e)
        {
            HideOverviewSection();
            HideConcertosSection();
            HideBandasSection();
            HideMusicosSection();
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
            SearchBtn_Eventos.Show();
            deleteEvento.Show();
            adicionarEvento.Show();
            EditEvent.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HideEventoSection();
            HideBandasSection();
            HideConcertosSection();
            HideMusicosSection();
            listBox2.Show();
            groupboxOverview.Show();
            LoadOverview();

        }
        private void concertobtn_Click(object sender, EventArgs e)
        {
            HideOverviewSection();
            HideEventoSection();
            HideBandasSection();
            HideMusicosSection();
            listBox3.Show();
            deleteConcertoBtn.Show();
            editConcertoBtn.Show();
            deleteConcertoBtn.Show();
            adicionarConcertoBtn.Show();
            id_concerto_label.Show();
            id_concerto_input.Show();
            dataini_concerto_label.Show();
            dataini_dtpicker_data_input.Show();
            horaini_concerto_label.Show();
            horaini_concerto_dtpicker.Show();
            duracao_dtpicker.Show();
            duracao_dtpicker_hora.Show();
            id_banda_label.Show();
            id_banda_input.Show();
            id_evento_label.Show();
            id_evento_input.Show();
            id_soundcheck_label.Show();
            id_soundcheck_input.Show();
            groupBox_Concertos.Show();
            LoadConcertos();
        }
        private void bandabtn_Click(object sender, EventArgs e)
        {
            HideConcertosSection();
            HideEventoSection();
            HideOverviewSection();
            HideMusicosSection();
            listBox_bandas.Show();
            groupBox_bandas.Show();
            LoadBandas();
        }
        private void musicosbtn_Click(object sender, EventArgs e)
        {
            HideConcertosSection();
            HideEventoSection();
            HideOverviewSection();
            HideBandasSection();
            listBox_musicos.Show();
            groupBox_musicos.Show();
            LoadMusicos();
        }
        // section Hide
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
            SearchBtn_Eventos.Hide();
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
            id_concerto_label.Hide();
            id_concerto_input.Hide();
            dataini_concerto_label.Hide();
            dataini_dtpicker_data_input.Hide();
            horaini_concerto_label.Hide();
            horaini_concerto_dtpicker.Hide();
            duracao_dtpicker.Hide();
            duracao_dtpicker_hora.Hide();
            id_banda_label.Hide();
            id_banda_input.Hide();
            id_evento_label.Hide();
            id_evento_input.Hide();
            id_soundcheck_label.Hide();
            id_soundcheck_input.Hide();
            groupBox_Concertos.Hide();
        }
        private void HideBandasSection()
        {
            listBox_bandas.Hide();
            groupBox_bandas.Hide();
        }

        private void HideMusicosSection()
        {
            listBox_musicos.Hide();
            groupBox_musicos.Hide();
        }

        private void UpdateConcertoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
