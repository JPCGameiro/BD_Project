using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    [Serializable()]
    public class Evento
    {
		private String _id;
		private String _name;
		private String _numBilhetes;
		private String _numdias;
		private String _dataini;
		private String _datafim;
		private String _cc_promotor;
		private String _dataProposta;
		private String _cc_stageManager;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string NumBilhetes { get => _numBilhetes; set => _numBilhetes = value; }
        public string Numdias { get => _numdias; set => _numdias = value; }
        public string Dataini { get => _dataini; set => _dataini = value; }
        public string Datafim { get => _datafim; set => _datafim = value; }
        public string Cc_promotor { get => _cc_promotor; set => _cc_promotor = value; }
        public string DataProposta { get => _dataProposta; set => _dataProposta = value; }
        public string Cc_stageManager { get => _cc_stageManager; set => _cc_stageManager = value; }

        public override String ToString()
        {
            return _id + "\t" + _name + "\t" + _numBilhetes + "\t" + _numdias + "\t" + _dataini + "\t" + _datafim + "\t" + _cc_promotor + "\t" + _dataProposta + "\t" + _cc_stageManager;
        }
    }
}
