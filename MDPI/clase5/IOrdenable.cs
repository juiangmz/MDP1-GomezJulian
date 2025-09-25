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
	//EJERCICIO 8
	public interface IOrdenable
	{
		void setOrdenInicio(IOrdenEnAula1 orden);
		void setOrdenLlegaAlumno(IOrdenEnAula2 orden);
		void setOrdenAulaLlena(IOrdenEnAula1 orden);
	}
}
