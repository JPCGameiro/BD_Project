
namespace interfaceBD
{
    partial class EventoMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Eventosbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nomeEvento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numdias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numbilhetes = new System.Windows.Forms.TextBox();
            this.datainicio = new System.Windows.Forms.DateTimePicker();
            this.adicionarEvento = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.idEvento = new System.Windows.Forms.TextBox();
            this.Label1X = new System.Windows.Forms.Label();
            this.EditEvent = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.deleteEvento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stageManagerrb = new System.Windows.Forms.RadioButton();
            this.promotorrb = new System.Windows.Forms.RadioButton();
            this.namerb = new System.Windows.Forms.RadioButton();
            this.idrb = new System.Windows.Forms.RadioButton();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.datefim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ccpromotor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccstageManager = new System.Windows.Forms.TextBox();
            this.dataproposta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.OveriewBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupboxOverview = new System.Windows.Forms.GroupBox();
            this.SearchBtnOverview = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.searchbarOverview = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.concertobtn = new System.Windows.Forms.Button();
            this.bandabtn = new System.Windows.Forms.Button();
            this.musicosbtn = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.deleteConcertoBtn = new System.Windows.Forms.Button();
            this.editConcertoBtn = new System.Windows.Forms.Button();
            this.adicionarConcertoBtn = new System.Windows.Forms.Button();
            this.addConcertoBtn = new System.Windows.Forms.Button();
            this.UpdateConcertoBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupboxOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // Eventosbtn
            // 
            this.Eventosbtn.Location = new System.Drawing.Point(100, 10);
            this.Eventosbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Eventosbtn.Name = "Eventosbtn";
            this.Eventosbtn.Size = new System.Drawing.Size(70, 36);
            this.Eventosbtn.TabIndex = 0;
            this.Eventosbtn.Text = "Eventos";
            this.Eventosbtn.UseVisualStyleBackColor = true;
            this.Eventosbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(9, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(746, 438);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nomeEvento
            // 
            this.nomeEvento.Location = new System.Drawing.Point(778, 67);
            this.nomeEvento.Margin = new System.Windows.Forms.Padding(2);
            this.nomeEvento.Name = "nomeEvento";
            this.nomeEvento.Size = new System.Drawing.Size(244, 20);
            this.nomeEvento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Evento\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número de dias";
            // 
            // numdias
            // 
            this.numdias.Location = new System.Drawing.Point(778, 202);
            this.numdias.Margin = new System.Windows.Forms.Padding(2);
            this.numdias.Name = "numdias";
            this.numdias.Size = new System.Drawing.Size(170, 20);
            this.numdias.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(968, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero de bilhetes";
            // 
            // numbilhetes
            // 
            this.numbilhetes.Location = new System.Drawing.Point(970, 202);
            this.numbilhetes.Margin = new System.Windows.Forms.Padding(2);
            this.numbilhetes.Name = "numbilhetes";
            this.numbilhetes.Size = new System.Drawing.Size(169, 20);
            this.numbilhetes.TabIndex = 9;
            // 
            // datainicio
            // 
            this.datainicio.Location = new System.Drawing.Point(778, 130);
            this.datainicio.Margin = new System.Windows.Forms.Padding(2);
            this.datainicio.Name = "datainicio";
            this.datainicio.Size = new System.Drawing.Size(170, 20);
            this.datainicio.TabIndex = 11;
            // 
            // adicionarEvento
            // 
            this.adicionarEvento.Location = new System.Drawing.Point(1040, 518);
            this.adicionarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.adicionarEvento.Name = "adicionarEvento";
            this.adicionarEvento.Size = new System.Drawing.Size(91, 33);
            this.adicionarEvento.TabIndex = 12;
            this.adicionarEvento.Text = "Add Evento";
            this.adicionarEvento.UseVisualStyleBackColor = true;
            this.adicionarEvento.Click += new System.EventHandler(this.adicionarEvento_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(1040, 518);
            this.adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(91, 33);
            this.adicionar.TabIndex = 13;
            this.adicionar.Text = "Add";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // idEvento
            // 
            this.idEvento.Location = new System.Drawing.Point(1068, 67);
            this.idEvento.Margin = new System.Windows.Forms.Padding(2);
            this.idEvento.Name = "idEvento";
            this.idEvento.Size = new System.Drawing.Size(71, 20);
            this.idEvento.TabIndex = 14;
            // 
            // Label1X
            // 
            this.Label1X.AutoSize = true;
            this.Label1X.Location = new System.Drawing.Point(1066, 50);
            this.Label1X.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1X.Name = "Label1X";
            this.Label1X.Size = new System.Drawing.Size(68, 13);
            this.Label1X.TabIndex = 15;
            this.Label1X.Text = "Id do Evento";
            // 
            // EditEvent
            // 
            this.EditEvent.Location = new System.Drawing.Point(912, 518);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(91, 34);
            this.EditEvent.TabIndex = 16;
            this.EditEvent.Text = "Edit Evento";
            this.EditEvent.UseVisualStyleBackColor = true;
            this.EditEvent.Click += new System.EventHandler(this.EditEvent_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1040, 517);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(91, 34);
            this.Update.TabIndex = 17;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // deleteEvento
            // 
            this.deleteEvento.Location = new System.Drawing.Point(778, 518);
            this.deleteEvento.Margin = new System.Windows.Forms.Padding(2);
            this.deleteEvento.Name = "deleteEvento";
            this.deleteEvento.Size = new System.Drawing.Size(91, 33);
            this.deleteEvento.TabIndex = 18;
            this.deleteEvento.Text = "Delete Evento";
            this.deleteEvento.UseVisualStyleBackColor = true;
            this.deleteEvento.Click += new System.EventHandler(this.deleteEvento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stageManagerrb);
            this.groupBox1.Controls.Add(this.promotorrb);
            this.groupBox1.Controls.Add(this.namerb);
            this.groupBox1.Controls.Add(this.idrb);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.searchbar);
            this.groupBox1.Location = new System.Drawing.Point(9, 500);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(753, 58);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "filtros";
            this.groupBox1.UseWaitCursor = true;
            // 
            // stageManagerrb
            // 
            this.stageManagerrb.AutoSize = true;
            this.stageManagerrb.Location = new System.Drawing.Point(266, 24);
            this.stageManagerrb.Margin = new System.Windows.Forms.Padding(2);
            this.stageManagerrb.Name = "stageManagerrb";
            this.stageManagerrb.Size = new System.Drawing.Size(96, 17);
            this.stageManagerrb.TabIndex = 3;
            this.stageManagerrb.TabStop = true;
            this.stageManagerrb.Text = "stage Manager";
            this.stageManagerrb.UseVisualStyleBackColor = true;
            this.stageManagerrb.UseWaitCursor = true;
            // 
            // promotorrb
            // 
            this.promotorrb.AutoSize = true;
            this.promotorrb.Location = new System.Drawing.Point(178, 24);
            this.promotorrb.Margin = new System.Windows.Forms.Padding(2);
            this.promotorrb.Name = "promotorrb";
            this.promotorrb.Size = new System.Drawing.Size(66, 17);
            this.promotorrb.TabIndex = 2;
            this.promotorrb.TabStop = true;
            this.promotorrb.Text = "promotor";
            this.promotorrb.UseVisualStyleBackColor = true;
            this.promotorrb.UseWaitCursor = true;
            // 
            // namerb
            // 
            this.namerb.AutoSize = true;
            this.namerb.Location = new System.Drawing.Point(92, 24);
            this.namerb.Margin = new System.Windows.Forms.Padding(2);
            this.namerb.Name = "namerb";
            this.namerb.Size = new System.Drawing.Size(51, 17);
            this.namerb.TabIndex = 1;
            this.namerb.TabStop = true;
            this.namerb.Text = "name";
            this.namerb.UseVisualStyleBackColor = true;
            this.namerb.UseWaitCursor = true;
            // 
            // idrb
            // 
            this.idrb.AutoSize = true;
            this.idrb.Location = new System.Drawing.Point(4, 24);
            this.idrb.Margin = new System.Windows.Forms.Padding(2);
            this.idrb.Name = "idrb";
            this.idrb.Size = new System.Drawing.Size(33, 17);
            this.idrb.TabIndex = 0;
            this.idrb.TabStop = true;
            this.idrb.Text = "id";
            this.idrb.UseVisualStyleBackColor = true;
            this.idrb.UseWaitCursor = true;
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(440, 26);
            this.searchbar.Margin = new System.Windows.Forms.Padding(2);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(235, 20);
            this.searchbar.TabIndex = 20;
            this.searchbar.UseWaitCursor = true;
            // 
            // datefim
            // 
            this.datefim.Location = new System.Drawing.Point(969, 130);
            this.datefim.Margin = new System.Windows.Forms.Padding(2);
            this.datefim.Name = "datefim";
            this.datefim.Size = new System.Drawing.Size(170, 20);
            this.datefim.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(968, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data de Fim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(776, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "CC do promotor";
            // 
            // ccpromotor
            // 
            this.ccpromotor.Location = new System.Drawing.Point(778, 272);
            this.ccpromotor.Margin = new System.Windows.Forms.Padding(2);
            this.ccpromotor.Name = "ccpromotor";
            this.ccpromotor.Size = new System.Drawing.Size(170, 20);
            this.ccpromotor.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(968, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "CC do stage Manager";
            // 
            // ccstageManager
            // 
            this.ccstageManager.Location = new System.Drawing.Point(970, 272);
            this.ccstageManager.Margin = new System.Windows.Forms.Padding(2);
            this.ccstageManager.Name = "ccstageManager";
            this.ccstageManager.Size = new System.Drawing.Size(170, 20);
            this.ccstageManager.TabIndex = 25;
            // 
            // dataproposta
            // 
            this.dataproposta.Location = new System.Drawing.Point(778, 344);
            this.dataproposta.Margin = new System.Windows.Forms.Padding(2);
            this.dataproposta.Name = "dataproposta";
            this.dataproposta.Size = new System.Drawing.Size(170, 20);
            this.dataproposta.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(776, 323);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Data da proposta";
            // 
            // OveriewBtn
            // 
            this.OveriewBtn.Location = new System.Drawing.Point(9, 10);
            this.OveriewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.OveriewBtn.Name = "OveriewBtn";
            this.OveriewBtn.Size = new System.Drawing.Size(79, 36);
            this.OveriewBtn.TabIndex = 29;
            this.OveriewBtn.Text = "Overview";
            this.OveriewBtn.UseVisualStyleBackColor = true;
            this.OveriewBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 14;
            this.listBox2.Location = new System.Drawing.Point(9, 50);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1130, 438);
            this.listBox2.TabIndex = 30;
            // 
            // groupboxOverview
            // 
            this.groupboxOverview.Controls.Add(this.SearchBtnOverview);
            this.groupboxOverview.Controls.Add(this.radioButton5);
            this.groupboxOverview.Controls.Add(this.searchbarOverview);
            this.groupboxOverview.Controls.Add(this.radioButton4);
            this.groupboxOverview.Controls.Add(this.radioButton3);
            this.groupboxOverview.Controls.Add(this.radioButton2);
            this.groupboxOverview.Controls.Add(this.radioButton1);
            this.groupboxOverview.Location = new System.Drawing.Point(9, 500);
            this.groupboxOverview.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxOverview.Name = "groupboxOverview";
            this.groupboxOverview.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxOverview.Size = new System.Drawing.Size(753, 58);
            this.groupboxOverview.TabIndex = 31;
            this.groupboxOverview.TabStop = false;
            this.groupboxOverview.Text = "filtros";
            // 
            // SearchBtnOverview
            // 
            this.SearchBtnOverview.Location = new System.Drawing.Point(696, 15);
            this.SearchBtnOverview.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtnOverview.Name = "SearchBtnOverview";
            this.SearchBtnOverview.Size = new System.Drawing.Size(49, 34);
            this.SearchBtnOverview.TabIndex = 33;
            this.SearchBtnOverview.Text = "Search";
            this.SearchBtnOverview.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(352, 24);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 32;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // searchbarOverview
            // 
            this.searchbarOverview.Location = new System.Drawing.Point(440, 24);
            this.searchbarOverview.Margin = new System.Windows.Forms.Padding(2);
            this.searchbarOverview.Name = "searchbarOverview";
            this.searchbarOverview.Size = new System.Drawing.Size(235, 20);
            this.searchbarOverview.TabIndex = 32;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(266, 24);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 32;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(178, 24);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(92, 24);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 24);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // concertobtn
            // 
            this.concertobtn.Location = new System.Drawing.Point(183, 10);
            this.concertobtn.Margin = new System.Windows.Forms.Padding(2);
            this.concertobtn.Name = "concertobtn";
            this.concertobtn.Size = new System.Drawing.Size(70, 36);
            this.concertobtn.TabIndex = 32;
            this.concertobtn.Text = "Concertos";
            this.concertobtn.UseVisualStyleBackColor = true;
            this.concertobtn.Click += new System.EventHandler(this.concertobtn_Click);
            // 
            // bandabtn
            // 
            this.bandabtn.Location = new System.Drawing.Point(266, 10);
            this.bandabtn.Margin = new System.Windows.Forms.Padding(2);
            this.bandabtn.Name = "bandabtn";
            this.bandabtn.Size = new System.Drawing.Size(70, 36);
            this.bandabtn.TabIndex = 33;
            this.bandabtn.Text = "Bandas";
            this.bandabtn.UseVisualStyleBackColor = true;
            // 
            // musicosbtn
            // 
            this.musicosbtn.Location = new System.Drawing.Point(349, 10);
            this.musicosbtn.Margin = new System.Windows.Forms.Padding(2);
            this.musicosbtn.Name = "musicosbtn";
            this.musicosbtn.Size = new System.Drawing.Size(70, 36);
            this.musicosbtn.TabIndex = 34;
            this.musicosbtn.Text = "Musicas";
            this.musicosbtn.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.ItemHeight = 14;
            this.listBox3.Location = new System.Drawing.Point(8, 50);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(746, 438);
            this.listBox3.TabIndex = 35;
            // 
            // deleteConcertoBtn
            // 
            this.deleteConcertoBtn.Location = new System.Drawing.Point(778, 515);
            this.deleteConcertoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteConcertoBtn.Name = "deleteConcertoBtn";
            this.deleteConcertoBtn.Size = new System.Drawing.Size(91, 36);
            this.deleteConcertoBtn.TabIndex = 36;
            this.deleteConcertoBtn.Text = "Delete Concerto";
            this.deleteConcertoBtn.UseVisualStyleBackColor = true;
            // 
            // editConcertoBtn
            // 
            this.editConcertoBtn.Location = new System.Drawing.Point(912, 515);
            this.editConcertoBtn.Name = "editConcertoBtn";
            this.editConcertoBtn.Size = new System.Drawing.Size(91, 37);
            this.editConcertoBtn.TabIndex = 37;
            this.editConcertoBtn.Text = "Edit Concerto";
            this.editConcertoBtn.UseVisualStyleBackColor = true;
            // 
            // adicionarConcertoBtn
            // 
            this.adicionarConcertoBtn.Location = new System.Drawing.Point(1040, 515);
            this.adicionarConcertoBtn.Name = "adicionarConcertoBtn";
            this.adicionarConcertoBtn.Size = new System.Drawing.Size(91, 35);
            this.adicionarConcertoBtn.TabIndex = 38;
            this.adicionarConcertoBtn.Text = "Adicionar Concerto";
            this.adicionarConcertoBtn.UseVisualStyleBackColor = true;
            // 
            // addConcertoBtn
            // 
            this.addConcertoBtn.Location = new System.Drawing.Point(1040, 516);
            this.addConcertoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addConcertoBtn.Name = "addConcertoBtn";
            this.addConcertoBtn.Size = new System.Drawing.Size(91, 36);
            this.addConcertoBtn.TabIndex = 39;
            this.addConcertoBtn.Text = "Add";
            this.addConcertoBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateConcertoBtn
            // 
            this.UpdateConcertoBtn.Location = new System.Drawing.Point(1040, 516);
            this.UpdateConcertoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateConcertoBtn.Name = "UpdateConcertoBtn";
            this.UpdateConcertoBtn.Size = new System.Drawing.Size(91, 36);
            this.UpdateConcertoBtn.TabIndex = 40;
            this.UpdateConcertoBtn.Text = "Update";
            this.UpdateConcertoBtn.UseVisualStyleBackColor = true;
            // 
            // EventoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 561);
            this.Controls.Add(this.UpdateConcertoBtn);
            this.Controls.Add(this.addConcertoBtn);
            this.Controls.Add(this.adicionarConcertoBtn);
            this.Controls.Add(this.editConcertoBtn);
            this.Controls.Add(this.deleteConcertoBtn);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.musicosbtn);
            this.Controls.Add(this.bandabtn);
            this.Controls.Add(this.concertobtn);
            this.Controls.Add(this.groupboxOverview);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.OveriewBtn);
            this.Controls.Add(this.dataproposta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ccstageManager);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ccpromotor);
            this.Controls.Add(this.datefim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteEvento);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.EditEvent);
            this.Controls.Add(this.Label1X);
            this.Controls.Add(this.idEvento);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.adicionarEvento);
            this.Controls.Add(this.datainicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numbilhetes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numdias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeEvento);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Eventosbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventoMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupboxOverview.ResumeLayout(false);
            this.groupboxOverview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eventosbtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nomeEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numdias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numbilhetes;
        private System.Windows.Forms.DateTimePicker datainicio;
        private System.Windows.Forms.Button adicionarEvento;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.TextBox idEvento;
        private System.Windows.Forms.Label Label1X;
        private System.Windows.Forms.Button EditEvent;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button deleteEvento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.RadioButton promotorrb;
        private System.Windows.Forms.RadioButton namerb;
        private System.Windows.Forms.RadioButton idrb;
        private System.Windows.Forms.RadioButton stageManagerrb;
        private System.Windows.Forms.DateTimePicker datefim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ccpromotor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ccstageManager;
        private System.Windows.Forms.DateTimePicker dataproposta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OveriewBtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupboxOverview;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox searchbarOverview;
        private System.Windows.Forms.Button SearchBtnOverview;
        private System.Windows.Forms.Button concertobtn;
        private System.Windows.Forms.Button bandabtn;
        private System.Windows.Forms.Button musicosbtn;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button deleteConcertoBtn;
        private System.Windows.Forms.Button editConcertoBtn;
        private System.Windows.Forms.Button adicionarConcertoBtn;
        private System.Windows.Forms.Button addConcertoBtn;
        private System.Windows.Forms.Button UpdateConcertoBtn;
    }
}

