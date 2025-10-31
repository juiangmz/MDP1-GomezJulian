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

	public class DecoradoConAsteriscos : AlumnoDecorator
	{
		public DecoradoConAsteriscos(IAlumno a):base(a)
		{
		}
		public override string mostrarCalificacion()
		{
			string stringBase = this.adicional.mostrarCalificacion(); 
			int asteriscos = stringBase.Length;
			string stringAsteriscos = "*********";
			for(int i=0;i<asteriscos;i++){
				stringAsteriscos += "*";
			}
			return stringAsteriscos+"\n*"+this.adicional.mostrarCalificacion()+"*\n"+stringAsteriscos;
		}
	}
}
