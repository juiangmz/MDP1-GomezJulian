/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase3
{
	class Program
	{	
		public static void Main(string[] args)
		{	
			Pila pila = new Pila();
			//Ejercicio 6 ( y 14)
			//FabricaDeComparables: 1-Numeros / 2-Alumnos / 3-Profesores
			llenar(pila,2);
			//informar(pila,2);
			
			Comparable profesor = FabricaDeComparables.crearAleatorio(3);
			Iterador iterador = pila.crearIterador();
			while (!iterador.fin()) {
				((Profesor)profesor).agregarObservador((Observador)iterador.actual());
				iterador.siguiente();
			}
			dictadoDeClases((Profesor)profesor);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		//EJERCICIO 6
		public static void llenar(Coleccionable c, int opcion){
			for(int i=0;i<20;i++){
				Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
				c.agregar(comparable);
			}
		}
		public static void informar(Coleccionable c, int opcion){
			Console.WriteLine(c.cuantos());
			Console.WriteLine(c.minimo());
			Console.WriteLine(c.maximo());
			Console.WriteLine("Ingresar datos a buscar");
			Comparable ingresado = FabricaDeComparables.crearPorTeclado(opcion);
			if(c.contiene(ingresado)){
				Console.WriteLine("El elemento leído está en la colección");
			}else{
				Console.WriteLine("El elemento leído no está en la colección");
			}
		}
		/*
		public static void llenarAlumnos(Coleccionable c){
			string[] nombres = new string[]{"Aguirre","Baez","Costas","Dominguez","Estevez","Fernandez","Gomez","Herrera","Islas","Jauretche"};
			for(int i=0; i<20;i++){
				string nombre = nombres[random.Next(nombres.Length)];
				Comparable comparable = new Alumno(nombre,random.Next(10000000,99999999),random.Next(10000),Math.Round(random.NextDouble()*10,1));
				c.agregar(comparable);
			}
		}*/

		public static void imprimirElementos(Iterable coleccionable){
			Iterador iterador = coleccionable.crearIterador();
			while (!iterador.fin()) {
				Console.WriteLine(iterador.actual());
				iterador.siguiente();
			}
		}

		public static void cambiarEstrategia(Iterable coleccionable, EstrategiaDeComparacion estrategia){
			Iterador iterador = coleccionable.crearIterador();
			while (!iterador.fin()) {
				((Alumno)iterador.actual()).setEstrategia(estrategia);
				iterador.siguiente();
			}
		}
		
		//EJERCICIO 13
		public static void dictadoDeClases(Profesor p){
			for(int i=0; i<5;i++){
				p.hablarALaClase();
				p.escribirEnElPizarron();
			}
		}
	}
}