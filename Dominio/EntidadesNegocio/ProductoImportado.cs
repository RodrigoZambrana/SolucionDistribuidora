using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.EntidadesNegocio;

namespace Dominio.EntidadesNegocio
{
	public class ProductoImportado : Producto
	{
		public string Pais{ get; set; }

		public static decimal ImpuestoImportacion{ get; set; }

		public override decimal RetornarPrecio()
		{
			throw new NotImplementedException();
		}
	}

}

