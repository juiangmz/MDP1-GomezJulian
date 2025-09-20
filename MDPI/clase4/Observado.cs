/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 11/9/2025
 * Time: 17:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase4
{
	//Ejercicio 12
	public interface Observado
	{
		void agregarObservador(Observador o);
		void quitarObservador(Observador o);
		void notificar();
	}
}
