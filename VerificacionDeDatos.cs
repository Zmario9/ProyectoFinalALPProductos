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
		
		public static bool CargarInventario(ListadoProductos baseDeDatos)
		{
			string rutaArchivo = "INVENTARIO.txt";

			if (!File.Exists(rutaArchivo))
			{
				// File doesn't exist, so nothing to load. Return false.
				return false;
			}

			try
			{
				// Clear the list to prevent duplicate entries if loaded multiple times.
				// You'll need to add a public method in ListadoProductos like:
				// public void ClearProducts() { BDProductos.Clear(); }
				// baseDeDatos.ClearProducts(); // Uncomment if you add this method

				using (StreamReader sr = new StreamReader(rutaArchivo))
				{
					string linea;
					while ((linea = sr.ReadLine()) != null)
					{
						try
						{
							Producto productoCargado = Producto.FromString(linea);
							// Add the loaded product. Note: your ListadoProductos.AgregarProductoALaLista
							// checks for duplicates by name. If you want to load all items from file
							// even if names are repeated, you might need a different Add method
							// or modify AgregarProductoALaLista to always add if loading.
							// The '0' for tasaBCV is a placeholder as FromString doesn't provide it.
							baseDeDatos.AgregarProductoALaLista(productoCargado.Nombre, productoCargado.Costo, productoCargado.SubClasificación, productoCargado.PrecioCambio, productoCargado.Disponible == "Si", 0);
						}
						catch (FormatException)
						{
							// A line was malformed. You can log this silently if you don't want to show
							// a message, but it means that line won't be loaded.
							// For example, Console.WriteLine($"Error de formato en la línea: {linea}");
							continue; // Skip this line and try the next one
						}
						catch (Exception)
						{
							// Other unexpected parsing errors for a specific line.
							continue; // Skip this line
						}
					}
				}
				return true; // Successfully loaded (even if some lines were skipped due to errors)
			}
			catch (Exception)
			{
				// General error during file reading (e.g., permissions).
				return false;
			}
		}
	}
}
