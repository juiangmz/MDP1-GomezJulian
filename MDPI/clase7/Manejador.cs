/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 27/10/2025
 * Time: 20:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{

	public abstract class Manejador
	{
		protected Manejador sucesor = null;
		public Manejador(Manejador m)
		{
			this.sucesor = m;
		}
		
		public abstract int numeroAleatorio(int max);
		public abstract string stringAleatorio(int cant);
		public abstract int numeroPorTeclado();
		public abstract string stringPorTeclado();
		public abstract double numeroDesdeArchivo(double max);
		public abstract string stringDesdeArchivo(int cant);
	}
}
