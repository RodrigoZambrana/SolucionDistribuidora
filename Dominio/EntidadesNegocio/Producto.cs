using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.EntidadesNegocio
{
	public abstract class Producto
	{
		public int Codigo{ get; set; }

		public String Nombre{ get; set; }

		public decimal PrecioLista{ get; set; }

		public int Stock{ get; set; }

		public string NombreImagen{ get; set; }

		public Categoria MiCategoria { get; set; }

		public Proveedor MiProveedor { get; set; }

		public ICollection<Valoracion> MisValoraciones { get; set; }

		public bool ActualizarStock(int  cant)
		{
			return false;
		}

		public decimal CalcularMiValoracion()
		{
			return 0;
		}

		public abstract decimal RetornarPrecio();

	}

}

