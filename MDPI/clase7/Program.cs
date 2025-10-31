/*
 * Created by SharpDevelop.
 * User: julianegomez
 * Date: 27/10/2025
 * Time: 19:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase7
{
	class Program
	{
		public static void Main(string[] args)
		{
			//FabricaDeComparables: 1-Numeros / 2-Alumnos / 3-Profesores / 4-AlumnosMuyEstudios / 5-AlumnosDecorados / 6-AlumnosMuyEstudiososDecorados
			
			//EJERCICIO 3
			Teacher teacher = new Teacher();
			//5 Alumnos Aleatorios
			
			for(int i=0;i<5;i++){
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(5);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumno));
			}
			
			//2 AlumnosMuyEstudiosos Por Teclado
			for(int i=0;i<2;i++){
				Console.WriteLine("Ingresar Nombre, DNI, Legajo y Promedio del Alumno:\n");
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearPorTeclado(6);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumno));
			}
			
			//5 Alumnos Compuestos
			
			IAlumno alumnoCompuesto = (IAlumno)FabricaDeComparables.crearPorArchivo(7);
			for(int i=0;i<5;i++){
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearPorArchivo(5);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				((AlumnoCompuesto)alumnoCompuesto).agregarHijo(alumno);
			}
			
			teacher.goToClass(new AlumnoAdapter(alumnoCompuesto));
			teacher.teachingAClass();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}