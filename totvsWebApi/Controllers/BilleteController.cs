using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace totvsWebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BilleteController : ControllerBase
    {
        [HttpPost]
        public string Post([FromBody]Entrada valor)
        {
            try
            {
				int C100, C50, C20, C10, D50, D10, D05, D01;
				C100 = 0;
				C50 = 0;
				C20 = 0;
				C10 = 0;
				D50 = 0;
				D10 = 0;
				D05 = 0;
				D01 = 0;
				string salida = "Entregar ";

				var CAN = float.Parse(valor.Key);

				if ((CAN >= 100))
				{
					C100 = ((int)CAN / 100);
					CAN = CAN - (C100 * 100);
					salida += string.Format("{0} notas de R$100 ||", C100);
				}
				if ((CAN >= 50))
				{
					C50 = ((int)CAN / 50);
					CAN = CAN - (C50 * 50);
					salida += string.Format("{0} notas de R$50 ||", C50);

				}
				if ((CAN >= 20))
				{
					C20 = ((int)CAN / 20);
					CAN = CAN - (C20 * 20);
					salida += string.Format("{0} notas de R$20 ||", C20);

				}
				if ((CAN >= 10))
				{
					C10 = ((int)CAN / 10);
					CAN = CAN - (C10 * 10);
					salida += string.Format("{0} notas de R$10 ||", C10);

				}
				if ((CAN >= 0.5))
				{
					D50 = (int)(CAN / 0.5);
					CAN = CAN - (float)(D50 * 0.5);
					salida += string.Format("{0} notas de R$0.50 ||", D50);

				}
				if ((CAN >= 0.1))
				{
					D10 = (int)(CAN / 0.1);
					CAN = CAN - (float)(D10 * 0.1);
					salida += string.Format("{0} notas de R$0.10 ||", D10);

				}
				if ((CAN >= 0.05))
				{
					D05 = (int)(CAN / 0.05);
					CAN = CAN - (float)(D05 * 0.05);
					salida += string.Format("{0} notas de R$0.05 ||", D05);

				}
				if ((CAN >= 0.01))
				{
					D01 = (int)Math.Round(CAN / 0.01);
					CAN = CAN - (float)(D01 * 0.01);
					salida += string.Format("{0} notas de R$0.01 ||", D01);

				}
				return salida;

			}
            
            catch (Exception)
            {
                return "El dato ingresado es incorrecto";
            }
        }
    }
	public class Entrada
	{
		public string Key { get; set; }
	}
}
