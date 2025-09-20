/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase2
{
	class Program
	{
		static Random random = new Random();
		
		public static void Main(string[] args)
		{
			//Ejercicio 7
			/*
			Pila pila = new Pila();
			Cola cola = new Cola();
			Conjunto conjunto = new Conjunto();
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			llenarAlumnos(conjunto);
			imprimirElementos(pila);
			imprimirElementos(cola);
			imprimirElementos(conjunto);
			*/
			
			//Ejercicio 9
			Pila pila = new Pila();
			llenarAlumnos(pila);
			Console.WriteLine("\nEstrategia de comparacion por Legajo");
			cambiarEstrategia(pila, new EstrategiaPorLegajo());
			informar(pila);
			Console.WriteLine("\nEstrategia de comparacion por Dni");
			cambiarEstrategia(pila, new EstrategiaPorDni());
			informar(pila);
			Console.WriteLine("\nEstrategia de comparacion por Nombre");
			cambiarEstrategia(pila, new EstrategiaPorNombre());
			informar(pila);
			Console.WriteLine("\nEstrategia de comparacion por Promedio");
			cambiarEstrategia(pila, new EstrategiaPorPromedio());
			informar(pila);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		public static void llenar(Coleccionable c){
			for(int i=0;i<20;i++){
				Comparable comparable = new Numero(random.Next());
				c.agregar(comparable);
			}
		}
		
		public static void informar(Coleccionable c){
			Console.WriteLine(c.cuantos());
			Console.WriteLine(((Alumno)c.minimo()).getPromedio());
			Console.WriteLine(((Alumno)c.maximo()).getPromedio());
			Comparable ingresado = new Alumno("Ingresado",12345678,12345,5.0);
			if(c.contiene(ingresado)){
				Console.WriteLine("El elemento leído está en la colección");
			}else{
				Console.WriteLine("El elemento leído no está en la colección");
			}
		}

		public static void llenarAlumnos(Coleccionable c){
			string[] nombres = new string[]{"Aguirre","Baez","Costas","Dominguez","Estevez","Fernandez","Gomez","Herrera","Islas","Jauretche"};
			for(int i=0; i<20;i++){
				string nombre = nombres[random.Next(nombres.Length)];
				Comparable comparable = new Alumno(nombre,random.Next(10000000,99999999),random.Next(10000),Math.Round(random.NextDouble()*10,1));
				c.agregar(comparable);
			}
		}
		///PRACTICA 2
		//Ejercicio 6
		public static void imprimirElementos(Iterable coleccionable){
			Iterador iterador = coleccionable.crearIterador();
			while (!iterador.fin()) {
				Console.WriteLine(iterador.actual());
				iterador.siguiente();
			}
		}
		//Ejercicio 8
		public static void cambiarEstrategia(Iterable coleccionable, EstrategiaDeComparacion estrategia){
			Iterador iterador = coleccionable.crearIterador();
			while (!iterador.fin()) {
				((Alumno)iterador.actual()).setEstrategia(estrategia);
				iterador.siguiente();
			}
		}
	}
}