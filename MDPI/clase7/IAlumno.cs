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

	public interface IAlumno : Comparable
	{
		string getNombre();
		void setNombre(string nombre);
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
