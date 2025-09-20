/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase4
{
	class Program
	{	
		public static void Main(string[] args)
		{	
			//FabricaDeComparables: 1-Numeros / 2-Alumnos / 3-Profesores / 4-AlumnosMuyEstudios / 5-AlumnosDecorados / 6-AlumnosMuyEstudiososDecorados
			/*
			//EJERCICIO 4
			Teacher teacher = new Teacher();
			for(int i=0;i<10;i++){
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(2);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumno));
			}
			for(int i=0; i<10; i++){
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(4);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumno));
			}
			*/
			
			Teacher teacher = new Teacher();
			for(int i=0;i<10;i++){
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(5);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumno));
			}
			for(int i=0; i<10; i++){
				IAlumno alumnoMuyEstudioso = (IAlumno)FabricaDeComparables.crearAleatorio(6);
				alumnoMuyEstudioso.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumnoMuyEstudioso));
			}
			
			teacher.teachingAClass();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}