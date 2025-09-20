/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 18/9/2025
 * Time: 15:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase4
{
	//EJERCICIO 3
	public interface IAlumno : Comparable
	{
		string getNombre();
		int getDni();
		int getLegajo();
		double getPromedio();
		int getCalificacion();
		void setCalificacion(int c);
		void setEstrategia(EstrategiaDeComparacion e);
		string ToString();
		void prestarAtencion();
		void distraerse();
		void actualizar(Observado o);
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
	}
}
