/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase5
{
	//EJERCICIO 6
	public class DecoradoConLegajo : AlumnoDecorator
	{
		public DecoradoConLegajo(IAlumno a):base(a)
		{
		}
		public override string mostrarCalificacion()
		{
			string stringBase = this.adicional.mostrarCalificacion();
			string leg = (this.adicional.getLegajo()).ToString();
			string[] division = stringBase.Split('\t');
			division[0] = division[0]+" ("+leg+")";
			return string.Join("\t",division);
		}
	}
}
