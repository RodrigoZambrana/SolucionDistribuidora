using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.EntidadesNegocio
{
	public class Pedido
	{
		public int Id{ get; set; }

		public DateTime Fecha{ get; set; }

		public decimal TasaIvaCobrada{ get; set; }

		public static decimal IvaActual{ get; set; }

		public ICollection<Producto> itemPedido;

		private Cliente cliente;

		public decimal CalcularTotal()
		{
			return 0;
		}

	}

}

