/*
 * Creado por SharpDevelop.
 * Usuario: Equipo
 * Fecha: 21/06/2025
 * Hora: 2:31 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProyectoFinalALPProductos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private ListadoProductos BDProductos;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			BCVRadio.Checked = true;
			aditionBtn.Enabled = false;
			BDProductos = new ListadoProductos();
			categoryCombBox.SelectedIndex = 0;
			gananciaComboBox.SelectedIndex = 0;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//METODOS DEL FORMULARIO
		
		void actualizarPromInput()
		{
			decimal BCVtext;
			decimal Eurotext;
			
			if(VerificacionDeDatos.VerificarNumero(BCVinput.Text) && VerificacionDeDatos.VerificarNumero(euroInput.Text)){
				BCVtext = decimal.Parse(BCVinput.Text);
				Eurotext = decimal.Parse(euroInput.Text);
				promInput.Text = ((BCVtext + Eurotext) / 2).ToString("N2");
				return;
			}
			
			promInput.Text = "No estás ingresando números";
		}
		
		void resetTasaInputs(){
			BCVinput.Text = "100";
			euroInput.Text = "120";
		}
		
		void AgregarProductosALaGrilla(){
			dgvProductos.DataSource = null;
			dgvProductos.DataSource = BDProductos.ObtenerProductosDeLaLista();
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		void activarODesactivarBtn(){
			if(!verificarTodosLosInputs()){
				aditionBtn.Enabled = false;
				precioVentaInput.Text =  "Falta info";
				return;
			}
			calcularPrecioSubtotal();
			aditionBtn.Enabled = true;
		}
		
		bool verificarTodosLosInputs(){
			return (VerificacionDeDatos.VerificarEspaciosVaciosONoValidos(nameProducto.Text) && VerificacionDeDatos.VerificarCategoria(categoryCombBox.SelectedIndex) && VerificacionDeDatos.VerificarNumero(priceText.Text));
		}
		
		void limpiarFormulario(){
			nameProducto.Text = "";
			priceText.Text = "";
			categoryCombBox.Text = "--- Opciones ---";
			divisaText.Text = "";
		}
		
		
		//EVENTOS DE FORMULARIO
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dong expanded");
		}
		
		
		void PriceTextTextChanged(object sender, EventArgs e)
		{
			if(!verificarTodosLosInputs()){
				aditionBtn.Enabled = false;
				return;
			}
			calcularPrecioSubtotal();
			aditionBtn.Enabled = true;
		}
		
		void calcularPrecioSubtotal(){
			decimal costo;
			if (!decimal.TryParse(priceText.Text, out costo))
			{
				precioVentaInput.Text = "Costo Inválido"; // Mensaje para el usuario
				aditionBtn.Enabled = false; // Deshabilitar el botón de añadir si el costo no es válido
				return; // Salir de la función si el costo no es válido
			}
			decimal ganancia = (costo*decimal.Parse(gananciaComboBox.Text))/100;
			decimal precioSubtotal = costo + ganancia;
			precioVentaInput.Text = precioSubtotal.ToString();
			divisaText.Text = (precioSubtotal/decimal.Parse(BCVinput.Text)).ToString();
		}
		
		//Eventos para cuando se escriba un input
		
		void MainFormLoad(object sender, EventArgs e)
		{
			resetTasaInputs();
			actualizarPromInput();
			if(!VerificacionDeDatos.CargarInventario(BDProductos)){
				MessageBox.Show("No pudo cargar la base de datos");
				return;
			}
			AgregarProductosALaGrilla();
		}
		
		void AditionBtnClick(object sender, EventArgs e)
		{
			string categoryText;
			string nombProd = nameProducto.Text;
			decimal costoProd = decimal.Parse(priceText.Text);
			decimal ganancia;
			decimal precioSinTasa;
			decimal precioDolar;
			
			ganancia = (decimal.Parse(gananciaComboBox.Text)*costoProd)/100;
			precioSinTasa = (costoProd + ganancia);
			precioDolar = precioSinTasa / decimal.Parse(BCVinput.Text);
			
			bool disponibilidad = disponibleCheck.Checked;
			
			if(!VerificacionDeDatos.VerificarCategoria(categoryCombBox.SelectedIndex)){
				MessageBox.Show("No se pudo agregar el producto, escoge una categoria válida");
				return;
			}
			categoryText = categoryCombBox.Text;
			
			if(!BDProductos.AgregarProductoALaLista(nombProd, precioSinTasa, categoryText, precioDolar, disponibilidad, decimal.Parse(BCVinput.Text))){
				MessageBox.Show("Producto ya encontrado en la lista");
				return;
			}
			if(!VerificacionDeDatos.GuardarInventario(BDProductos)){
				MessageBox.Show("Los datos no pudieron guardarse en el txt");
				return;
			}
			MessageBox.Show("Se guardaron correctamente los datos");
			AgregarProductosALaGrilla();
			limpiarFormulario();
		}
		
		void NameProductoTextChanged(object sender, EventArgs e)
		{
			activarODesactivarBtn();
		}
		
		void CategoryCombBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			activarODesactivarBtn();
		}
		
		void DeleteBtnClick(object sender, EventArgs e)
		{
			string texto = Interaction.InputBox("Ingrese el nombre del producto que desea eliminar");
			if(!VerificacionDeDatos.VerificarEspaciosVaciosONoValidos(texto)){
				MessageBox.Show("Debe escribir un nombre.");
				return;
			}
			if(BDProductos.EliminarProductoDeLaLista(texto)){
				MessageBox.Show("Producto eliminado exitosamente");
				if(!VerificacionDeDatos.GuardarInventario(BDProductos)){
					MessageBox.Show("Los datos no pudieron guardarse en el txt");
					return;
				}
				AgregarProductosALaGrilla();
				return;
			}
			MessageBox.Show("Producto no encontrado");
		}
		
		void DgvProductosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void GananciaComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			calcularPrecioSubtotal();
		}
		
		
		void BCVinputTextChanged(object sender, EventArgs e)
		{
			if(!verificarTodosLosInputs()){
				aditionBtn.Enabled = false;
				divisaText.Text = "No pudo convertir";
				return;
			}
			calcularPrecioSubtotal();
			aditionBtn.Enabled = true;
		}
	}
}
