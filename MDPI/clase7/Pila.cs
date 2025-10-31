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

namespace clase7
{

	public class Pila : Coleccionable, Iterable, IOrdenable 	//Ejercicio 9
	{
		private List<Comparable> elementos;
		private IOrdenEnAula1 ordenInicio, ordenAulaLlena;		
		private IOrdenEnAula2 ordenLlegaAlumno;
		
		public Pila()
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
			if(this.elementos.Count == 0){
        		return null;
			}
			Comparable masGrande = this.elementos[0];
			for(int i=1; i<this.elementos.Count;i++){
				if(this.elementos[i].sosMayor(masGrande)){
					masGrande = this.elementos[i];
				}
			}
			return masGrande;
		}
		
		//EJERCICIO 9
		public void apilar(Comparable c){
			this.elementos.Add(c);
			if(this.elementos.Count == 1 && this.ordenInicio != null){
				this.ordenInicio.ejecutar();
			}
			if(this.ordenLlegaAlumno != null){
				this.ordenLlegaAlumno.ejecutar(c);
			}
			if(this.elementos.Count == 40 && this.ordenAulaLlena != null){
				this.ordenAulaLlena.ejecutar();
			}
		}
		
		public Comparable desapilar(){
			Comparable c = this.elementos[this.elementos.Count - 1];
			this.elementos.RemoveAt(this.elementos.Count -1);
			return c;
		}
		
		public void agregar(Comparable c){
			this.apilar(c);
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
			return new IteradorDePila(this.elementos);
		}
		//EJERCICIO 9
		public void setOrdenInicio(IOrdenEnAula1 e){
			this.ordenInicio = e;
		}
		public void setOrdenLlegaAlumno(IOrdenEnAula2 e){
			this.ordenLlegaAlumno = e;
		}
		public void setOrdenAulaLlena(IOrdenEnAula1 e){
			this.ordenAulaLlena = e;
		}
	}
}
