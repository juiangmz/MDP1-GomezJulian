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

	public class OrdenAulaLlena : IOrdenEnAula1
	{
		private Aula aula;
		public OrdenAulaLlena(Aula a)
		{
			this.aula = a;
		}
		public void ejecutar(){
			this.aula.claseLista();
		}
	}
}
