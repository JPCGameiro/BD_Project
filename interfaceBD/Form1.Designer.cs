
namespace interfaceBD
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eventos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(993, 544);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(940, 636);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nomeEvento
            // 
            this.nomeEvento.Location = new System.Drawing.Point(1037, 82);
            this.nomeEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomeEvento.Name = "nomeEvento";
            this.nomeEvento.Size = new System.Drawing.Size(324, 22);
            this.nomeEvento.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1035, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Evento\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1035, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1035, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número de dias";
            // 
            // numdias
            // 
            this.numdias.Location = new System.Drawing.Point(1037, 249);
            this.numdias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numdias.Name = "numdias";
            this.numdias.Size = new System.Drawing.Size(225, 22);
            this.numdias.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1290, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero de bilhetes";
            // 
            // numbilhetes
            // 
            this.numbilhetes.Location = new System.Drawing.Point(1293, 249);
            this.numbilhetes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numbilhetes.Name = "numbilhetes";
            this.numbilhetes.Size = new System.Drawing.Size(224, 22);
            this.numbilhetes.TabIndex = 9;
            // 
            // datainicio
            // 
            this.datainicio.Location = new System.Drawing.Point(1037, 160);
            this.datainicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datainicio.Name = "datainicio";
            this.datainicio.Size = new System.Drawing.Size(225, 22);
            this.datainicio.TabIndex = 11;
            // 
            // adicionarEvento
            // 
            this.adicionarEvento.Location = new System.Drawing.Point(1387, 637);
            this.adicionarEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adicionarEvento.Name = "adicionarEvento";
            this.adicionarEvento.Size = new System.Drawing.Size(121, 41);
            this.adicionarEvento.TabIndex = 12;
            this.adicionarEvento.Text = "Add Evento";
            this.adicionarEvento.UseVisualStyleBackColor = true;
            this.adicionarEvento.Click += new System.EventHandler(this.adicionarEvento_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(1387, 637);
            this.adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(121, 41);
            this.adicionar.TabIndex = 13;
            this.adicionar.Text = "Add";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // idEvento
            // 
            this.idEvento.Location = new System.Drawing.Point(1424, 82);
            this.idEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idEvento.Name = "idEvento";
            this.idEvento.Size = new System.Drawing.Size(93, 22);
            this.idEvento.TabIndex = 14;
            // 
            // Label1X
            // 
            this.Label1X.AutoSize = true;
            this.Label1X.Location = new System.Drawing.Point(1421, 62);
            this.Label1X.Name = "Label1X";
            this.Label1X.Size = new System.Drawing.Size(87, 17);
            this.Label1X.TabIndex = 15;
            this.Label1X.Text = "Id do Evento";
            // 
            // EditEvent
            // 
            this.EditEvent.Location = new System.Drawing.Point(1216, 637);
            this.EditEvent.Margin = new System.Windows.Forms.Padding(4);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(121, 42);
            this.EditEvent.TabIndex = 16;
            this.EditEvent.Text = "Edit Evento";
            this.EditEvent.UseVisualStyleBackColor = true;
            this.EditEvent.Click += new System.EventHandler(this.EditEvent_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1387, 636);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(121, 42);
            this.Update.TabIndex = 17;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // deleteEvento
            // 
            this.deleteEvento.Location = new System.Drawing.Point(1038, 637);
            this.deleteEvento.Name = "deleteEvento";
            this.deleteEvento.Size = new System.Drawing.Size(121, 41);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 629);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 49);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "filtros";
            this.groupBox1.UseWaitCursor = true;
            // 
            // stageManagerrb
            // 
            this.stageManagerrb.AutoSize = true;
            this.stageManagerrb.Location = new System.Drawing.Point(330, 21);
            this.stageManagerrb.Name = "stageManagerrb";
            this.stageManagerrb.Size = new System.Drawing.Size(124, 21);
            this.stageManagerrb.TabIndex = 3;
            this.stageManagerrb.TabStop = true;
            this.stageManagerrb.Text = "stage Manager";
            this.stageManagerrb.UseVisualStyleBackColor = true;
            this.stageManagerrb.UseWaitCursor = true;
            // 
            // promotorrb
            // 
            this.promotorrb.AutoSize = true;
            this.promotorrb.Location = new System.Drawing.Point(238, 21);
            this.promotorrb.Name = "promotorrb";
            this.promotorrb.Size = new System.Drawing.Size(86, 21);
            this.promotorrb.TabIndex = 2;
            this.promotorrb.TabStop = true;
            this.promotorrb.Text = "promotor";
            this.promotorrb.UseVisualStyleBackColor = true;
            this.promotorrb.UseWaitCursor = true;
            // 
            // namerb
            // 
            this.namerb.AutoSize = true;
            this.namerb.Location = new System.Drawing.Point(122, 21);
            this.namerb.Name = "namerb";
            this.namerb.Size = new System.Drawing.Size(64, 21);
            this.namerb.TabIndex = 1;
            this.namerb.TabStop = true;
            this.namerb.Text = "name";
            this.namerb.UseVisualStyleBackColor = true;
            this.namerb.UseWaitCursor = true;
            // 
            // idrb
            // 
            this.idrb.AutoSize = true;
            this.idrb.Location = new System.Drawing.Point(6, 21);
            this.idrb.Name = "idrb";
            this.idrb.Size = new System.Drawing.Size(40, 21);
            this.idrb.TabIndex = 0;
            this.idrb.TabStop = true;
            this.idrb.Text = "id";
            this.idrb.UseVisualStyleBackColor = true;
            this.idrb.UseWaitCursor = true;
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(607, 646);
            this.searchbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(312, 22);
            this.searchbar.TabIndex = 20;
            // 
            // datefim
            // 
            this.datefim.Location = new System.Drawing.Point(1292, 160);
            this.datefim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datefim.Name = "datefim";
            this.datefim.Size = new System.Drawing.Size(225, 22);
            this.datefim.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1290, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Data de Fim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1035, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "CC do promotor";
            // 
            // ccpromotor
            // 
            this.ccpromotor.Location = new System.Drawing.Point(1037, 335);
            this.ccpromotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccpromotor.Name = "ccpromotor";
            this.ccpromotor.Size = new System.Drawing.Size(225, 22);
            this.ccpromotor.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1291, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "CC do stage Manager";
            // 
            // ccstageManager
            // 
            this.ccstageManager.Location = new System.Drawing.Point(1293, 335);
            this.ccstageManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ccstageManager.Name = "ccstageManager";
            this.ccstageManager.Size = new System.Drawing.Size(225, 22);
            this.ccstageManager.TabIndex = 25;
            // 
            // dataproposta
            // 
            this.dataproposta.Location = new System.Drawing.Point(1037, 423);
            this.dataproposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataproposta.Name = "dataproposta";
            this.dataproposta.Size = new System.Drawing.Size(225, 22);
            this.dataproposta.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1035, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Data da proposta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 692);
            this.Controls.Add(this.dataproposta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ccstageManager);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ccpromotor);
            this.Controls.Add(this.datefim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}

