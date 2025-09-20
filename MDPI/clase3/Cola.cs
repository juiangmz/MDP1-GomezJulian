/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace clase3
{
	public class Cola : Coleccionable, Iterable 	//Ejercicio 5
	{
		private List<Comparable> elementos;

		public Cola()
		{
			this.elementos = new List<Comparable>();
		}
		
		public int cuantos(){
			return this.elementos.Count;
		}
		
		public Comparable minimo(){
			Comparable masChico = this.elementos[0];
			for(int i=1; i<this.elementos.Count;i++){
				if(this.elementos[i].sosMenor(masChico)){
					masChico = this.elementos[i];
				}
			}
			return masChico;
		}
		
		public Comparable maximo(){
			Comparable masGrande = this.elementos[0];
			for(int i=1; i<this.elementos.Count;i++){
				if(this.elementos[i].sosMayor(masGrande)){
					masGrande = this.elementos[i];
				}
			}
			return masGrande;
		}
		
		public void agregar(Comparable c){
			elementos.Add(c);
		}
		
		public bool contiene(Comparable c){
			bool encontrado = false;
			for(int i=0; i<this.elementos.Count;i++){
				if(this.elementos[i].sosIgual(c)){
					encontrado = true;
					break;
				}
			}
			return encontrado;
		}
		
		public List<Comparable> GetElementos(){
			return this.elementos;
		}
		
		public Iterador crearIterador(){
			return new IteradorDeCola(this.elementos);
		}
	}
}
