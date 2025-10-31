/*
 * Created by SharpDevelop.
 * Julian E. Gomez
 * Comision: 1
 * UNAJ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace clase7
{

	public class GeneradorDeDatosAleatorios
	{	
		private static GeneradorDeDatosAleatorios unicaInstancia = null;
		static Random random;
		private GeneradorDeDatosAleatorios(){
			random = new Random();
		}
		public int numeroAleatorio(int max){
			return random.Next(0,max);
		}
		
		public string stringAleatorio(int cant){
			const string alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
			StringBuilder token = new StringBuilder();
			for(int i=0; i<cant; i++){
				int indice = random.Next(alfabeto.Length);
				token.Append(alfabeto[indice]);
			}
			return token.ToString();
		}
		
		public static GeneradorDeDatosAleatorios getInstancia(){
			if(unicaInstancia == null){
				unicaInstancia = new GeneradorDeDatosAleatorios();
			}
			return unicaInstancia;
		}
	}
}
