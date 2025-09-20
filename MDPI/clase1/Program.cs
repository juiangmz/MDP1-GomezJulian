/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace clase1
{
	class Program
	{
		static Random random = new Random();
		
		public static void Main(string[] args)
		{
			/*
			//Ejercicio 7
			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila,cola); //Ejercicio 9
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);
			informar(multiple); //Ejercicio 9
			*/
			
			//Ejercicio 14
			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila,cola);
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			informar(multiple);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		//Ejercicio 5
		public static void llenar(Coleccionable c){
			for(int i=0;i<20;i++){
				Comparable comparable = new Numero(random.Next());
				c.agregar(comparable);
			}
		}
		/*
		//Ejercicio 6
		public static void informar(Coleccionable c){
			Console.WriteLine(c.cuantos());
			Console.WriteLine(((Numero)c.minimo()).getValor());
			Console.WriteLine(((Numero)c.maximo()).getValor());
			Comparable ingresado = new Numero(int.Parse(Console.ReadLine()));
			if(c.contiene(ingresado)){
				Console.WriteLine("El elemento leído está en la colección");
			}else{
				Console.WriteLine("El elemento leído no está en la colección");
			}
		}
		*/
		
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
		//Ejercicio 13
		public static void llenarAlumnos(Coleccionable c){
			string[] nombres = new string[]{"Aguirre","Baez","Costas","Dominguez","Estevez","Fernandez","Gomez","Herrera","Islas","Jauretche"};
			for(int i=0; i<20;i++){
				string nombre = nombres[random.Next(nombres.Length)];
				Comparable comparable = new Alumno(nombre,random.Next(10000000,99999999),random.Next(10000),Math.Round(random.NextDouble()*10,1));
				c.agregar(comparable);
			}
		}
	}
}