using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;

namespace Dominio.EntidadesNegocio
{
	public class ProductoNacional : Producto
	{
		public bool EcoAmigable{ get; set; }

		public long NumeroFabricante{ get; set; }

		public static decimal TasaBonificacion{ get; set; }

		public override decimal RetornarPrecio()
		{
			throw new NotImplementedException();
		}
	}

}

