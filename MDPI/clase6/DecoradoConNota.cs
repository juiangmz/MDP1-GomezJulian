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
	//EJERCICIO 6
	public class DecoradoConNota : AlumnoDecorator
	{
		public DecoradoConNota(IAlumno a):base(a)
		{
		}
		
		public override string mostrarCalificacion()
		{
			string stringBase = this.adicional.mostrarCalificacion();
			string nota;
			int cal = this.adicional.getCalificacion();
			switch (cal) {
					case 0:nota="(CERO)";break;
					case 1:nota="(UNO)";break;
					case 2:nota="(DOS)";break;
					case 3:nota="(TRES)";break;
					case 4:nota="(CUATRO)";break;
					case 5:nota="(CINCO)";break;
					case 6:nota="(SEIS)";break;
					case 7:nota="(SIETE)";break;
					case 8:nota="(OCHO)";break;
					case 9:nota="(NUEVE)";break;
					case 10:nota="(DIEZ)";break;
					default:nota ="";
					break;
			}
			return stringBase+nota;
		}
	}
}
