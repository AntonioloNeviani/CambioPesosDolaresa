/*
 * Creado por SharpDevelop.
 * Usuario: Jorge Antonio
 * Fecha: 29/10/2013
 * Hora: 12:07 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CambioPesosDolaresa
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Variables
            double usd, mxn, cam;
			
			try 
				{
				//Asignacion de valores
				
				cam = System.Double.Parse(txtCam.Text);
				mxn = System.Double.Parse(txtMXN.Text);

				//Calcular

				usd = mxn * cam;
				
				//Compara si es un 0
				
				if(usd == 0){
					MessageBox.Show("Hey no convierto: "+ usd);
				}else{
					MessageBox.Show("Tu resultado en Dolares es: "+ usd);
				}

				//Mostrar Resultados

				txtUSD.Text = usd.ToString();
				
			// Cacha la Exception
			
			}catch(Exception h)
				{
					MessageBox.Show("No Acepto campos vacios, ni letras, ni simbolos raros\n\n"+
				                "Exception: " + h.Message);
				}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//Variables
			
            double usd = 0, mxn = 0, cam = 0.087;
			
            //Resetear Casillas al valor propuesto
            
            txtUSD.Text = usd.ToString();
			txtMXN.Text = mxn.ToString();
			txtCam.Text = cam.ToString();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			//cerrar programa
            
            MessageBox.Show("Nos vemos, bye :)");
            Close();
		}
	}
}
