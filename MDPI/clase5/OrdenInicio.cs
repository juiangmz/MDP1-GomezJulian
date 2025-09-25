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
	//EJERCICIO 5
	public class OrdenInicio : IOrdenEnAula1
	{
		private Aula aula;
		public OrdenInicio(Aula a)
		{
			this.aula = a;
		}
		public void ejecutar(){
			this.aula.comenzar();
		}
	}
}
