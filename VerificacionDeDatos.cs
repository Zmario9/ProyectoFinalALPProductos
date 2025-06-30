/*
 * Creado por SharpDevelop.
 * Usuario: Equipo
 * Fecha: 21/06/2025
 * Hora: 2:58 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinalALPProductos
{
	/// <summary>
	/// Description of VerificacionDeDatos.
	/// </summary>
	public static class VerificacionDeDatos
	{
		public static bool VerificacionPorNombre(string nombre, Producto producto)
		{
			if(nombre.ToLower() == producto.Nombre.ToLower()) return true;
			return false;
		}
		
		public static bool VerificarCategoria(int categoryText){
			if(categoryText == 0){
				return false;
			}
			return true;
		}
		public static bool VerificarEspaciosVaciosONoValidos(string text){
			if(!string.IsNullOrWhiteSpace(text)){
				return true;
			}
			return false;
		}
		
		public static bool VerificarNumero(string inputText){
			decimal numberText;
			if(!decimal.TryParse(inputText, out numberText) || numberText <= 0) return false;
			return true;
		}
		
		public static bool GuardarInventario(ListadoProductos baseDeDatos){
			try
			{
				string rutaArchivo = "INVENTARIO.txt";
				using (StreamWriter sw = new StreamWriter(rutaArchivo, false))
				{
					foreach (Producto p in baseDeDatos.ObtenerProductosDeLaLista())
					{
						sw.WriteLine(p.ToString());
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		
		public static string QuitarSigno(string precio){
            return precio.Replace("$","").Trim();//cuando quita el signo del $ retorna el precio sin el signo
        }
		
		public static bool CargarInventario(ListadoProductos baseDeDatos)
		{
			string rutaArchivo = "INVENTARIO.txt";

			if (!File.Exists(rutaArchivo))
			{
				// retorna false si el archivo ni se consigue
				return false;
			}

			try
			{
				using (StreamReader sr = new StreamReader(rutaArchivo))
				{
					string linea;
					while ((linea = sr.ReadLine()) != null)
					{
						try
						{
							Producto productoCargado = Producto.FromString(linea);
							baseDeDatos.AgregarProductoALaLista(productoCargado.Nombre, productoCargado.CostoBase, productoCargado.Costo, productoCargado.SubClasificación, productoCargado.PrecioCambio, productoCargado.Disponible == "Si", 0, productoCargado.PorcentajeAplicado);
						}
						catch (FormatException)
						{
							//Si una linea se malforma, manejo eso aquí, pero no va en el proyecto asi que lo dejaré chill
							continue; // Skipea y sigue con el siguiente
						}
						catch (Exception)
						{
							// Si hubo otra excepción, es decir, otro tipo de error
							continue; // Skippea la linea
						}
					}
				}
				return true; // Returna true si todo fue bien, incluso si skipeo cosas
			}
			catch (Exception)
			{
				// Si todo falla, pues retorno false
				return false;
			}
		}
	}
}
