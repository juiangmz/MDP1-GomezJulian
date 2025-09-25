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
	//EJERCICIO 3
	public class Aula
	{
		private Teacher teacher;
		public void comenzar(){
			this.teacher = new Teacher();
			Console.WriteLine("Comenzar la clase.");
		}
		public void nuevoAlumno(IAlumno alumno){
			teacher.goToClass(new AlumnoAdapter(alumno));
		}
		public void claseLista(){
			teacher.teachingAClass();
		}
	}
}
