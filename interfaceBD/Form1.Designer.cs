
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eventos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(746, 459);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 519);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(745, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
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
            this.numdias.Size = new System.Drawing.Size(155, 20);
            this.numdias.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(982, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero de bilhetes";
            // 
            // numbilhetes
            // 
            this.numbilhetes.Location = new System.Drawing.Point(984, 202);
            this.numbilhetes.Margin = new System.Windows.Forms.Padding(2);
            this.numbilhetes.Name = "numbilhetes";
            this.numbilhetes.Size = new System.Drawing.Size(155, 20);
            this.numbilhetes.TabIndex = 9;
            // 
            // datainicio
            // 
            this.datainicio.Location = new System.Drawing.Point(778, 130);
            this.datainicio.Margin = new System.Windows.Forms.Padding(2);
            this.datainicio.Name = "datainicio";
            this.datainicio.Size = new System.Drawing.Size(360, 20);
            this.datainicio.TabIndex = 11;
            // 
            // adicionarEvento
            // 
            this.adicionarEvento.Location = new System.Drawing.Point(1044, 519);
            this.adicionarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.adicionarEvento.Name = "adicionarEvento";
            this.adicionarEvento.Size = new System.Drawing.Size(94, 33);
            this.adicionarEvento.TabIndex = 12;
            this.adicionarEvento.Text = "Add Evento";
            this.adicionarEvento.UseVisualStyleBackColor = true;
            this.adicionarEvento.Click += new System.EventHandler(this.adicionarEvento_Click);
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(1043, 518);
            this.adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(94, 35);
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
            this.EditEvent.Location = new System.Drawing.Point(903, 518);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(91, 34);
            this.EditEvent.TabIndex = 16;
            this.EditEvent.Text = "Edit Evento";
            this.EditEvent.UseVisualStyleBackColor = true;
            this.EditEvent.Click += new System.EventHandler(this.EditEvent_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1044, 518);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(91, 35);
            this.Update.TabIndex = 17;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 562);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

