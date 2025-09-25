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
namespace clase5
{
	public class Cola : Coleccionable, Iterable, IOrdenable	//Ejercicio 9
	{
		private List<Comparable> elementos;
		private IOrdenEnAula1 ordenInicio, ordenAulaLlena;		
		private IOrdenEnAula2 ordenLlegaAlumno;
		
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
		
		//EJERCICIO 9
		public void encolar(Comparable c){
			elementos.Add(c);
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
		
		public Comparable desencolar(){
			Comparable c = this.elementos[0];
			this.elementos.RemoveAt(0);
			return c;
		}
		
		public void agregar(Comparable c){
			this.encolar(c);
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
		//EJERCICIO 9
		public void setOrdenInicio(IOrdenEnAula1 orden){
			this.ordenInicio = orden;
		}
		public void setOrdenLlegaAlumno(IOrdenEnAula2 orden){
			this.ordenLlegaAlumno = orden;
		}
		public void setOrdenAulaLlena(IOrdenEnAula1 orden){
			this.ordenAulaLlena = orden;
		}
	}
}
