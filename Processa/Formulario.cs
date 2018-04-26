using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFeatureOfCSharp6.Processa {
	public partial class Formulario : Form {
		Usa teste = new Usa();
		public Formulario() {
			InitializeComponent();
		}

		private void Formulario_Load(object sender, EventArgs e) {
			txtNome.Text = teste.GetPersonInfo();
		}

		private void btnAtt_Click(object sender, EventArgs e) {
			teste.Professor.Pessoa_Info.Nome = "Gabriel";
			txtNome.Text = teste.GetPersonInfo();
		}
	}
}
