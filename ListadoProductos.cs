/*
 * Creado por SharpDevelop.
 * Usuario: Equipo
 * Fecha: 21/06/2025
 * Hora: 2:34 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace ProyectoFinalALPProductos
{
	/// <summary>
	/// Description of ListadoProductos.
	/// </summary>
	public class ListadoProductos
	{
		private List<Producto> BDProductos;
		public ListadoProductos()
		{
			BDProductos = new List<Producto>();
		}
		
		public bool AgregarProductoALaLista(string nombre, decimal costobase, decimal precioSubTotal, string subclasificacion, decimal precioDolar, bool disponible, decimal tasaBCV){
			foreach(Producto p in BDProductos){
				if(VerificacionDeDatos.VerificacionPorNombre(nombre, p)) return false;
			}
			Producto newProducto = new Producto(nombre, costobase, precioSubTotal, subclasificacion, precioDolar, disponible);
			
			BDProductos.Add(newProducto);
			return true;
		}
		
		public bool EliminarProductoDeLaLista(string nombre){
			foreach(Producto p in BDProductos){
				if(nombre == p.Nombre){
					BDProductos.Remove(p);
					return true;
				}
			}
			return false;
		}
		
		public List<Producto> ObtenerProductosDeLaLista(){
			return BDProductos;
		}
		
		public Producto buscarProductoDeLaLista(string nombre){
			foreach(Producto p in BDProductos){
				if(nombre == p.Nombre) {
					return p;
				}
			}
			return null;
		}
		
//		public bool productoExisteEnLaListA(string nombre){
//			foreach(Producto p in BDProductos){
//				if(nombre == p.Nombre) {
//					return true;
//				}
//			}
//			return false;
//		}
		
//		public bool ModificarDatosDeProducto(Producto productoAModificar, string nombre, decimal costoBase, decimal precioCambio, bool disponible){
//			
//		}
	}
}
