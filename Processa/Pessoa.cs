using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatureOfCSharp6.Processa {
	class Pessoa {
		private string nome;
		private char sexo;

		public string Nome { get { return this.nome; } set { this.nome = value; } }
		public char Sexo { get { return this.sexo; } set { this.sexo = value; } }
	}
}
