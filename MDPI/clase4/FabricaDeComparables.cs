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
	//EJERCICIO 4
	public abstract class FabricaDeComparables
	{
		protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lector = new LectorDeDatos();
		
		public static Comparable crearAleatorio(int opcion){
			FabricaDeComparables fabrica = null;
			switch (opcion) {
				case 1:
					fabrica = new FabricaDeNumeros();
					break;
				case 2:
					fabrica = new FabricaDeAlumnos();
					break;
				case 3:
					fabrica = new FabricaDeProfesores();
					break;
				case 4:
					fabrica = new FabricaDeAlumnosMuyEstudiosos();
					break;
				case 5:
					fabrica = new FabricaDeAlumnosDecorados();
					break;
				case 6:
					fabrica = new FabricaDeAlumnoMuyEstudiosoDecorado();
					break;
			}
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica = null;
			switch (opcion) {
				case 1:
					fabrica = new FabricaDeNumeros();
					break;
				case 2:
					fabrica = new FabricaDeAlumnos();
					break;
				case 3:
					fabrica = new FabricaDeProfesores();
					break;
				case 4:
					fabrica = new FabricaDeAlumnosMuyEstudiosos();
					break;
				case 5:
					fabrica = new FabricaDeAlumnosDecorados();
					break;
			}
			return fabrica.crearPorTeclado();
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
	}
}
