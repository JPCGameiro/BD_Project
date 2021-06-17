using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceBD
{
    [Serializable()]
    class Concerto
    {
		private String _id;
		private String _nome;
		private String _id_evento;
		private String _banda;
		private String _id_banda;
		private String _dataini;
		private String _duracao;
        private String _id_scheck;

        public string Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Id_evento { get => _id_evento; set => _id_evento = value; }
        public string Banda { get => _banda; set => _banda = value; }
        public string Id_banda { get => _id_banda; set => _id_banda = value; }
        public string Dataini { get => _dataini; set => _dataini = value; }
        public string Duracao { get => _duracao; set => _duracao = value; }
        public string Id_scheck { get => _id_scheck; set => _id_scheck = value; }

        public override String ToString()
        {
            return String.Format("{0, -5}{1, -33}{2, -5}{3, -33}{4, -9}{5, -12}{6, -12}{7, -15}", Id, Nome, Id_evento, Banda, Id_banda, Dataini, Duracao, Id_scheck);
        }

        public static String Fline()
        {
            return String.Format("{0, -5}{1, -33}{2, -5}{3, -33}{4, -9}{5, -12}{6, -12}{7, -15}", "Id", "Evento", "Id", "Banda", "Id Banda", "Data Hora", "Duracao", "Id SoundCheck");
        }
    }
}
