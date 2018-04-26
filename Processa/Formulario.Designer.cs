namespace NewFeatureOfCSharp6.Processa {
	partial class Formulario {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.txtNome = new System.Windows.Forms.Label();
			this.txtSexo = new System.Windows.Forms.Label();
			this.btnAtt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.AutoSize = true;
			this.txtNome.Location = new System.Drawing.Point(102, 148);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(35, 13);
			this.txtNome.TabIndex = 0;
			this.txtNome.Text = "label1";
			// 
			// txtSexo
			// 
			this.txtSexo.AutoSize = true;
			this.txtSexo.Location = new System.Drawing.Point(383, 219);
			this.txtSexo.Name = "txtSexo";
			this.txtSexo.Size = new System.Drawing.Size(35, 13);
			this.txtSexo.TabIndex = 1;
			this.txtSexo.Text = "label1";
			// 
			// btnAtt
			// 
			this.btnAtt.Location = new System.Drawing.Point(329, 82);
			this.btnAtt.Name = "btnAtt";
			this.btnAtt.Size = new System.Drawing.Size(75, 23);
			this.btnAtt.TabIndex = 2;
			this.btnAtt.Text = "button1";
			this.btnAtt.UseVisualStyleBackColor = true;
			this.btnAtt.Click += new System.EventHandler(this.btnAtt_Click);
			// 
			// Formulario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAtt);
			this.Controls.Add(this.txtSexo);
			this.Controls.Add(this.txtNome);
			this.Name = "Formulario";
			this.Text = "Formulario";
			this.Load += new System.EventHandler(this.Formulario_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtNome;
		private System.Windows.Forms.Label txtSexo;
		private System.Windows.Forms.Button btnAtt;
	}
}