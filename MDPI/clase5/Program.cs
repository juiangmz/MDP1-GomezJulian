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
	class Program
	{	
		public static void Main(string[] args)
		{	
			//FabricaDeComparables: 1-Numeros / 2-Alumnos / 3-Profesores / 4-AlumnosMuyEstudios / 5-AlumnosDecorados / 6-AlumnosMuyEstudiososDecorados
			/*
			//EJERCICIO 2
			Teacher teacher = new Teacher();
			for(int i=0;i<10;i++){
				//IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(5);
				GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
				IAlumno alumnoProxy = new AlumnoProxy(generador.stringAleatorio(8),5);
				alumnoProxy.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumnoProxy));
			}
			for(int i=0; i<10; i++){
				GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
				//IAlumno alumnoMuyEstudioso = (IAlumno)FabricaDeComparables.crearAleatorio(6);
				IAlumno alumnoMuyEstudiosoProxy = new AlumnoProxy(generador.stringAleatorio(8),6);
				alumnoMuyEstudiosoProxy.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumnoMuyEstudiosoProxy));
			}
			
			teacher.teachingAClass();
			*/
			//EJERCICIO 10
			Pila pila = new Pila();
			Aula aula = new Aula();
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			llenar(pila, 5);
			llenar(pila, 6);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//PRACTICA 3 EJERCICIO 6
		public static void llenar(Coleccionable c, int opcion){
			for(int i=0;i<20;i++){
				Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
				c.agregar(comparable);
			}
		}
	}
}