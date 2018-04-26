using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatureOfCSharp6.Processa {
	class Usa {
		private Professor prof = new Professor();

		public Professor Professor { get { return this.prof; } set { this.prof = value; } }

		public string GetPersonInfo() {
			string nome = string.Empty;
			try {
				nome = prof?.Pessoa_Info?.Nome;
			}
			catch (Exception ex) {
				throw;
			}
			return nome;
		}
		
	}
}
