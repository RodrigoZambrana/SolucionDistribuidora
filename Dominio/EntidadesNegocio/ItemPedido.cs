using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;

namespace Dominio.EntidadesNegocio
{
	public class ItemPedido
	{
		public int Cantidad{ get; set; }

		public decimal PrecioVenta{ get; set; }

		public Producto producto;

		public decimal CalcularTotal()
		{
			return 0;
		}

	}

}

