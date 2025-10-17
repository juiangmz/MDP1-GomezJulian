/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase6
{
	class Program
	{	
		public static void Main(string[] args)
		{	
			//FabricaDeComparables: 1-Numeros / 2-Alumnos / 3-Profesores / 4-AlumnosMuyEstudios / 5-AlumnosDecorados / 6-AlumnosMuyEstudiososDecorados
			/*
			//EJERCICIO 2
			Teacher teacher = new Teacher();
			IAlumno alumnoCompuesto = (IAlumno)FabricaDeComparables.crearAleatorio(7);
			for(int i=0;i<5;i++){
				//IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(5);
				GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
				IAlumno alumnoProxy = new AlumnoProxy(generador.stringAleatorio(8),6);
				alumnoProxy.setEstrategia(new EstrategiaPorCalificacion());
				((AlumnoCompuesto)alumnoCompuesto).agregarHijo(alumnoProxy);
			}
			teacher.goToClass(new AlumnoAdapter(alumnoCompuesto));
			teacher.teachingAClass();
			*/
			
			//Ejercicio 5
			Jugador jugador1 = (Jugador)FabricaDeComparables.crearAleatorio(8);
			Jugador jugador2 = (Jugador)FabricaDeComparables.crearAleatorio(8);
			
			//JuegoGuerra guerra = new JuegoGuerra(jugador1,jugador2);
			//guerra.jugar();

			JuegoTruco truco = new JuegoTruco(jugador1,jugador2);
			truco.jugar();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
	}
}