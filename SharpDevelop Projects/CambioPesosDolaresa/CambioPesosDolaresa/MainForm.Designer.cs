/*
 * Creado por SharpDevelop.
 * Usuario: Jorge Antonio
 * Fecha: 29/10/2013
 * Hora: 12:07 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CambioPesosDolaresa
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMXN = new System.Windows.Forms.TextBox();
			this.txtCam = new System.Windows.Forms.TextBox();
			this.txtUSD = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cambio de Pesos a Dolares";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(28, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Pesos:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(148, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tipo de Cambio:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(28, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Dolares:";
			// 
			// txtMXN
			// 
			this.txtMXN.Location = new System.Drawing.Point(28, 58);
			this.txtMXN.Name = "txtMXN";
			this.txtMXN.Size = new System.Drawing.Size(100, 20);
			this.txtMXN.TabIndex = 4;
			this.txtMXN.Text = "0";
			// 
			// txtCam
			// 
			this.txtCam.Location = new System.Drawing.Point(148, 58);
			this.txtCam.Name = "txtCam";
			this.txtCam.Size = new System.Drawing.Size(100, 20);
			this.txtCam.TabIndex = 5;
			this.txtCam.Text = "10.5";
			// 
			// txtUSD
			// 
			this.txtUSD.Enabled = false;
			this.txtUSD.Location = new System.Drawing.Point(28, 99);
			this.txtUSD.Name = "txtUSD";
			this.txtUSD.Size = new System.Drawing.Size(100, 20);
			this.txtUSD.TabIndex = 6;
			this.txtUSD.Text = "0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(148, 99);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Convertir ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(28, 135);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(148, 135);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 23);
			this.button3.TabIndex = 9;
			this.button3.Text = "Salir";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 188);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtUSD);
			this.Controls.Add(this.txtCam);
			this.Controls.Add(this.txtMXN);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "CambioPesosDolaresa :D";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtUSD;
		private System.Windows.Forms.TextBox txtCam;
		private System.Windows.Forms.TextBox txtMXN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
