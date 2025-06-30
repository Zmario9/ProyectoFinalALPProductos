/*
 * Creado por SharpDevelop.
 * Usuario: Equipo
 * Fecha: 21/06/2025
 * Hora: 2:35 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;

namespace ProyectoFinalALPProductos
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{
		[DisplayName("Nombre del Producto")]
		public string Nombre{get; set;}
		public decimal CostoBase{get; set;}
		[DisplayName("Precio de venta (Bs.)")]
		public decimal Costo{get; set;}
		[DisplayName("Categoría")]
		public string SubClasificación{get; set;}
		[DisplayName("Precio ($)")]
		public decimal PrecioCambio{get; set;}
		[DisplayName("¿Disponible?")]
		public string Disponible{get; set;}
		public int PorcentajeAplicado{get; set;}
		
		public Producto(string nombre, decimal costoBase, decimal costo, string subclasificacion, decimal precioCambio, bool disponible, int porcentajeAplicado)
		{
			Nombre = nombre;
			CostoBase = costoBase;
			Costo = costo;
			SubClasificación = subclasificacion;
			PrecioCambio = precioCambio;
			PorcentajeAplicado = porcentajeAplicado;
			if (disponible){
				Disponible = "Si";
				return;
			}
			Disponible = "No disponible";
		}
		
		public override string ToString()
		{
			return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", Nombre, CostoBase, Costo, SubClasificación, PrecioCambio, Disponible, PorcentajeAplicado);
		}
		
		public static Producto FromString(string linea)
		{
			// Dividir la línea usando el mismo delimitador '|'
			string[] partes = linea.Split('|');

			// Asegurarse de que tenemos la cantidad esperada de partes
			if (partes.Length == 7)
			{
				string nombre = partes[0];
				decimal costobase = decimal.Parse(partes[1]);
				decimal costo = decimal.Parse(partes[2]);
				string subclasificacion = partes[3];
				decimal precioCambio = decimal.Parse(partes[4]);
				bool disponible = partes[5] == "Si" ? true : false;
				int porcentajeAplicado = int.Parse(partes[6]);
				return new Producto(nombre, costobase, costo, subclasificacion, precioCambio, disponible, porcentajeAplicado);
			}
			else
			{
				// Si el formato no es el esperado, lanza una excepción
				throw new FormatException("La línea del archivo no tiene el formato esperado: "+linea);
			}
		}
	}
}
