// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XML
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnBuscar { get; set; }

		[Outlet]
		UIKit.UIButton btnGuardar { get; set; }

		[Outlet]
		UIKit.UITextField txtCorreo { get; set; }

		[Outlet]
		UIKit.UITextField txtEdad { get; set; }

		[Outlet]
		UIKit.UITextField txtFolio { get; set; }

		[Outlet]
		UIKit.UITextField txtNombre { get; set; }

		[Outlet]
		UIKit.UITextField txtSaldo { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnBuscar != null) {
				btnBuscar.Dispose ();
				btnBuscar = null;
			}

			if (btnGuardar != null) {
				btnGuardar.Dispose ();
				btnGuardar = null;
			}

			if (txtCorreo != null) {
				txtCorreo.Dispose ();
				txtCorreo = null;
			}

			if (txtNombre != null) {
				txtNombre.Dispose ();
				txtNombre = null;
			}

			if (txtEdad != null) {
				txtEdad.Dispose ();
				txtEdad = null;
			}

			if (txtFolio != null) {
				txtFolio.Dispose ();
				txtFolio = null;
			}

			if (txtSaldo != null) {
				txtSaldo.Dispose ();
				txtSaldo = null;
			}
		}
	}
}
