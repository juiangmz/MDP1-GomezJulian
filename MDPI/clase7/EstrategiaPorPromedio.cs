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

	public class EstrategiaPorPromedio : EstrategiaDeComparacion
	{
		public bool sosMenor(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getPromedio() < ((IAlumno)a2).getPromedio();
		}
		public bool sosMayor(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getPromedio() > ((IAlumno)a2).getPromedio();
		}
		public bool sosIgual(Comparable a1, Comparable a2){
			return ((IAlumno)a1).getPromedio() == ((IAlumno)a2).getPromedio();
		}
	}
}
