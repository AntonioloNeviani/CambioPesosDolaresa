using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	
	protected void OnButton1Clicked (object sender, System.EventArgs e)
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
				MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.None,"Hey no convierto: "+ usd);
				md.Show();
			}else{
				MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.None,"Tu resultado en Dolares es: $"+ usd);
				md.Show();
			}

			//Mostrar Resultados

			txtUSD.Text = usd.ToString();
			
		// Cacha la Exception
		
		}catch(Exception h)
			{
				MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.None,"No Acepto campos vacios, ni letras, ni simbolos raros\n\n"+
			                "Exception: " + h.Message);md.Show();
			}
	}

	protected void OnButton2Clicked (object sender, System.EventArgs e)
	{
		//Variables
		
        double usd = 0, mxn = 0, cam = 0.087;
		
        //Resetear Casillas al valor propuesto
        
        txtUSD.Text = usd.ToString();
		txtMXN.Text = mxn.ToString();
		txtCam.Text = cam.ToString();
	}

	protected void OnButton3Clicked (object sender, System.EventArgs e)
	{
        //MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.None,"Nos vemos, bye :)");
        //md.Show();
		Application.Quit ();
	}
}
