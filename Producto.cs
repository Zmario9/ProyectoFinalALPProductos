/*
 * Creado por SharpDevelop.
 * Usuario: Equipo
 * Fecha: 21/06/2025
 * Hora: 2:35 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ProyectoFinalALPProductos
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{
		public string Nombre{get; set;}
		public decimal Costo{get; set;}
		public string SubClasificación{get; set;}
		public decimal PrecioCambio{get; set;}
		public string Disponible{get; set;}
		
		public Producto(string nombre, decimal costo, string subclasificacion, decimal precioCambio, bool disponible)
		{
			Nombre = nombre;
			Costo = costo;
			SubClasificación = subclasificacion;
			PrecioCambio = precioCambio;
			if (disponible){
				Disponible = "Si";
				return;
			}
			Disponible = "No disponible";
		}
		
		public override string ToString()
		{
			return string.Format("{0}|{1}|{2}|{3}|{4}", Nombre, Costo, SubClasificación, PrecioCambio, Disponible);
		}
		
		public static Producto FromString(string linea)
		{
			// Dividir la línea usando el mismo delimitador '|'
			string[] partes = linea.Split('|');

			// Asegurarse de que tenemos la cantidad esperada de partes
			if (partes.Length == 5)
			{
				string nombre = partes[0];
				decimal costo = decimal.Parse(partes[1]);
				string subclasificacion = partes[2];
				decimal precioCambio = decimal.Parse(partes[3]);
				bool disponible = partes[4] == "Si" ? true : false;
				return new Producto(nombre, costo, subclasificacion, precioCambio, disponible);
			}
			else
			{
				// Si el formato no es el esperado, lanza una excepción
				throw new FormatException("La línea del archivo no tiene el formato esperado: "+linea);
			}
		}
	}
}
