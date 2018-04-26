using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatureOfCSharp6.Processa {
	class Professor {
		private Pessoa pessoa_info;
		private string materia;

		public	Professor(){
			pessoa_info = new Pessoa();
		}

		public Pessoa Pessoa_Info { get { return this.pessoa_info; } set { this.pessoa_info = value; } }
		public string Materia { get { return this.materia; } set { this.materia = value; } }
	}
}
