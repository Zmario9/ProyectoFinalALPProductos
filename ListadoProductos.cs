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
		
		public bool AgregarProductoALaLista(string nombre, decimal costobase, decimal precioSubTotal, string subclasificacion, decimal precioDolar, bool disponible, decimal tasaBCV, int porcentajeAplicado){
			foreach(Producto p in BDProductos){
				if(VerificacionDeDatos.VerificacionPorNombre(nombre, p)) return false;
			}
			Producto newProducto = new Producto(nombre, costobase, precioSubTotal, subclasificacion, precioDolar, disponible, porcentajeAplicado);
			
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
		
		public void modificarProductoDeInventario(Producto p, string nombre, decimal costo, decimal costobase, decimal preciocambio, string disponibilidad, string subclasificacion, int porcentajeaplicado){
			p.Nombre = nombre;
			p.Costo = costo;
			p.CostoBase =  costobase;
			p.PrecioCambio = preciocambio;
			p.Disponible = disponibilidad;
			p.SubClasificación = subclasificacion;
			p.PorcentajeAplicado = porcentajeaplicado;
		}
	}
}
