/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{

	public class DecoradoConPromocion : AlumnoDecorator
	{
		public DecoradoConPromocion(IAlumno a):base(a)
		{
		}
		public override string mostrarCalificacion()
		{
			string stringBase = this.adicional.mostrarCalificacion();
			string prom;
			int cal = this.adicional.getCalificacion();
			if(cal < 4){
				prom = "(DESAPROBADO)";
			}else if(cal >=4 && cal < 7){
				prom = "(APROBADO)";
			}else{
				prom = "(PROMOCIÓN)";
			}
			return stringBase+prom;
		}
	}
}
