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
		public decimal PrecioEnDolarConvertible{get; set;}
		public string Disponible{get; set;}
		
		public Producto(string nombre, decimal costo, string subclasificacion, decimal precioEnDolarConvertible, bool disponible)
		{
			Nombre = nombre;
			Costo = costo;
			SubClasificación = subclasificacion;
			if (disponible){
				Disponible = "Si";
				return;
			}
			PrecioEnDolarConvertible = precioEnDolarConvertible;
			Disponible = "No disponible";
			
		}
	}
}
