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
		private bool EstaModificando = false;
		private Producto ProductoDeReferencia;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			BCVRadio.Checked = true;
			aditionBtn.Enabled = false;
			modificarProducto.Enabled = false;
			BDProductos = new ListadoProductos();
			categoryCombBox.SelectedIndex = 0;
			gananciaComboBox.SelectedIndex = 0;
			BCVRadio.Enabled = false;
			EURORadio.Enabled = false;
			PromRadio.Enabled = false;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ActivarODesactivarInputsRadio(bool activar){
			BCVRadio.Enabled = activar ? true : false;
			EURORadio.Enabled = activar ? true : false;
			PromRadio.Enabled = activar ? true : false;
			if (activar) BCVRadioClick(BCVRadio, EventArgs.Empty);
		}
		
		//METODOS DEL FORMULARIO
		
		void BCVRadioClick(object sender, EventArgs e)
		{
			if(!EstaModificando) {
				refDolarInput.Text = "";
				return;
			}
			if(VerificacionDeDatos.VerificarNumero(divisaText.Text)){
				MessageBox.Show("Todo valido");
				ObtenerPrecioEnBolivares(decimal.Parse(divisaText.Text), BCVRadio);
			}
		}
		
		void EURORadioClick(object sender, EventArgs e)
		{
			if(!EstaModificando) {
				refDolarInput.Text = "";
				return;
			}
			if(VerificacionDeDatos.VerificarNumero(divisaText.Text)){
				ObtenerPrecioEnBolivares(decimal.Parse(divisaText.Text), EURORadio);
			}
		}
		
		void PromRadioCheckedChanged(object sender, EventArgs e)
		{
			if(!EstaModificando) {
				refDolarInput.Text = "";
				return;
			}
			if(VerificacionDeDatos.VerificarNumero(divisaText.Text)){
				ObtenerPrecioEnBolivares(decimal.Parse(divisaText.Text), PromRadio);
			}
		}
		
		
		public void ObtenerPrecioEnBolivares(decimal bolivares, RadioButton selectedRadio){
			if(VerificacionDeDatos.VerificarNumero(BCVinput.Text) && VerificacionDeDatos.VerificarNumero(euroInput.Text) && VerificacionDeDatos.VerificarNumero(promInput.Text)){
				switch(selectedRadio.Text){
						case "Tasa BCV": refDolarInput.Text = (decimal.Parse(BCVinput.Text) * ProductoDeReferencia.PrecioCambio).ToString(); break;
						case "Tasa EURO": refDolarInput.Text = (decimal.Parse(euroInput.Text) * ProductoDeReferencia.PrecioCambio).ToString(); break;
						case "Tasa Promedio": refDolarInput.Text = (decimal.Parse(promInput.Text) * ProductoDeReferencia.PrecioCambio).ToString(); break;
						default: MessageBox.Show("Ninguno, error"); break;
				}
			}
		}
		
		void actualizarPromInput()
		{
			decimal BCVtext;
			decimal Eurotext;
			
			if(VerificacionDeDatos.VerificarNumero(BCVinput.Text) && VerificacionDeDatos.VerificarNumero(euroInput.Text)){
				BCVtext = decimal.Parse(BCVinput.Text);
				Eurotext = decimal.Parse(euroInput.Text);
				if(BCVtext > 0 && Eurotext > 0){
					promInput.Text = ((BCVtext + Eurotext) / 2).ToString("N2");
				}
				activarODesactivarBtn(); // Intentará recalcular y validar todo
				activarODesactivarModBtn();
				return;
			}
			promInput.Text = "No estás ingresando números";
			activarODesactivarBtn(); // Intentará recalcular y validar todo
			activarODesactivarModBtn();
		}
		
		void resetTasaInputs(){
			BCVinput.Text = "100";
			euroInput.Text = "120";
			promInput.Text = "";
		}
		
		void AgregarProductosALaGrilla(){
			dgvProductos.DataSource = null;
			dgvProductos.DataSource = BDProductos.ObtenerProductosDeLaLista();
			if (dgvProductos.Columns.Contains("CostoBase"))
			{
				dgvProductos.Columns["CostoBase"].Visible = false;
			}
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void activarODesactivarBtn(){
			if(!EstaModificando){
				if(!verificarTodosLosInputs()){
					aditionBtn.Enabled = false;
					precioVentaInput.Text =  "Falta info";
					divisaText.Text = "No se puede registrar";
					return;
				}
				calcularPrecioSubtotal();
				aditionBtn.Enabled = true;
				return;
			}
			aditionBtn.Enabled = false;
		}
		
		void activarODesactivarModBtn(){
			if(EstaModificando){
				if(!verificarTodosLosInputs()){
					modificarProducto.Enabled = false;
					divisaText.Text = "No se puede actualizar";
					precioVentaInput.Text =  "Falta info";
					return;
				}
				calcularPrecioSubtotal();
				modificarProducto.Enabled = true;
			}
		}
		
		
		bool verificarTodosLosInputs(){
			return (VerificacionDeDatos.VerificarEspaciosVaciosONoValidos(nameProducto.Text) && VerificacionDeDatos.VerificarCategoria(categoryCombBox.SelectedIndex) && VerificacionDeDatos.VerificarNumero(priceText.Text) && VerificacionDeDatos.VerificarNumero(BCVinput.Text));
		}
		
		void limpiarFormulario(){
			nameProducto.Text = "";
			priceText.Text = "";
			categoryCombBox.Text = "--- Opciones ---";
			divisaText.Text = "";
			refDolarInput.Text = "";
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dong expanded");
		}
		
		//EVENTOS DE FORMULARIO TEXT CHANGE
		
		void PriceTextTextChanged(object sender, EventArgs e)
		{
			activarODesactivarModBtn();
		}
		
		void NameProductoTextChanged(object sender, EventArgs e)
		{
			activarODesactivarBtn();
			activarODesactivarModBtn();
		}
		
		void CategoryCombBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			activarODesactivarBtn();
			activarODesactivarModBtn();
		}
		
		void BCVinputTextChanged(object sender, EventArgs e)
		{
			activarODesactivarBtn();
			activarODesactivarModBtn();
			actualizarPromInput();
		}
		void EuroInputTextChanged(object sender, EventArgs e)
		{
			actualizarPromInput();
		}
		// FIN TEXT CHANGE
		
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
			if(!VerificacionDeDatos.VerificarNumero(BCVinput.Text)){
				divisaText.Text = "No se pudo convertir";
				precioVentaInput.Text = "Valor no valido";
				return;
			}
			precioVentaInput.Text = precioSubtotal.ToString() + "Bs.";
			divisaText.Text = "$"+(precioSubtotal/decimal.Parse(BCVinput.Text)).ToString();
		}
		
		//Eventos para cuando se escriba un input
		
		void MainFormLoad(object sender, EventArgs e)
		{
			resetTasaInputs();
			actualizarPromInput();
			modificarProducto.Enabled = false;
			if(!VerificacionDeDatos.CargarInventario(BDProductos)){
				MessageBox.Show("No pudo cargar la base de datos");
				return;
			}
			AgregarProductosALaGrilla();
		}
		
		void AditionBtnClick(object sender, EventArgs e)
		{
			if(EstaModificando){
				MessageBox.Show("Lo sentimos pero está modificando un producto.");
				return;
			}
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
			
			categoryText = categoryCombBox.Text;
			
			if(!BDProductos.AgregarProductoALaLista(nombProd, costoProd, precioSinTasa, categoryText, precioDolar, disponibilidad, decimal.Parse(BCVinput.Text), int.Parse(gananciaComboBox.Text))){
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
		
		void GananciaComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			calcularPrecioSubtotal();
		}
		
		void PrecioVentaInputTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void DgvProducts(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void DgvProductosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex < 0){
				return;
			}
			EstaModificando = true;

			string nombreDelProducto = (dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value).ToString();
//			MessageBox.Show(nombreDelProducto.ToString());
			Producto productoAModificar = BDProductos.buscarProductoDeLaLista(nombreDelProducto);
			nameProducto.Text = productoAModificar.Nombre;
			priceText.Text = productoAModificar.CostoBase.ToString();
			categoryCombBox.Text = productoAModificar.SubClasificación;
			disponibleCheck.Checked = (productoAModificar.Disponible == "Si") ? true : false;
			modificarProducto.Enabled = true;
			ProductoDeReferencia = productoAModificar;
			gananciaComboBox.Text = productoAModificar.PorcentajeAplicado.ToString();
			activarODesactivarBtn();
			activarODesactivarModBtn();
			ActivarODesactivarInputsRadio(true);
		}
		
		void ModificarProductoClick(object sender, EventArgs e)
		{
			Producto productoAModificar = BDProductos.buscarProductoDeLaLista(ProductoDeReferencia.Nombre);
			if(productoAModificar == null){
				MessageBox.Show("No se pudo hacer la modificación porque no se encontró el producto");
				return;
			}
			
			if(!verificarTodosLosInputs()){
				MessageBox.Show("Los datos no son validos, vuelvalo a intentar");
				return;
			}
			
			productoAModificar.Nombre = nameProducto.Text;
			productoAModificar.CostoBase = decimal.Parse(priceText.Text.Replace("Bs.","").Trim());
			productoAModificar.PrecioCambio = decimal.Parse(divisaText.Text.Replace("$","").Trim());
			productoAModificar.Disponible = disponibleCheck.Checked ? "Si" : "No disponible";
			productoAModificar.SubClasificación = categoryCombBox.Text;
			productoAModificar.PorcentajeAplicado = int.Parse(gananciaComboBox.Text);
			
			if(!VerificacionDeDatos.GuardarInventario(BDProductos)){
				MessageBox.Show("Los datos no pudieron guardarse en la base de datos.");
				return;
			}
			EstaModificando = false;
			modificarProducto.Enabled = false;
			AgregarProductosALaGrilla();
			ActivarODesactivarInputsRadio(false);
			limpiarFormulario();
		}
		
		void DivisaTextTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void PromInputTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BCVRadioCheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
