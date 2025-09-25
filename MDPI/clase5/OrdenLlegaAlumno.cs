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
	//EJERCICIO 7
	public class OrdenLlegaAlumno : IOrdenEnAula2
	{
		private Aula aula;
		public OrdenLlegaAlumno(Aula a)
		{
			this.aula = a;
		}
		
		public void ejecutar(Comparable c){
			this.aula.nuevoAlumno((IAlumno) c);
		}
	}
}
