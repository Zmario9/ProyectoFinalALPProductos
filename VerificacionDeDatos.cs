/*
 * Creado por SharpDevelop.
 * Usuario: Equipo
 * Fecha: 21/06/2025
 * Hora: 2:58 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

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
		
		public static bool VerificarCategoria(string categoryText){
			if(categoryText == "--- Opciones ---"){
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
		
	}
}
