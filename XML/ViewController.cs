using System;
using System.Xml.Serialization;
using System.IO;

using UIKit;

namespace XML
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			btnGuardar.TouchUpInside +=delegate {

				try
				{
					var DC = new Datos();

					DC.Folio = int.Parse(txtFolio.Text);
					DC.Nombre = txtNombre.Text;
					DC.Correo = txtCorreo.Text;
					DC.Saldo = int.Parse(txtSaldo.Text);
					DC.Edad = int.Parse(txtEdad.Text);

					var serializador = new XmlSerializer(typeof(Datos));
					var Escritura = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), txtFolio.Text + ".xml"));
					serializador.Serialize(Escritura, DC);
					Escritura.Close();
					txtFolio.Text = "";
					txtNombre.Text = "";
					txtSaldo.Text="";
					txtCorreo.Text = "";
					txtEdad.Text = "";
					MessageBox("Archivo XML", "Guardado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox("Error:", ex.Message);

				}
			};

			btnBuscar.TouchUpInside+=delegate {
				
				try
				{
					var DC = new Datos();
					DC.Folio = int.Parse(txtFolio.Text);
					var serializador = new XmlSerializer(typeof(Datos));
					var lectura = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
															   txtFolio.Text + ".xml"));
					var datos = (Datos)serializador.Deserialize(lectura);
					lectura.Close();
					txtNombre.Text = datos.Nombre;
					txtCorreo.Text = datos.Correo;
					txtEdad.Text = datos.Edad.ToString();
					txtSaldo.Text = datos.Saldo.ToString();

				}
				catch (Exception ex)
				{
					MessageBox("Error:", ex.Message);

				}
			};

			this.txtEdad.ShouldReturn += (textField) => {
			textField.ResignFirstResponder();
			return true;
			};

			this.txtSaldo.ShouldReturn += (textField) => {
			textField.ResignFirstResponder();
			return true;
			};

			this.txtFolio.ShouldReturn += (textField) => {
			textField.ResignFirstResponder();
			return true;
			};

			this.txtNombre.ShouldReturn += (textField) => {
			textField.ResignFirstResponder();
			return true;
			};

			this.txtCorreo.ShouldReturn += (textField) => {
			textField.ResignFirstResponder();
			return true;
					};
		}

		public void MessageBox(string titulo, string mensage)
		{

			using (UIAlertView alerta = new UIAlertView())
			{
				alerta.Title = titulo;
				alerta.Message = mensage;
				alerta.AddButton("Aceptar");
				alerta.Show();
			}
		}

		public class Datos
		{
			public int Folio;
			public string Nombre;
			public string Correo;
			public int Edad;
			public double Saldo;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
