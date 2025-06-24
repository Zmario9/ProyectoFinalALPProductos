/*
 * Creado por SharpDevelop.
 * Usuario: Equipo
 * Fecha: 21/06/2025
 * Hora: 4:17 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ProyectoFinalALPProductos
{
	/// <summary>
	/// Description of Tasa.
	/// </summary>
	/// <summary>
	/// Description of Tasas.
	/// </summary>
	public class Tasas
	{

		public string Tipodetasa { get; private set; }
		protected double tasa;

		public double Tasa
		{
			get { return tasa; }
		}


		public Tasas(string tipo, double tasaInicial)
		{
			this.Tipodetasa = tipo;
//			this.Tasa = tasaInicial;
		}


		public void Depositar(double monto)
		{
			if (monto > 0)
			{
				tasa += monto;
			}
		}

		public override string ToString()
		{
			return string.Format("Tasa: ${2:N2}", tasa);
		}
	}
}
