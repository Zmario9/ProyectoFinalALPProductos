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
			aditionBtn.Enabled = false;
			BDProductos = new ListadoProductos();
			BDProductos.AgregarProductoALaLista("Harina", 150.50m, "VIVERES",true);
			AgregarProductosALaGrilla();
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
			BCVinput.TextChanged -= BCVinputTextChanged;
			euroInput.TextChanged -= EuroInputTextChanged;
			
			BCVinput.Text = "100";
			euroInput.Text = "120";
			
			BCVinput.TextChanged += BCVinputTextChanged;
			euroInput.TextChanged += EuroInputTextChanged;
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
				return;
			}
			
			aditionBtn.Enabled = true;
		}
		
		bool verificarTodosLosInputs(){
			return (VerificacionDeDatos.VerificarEspaciosVaciosONoValidos(nameProducto.Text) && VerificacionDeDatos.VerificarCategoria(categoryCombBox.Text) && VerificacionDeDatos.VerificarNumero(priceText.Text));
		}
		
		void limpiarFormulario(){
			nameProducto.Text = "";
			priceText.Text = "";
			categoryCombBox.Text = "--- Opciones ---";
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
			aditionBtn.Enabled = true;
		}
		
		//Eventos para cuando se escriba un input
		void BCVinputTextChanged(object sender, EventArgs e)
		{
			actualizarPromInput();
		}
		
		void EuroInputTextChanged(object sender, EventArgs e)
		{
			actualizarPromInput();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			resetTasaInputs();
			actualizarPromInput();
		}
		
		void AditionBtnClick(object sender, EventArgs e)
		{
			string categoryText;
			string nombProd = nameProducto.Text;
			decimal costoProd = decimal.Parse(priceText.Text);
			bool disponibilidad = disponibleCheck.Checked;
			
			if(!VerificacionDeDatos.VerificarCategoria(categoryCombBox.Text)){
				MessageBox.Show("No se pudo agregar el producto, escoge una categoria válida");
				return;
			}
			categoryText = categoryCombBox.Text;
			if(!BDProductos.AgregarProductoALaLista(nombProd, costoProd, categoryText, disponibilidad)){
				MessageBox.Show("Producto ya encontrado en la lista");
				return;
			}
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
				AgregarProductosALaGrilla();
				return;
			}
			MessageBox.Show("Producto no encontrado");
		}
	}
}
