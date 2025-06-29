/*
 * Creado por SharpDevelop.
 * Usuario: Equipo
 * Fecha: 21/06/2025
 * Hora: 2:31 PM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalALPProductos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.nameProducto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelprice = new System.Windows.Forms.Label();
			this.priceText = new System.Windows.Forms.TextBox();
			this.BCVlabel = new System.Windows.Forms.Label();
			this.BCVinput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.euroInput = new System.Windows.Forms.TextBox();
			this.promInput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.disponibleCheck = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.categoryCombBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.aditionBtn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.BCVRadio = new System.Windows.Forms.RadioButton();
			this.EURORadio = new System.Windows.Forms.RadioButton();
			this.PromRadio = new System.Windows.Forms.RadioButton();
			this.precioVentaInput = new System.Windows.Forms.TextBox();
			this.gananciaComboBox = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.divisaText = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.refDolarInput = new System.Windows.Forms.TextBox();
			this.modificarProducto = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(560, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(157, 117);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// nameProducto
			// 
			this.nameProducto.Location = new System.Drawing.Point(12, 35);
			this.nameProducto.Name = "nameProducto";
			this.nameProducto.Size = new System.Drawing.Size(226, 20);
			this.nameProducto.TabIndex = 1;
			this.nameProducto.TextChanged += new System.EventHandler(this.NameProductoTextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Indigo;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Producto:";
			// 
			// labelprice
			// 
			this.labelprice.BackColor = System.Drawing.Color.Indigo;
			this.labelprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.labelprice.ForeColor = System.Drawing.Color.White;
			this.labelprice.Location = new System.Drawing.Point(12, 71);
			this.labelprice.Name = "labelprice";
			this.labelprice.Size = new System.Drawing.Size(135, 23);
			this.labelprice.TabIndex = 3;
			this.labelprice.Text = "Costo:  (Bs.)";
			// 
			// priceText
			// 
			this.priceText.Location = new System.Drawing.Point(12, 97);
			this.priceText.Name = "priceText";
			this.priceText.Size = new System.Drawing.Size(100, 20);
			this.priceText.TabIndex = 4;
			this.priceText.TextChanged += new System.EventHandler(this.PriceTextTextChanged);
			// 
			// BCVlabel
			// 
			this.BCVlabel.BackColor = System.Drawing.Color.Indigo;
			this.BCVlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.BCVlabel.ForeColor = System.Drawing.Color.White;
			this.BCVlabel.Location = new System.Drawing.Point(450, 12);
			this.BCVlabel.Name = "BCVlabel";
			this.BCVlabel.Size = new System.Drawing.Size(104, 23);
			this.BCVlabel.TabIndex = 7;
			this.BCVlabel.Text = "Tasa BCV";
			// 
			// BCVinput
			// 
			this.BCVinput.Location = new System.Drawing.Point(450, 38);
			this.BCVinput.Name = "BCVinput";
			this.BCVinput.Size = new System.Drawing.Size(100, 20);
			this.BCVinput.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Indigo;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(450, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Tasa Euro";
			// 
			// euroInput
			// 
			this.euroInput.Location = new System.Drawing.Point(450, 97);
			this.euroInput.Name = "euroInput";
			this.euroInput.Size = new System.Drawing.Size(100, 20);
			this.euroInput.TabIndex = 10;
			// 
			// promInput
			// 
			this.promInput.Enabled = false;
			this.promInput.Location = new System.Drawing.Point(450, 158);
			this.promInput.Name = "promInput";
			this.promInput.Size = new System.Drawing.Size(148, 20);
			this.promInput.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Indigo;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(450, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tasa Promedio";
			// 
			// disponibleCheck
			// 
			this.disponibleCheck.BackColor = System.Drawing.Color.Indigo;
			this.disponibleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.disponibleCheck.ForeColor = System.Drawing.Color.White;
			this.disponibleCheck.Location = new System.Drawing.Point(12, 264);
			this.disponibleCheck.Name = "disponibleCheck";
			this.disponibleCheck.Size = new System.Drawing.Size(104, 24);
			this.disponibleCheck.TabIndex = 14;
			this.disponibleCheck.Text = "Disponible";
			this.disponibleCheck.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Indigo;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 238);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Disponibilidad";
			// 
			// categoryCombBox
			// 
			this.categoryCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoryCombBox.FormattingEnabled = true;
			this.categoryCombBox.Items.AddRange(new object[] {
									"-- Opciones --",
									"VIVERES",
									"ELECTRODOMESTICOS",
									"VEGETALES",
									"LACTEOS",
									"MEDICINAS",
									"REPUESTOS"});
			this.categoryCombBox.Location = new System.Drawing.Point(244, 34);
			this.categoryCombBox.Name = "categoryCombBox";
			this.categoryCombBox.Size = new System.Drawing.Size(121, 21);
			this.categoryCombBox.TabIndex = 16;
			this.categoryCombBox.SelectedIndexChanged += new System.EventHandler(this.CategoryCombBoxSelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Indigo;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(244, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Categoria";
			// 
			// dgvProductos
			// 
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Location = new System.Drawing.Point(12, 296);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.Size = new System.Drawing.Size(698, 150);
			this.dgvProductos.TabIndex = 18;
			this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductosCellDoubleClick);
			// 
			// aditionBtn
			// 
			this.aditionBtn.Location = new System.Drawing.Point(244, 61);
			this.aditionBtn.Name = "aditionBtn";
			this.aditionBtn.Size = new System.Drawing.Size(91, 56);
			this.aditionBtn.TabIndex = 19;
			this.aditionBtn.Text = "⇧Adicionar;";
			this.aditionBtn.UseVisualStyleBackColor = true;
			this.aditionBtn.Click += new System.EventHandler(this.AditionBtnClick);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Indigo;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(12, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(202, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "Precio de venta (Bs.)";
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(244, 126);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(91, 56);
			this.deleteBtn.TabIndex = 21;
			this.deleteBtn.Text = "Eliminar Producto";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
			// 
			// BCVRadio
			// 
			this.BCVRadio.BackColor = System.Drawing.Color.Indigo;
			this.BCVRadio.ForeColor = System.Drawing.Color.White;
			this.BCVRadio.Location = new System.Drawing.Point(491, 202);
			this.BCVRadio.Name = "BCVRadio";
			this.BCVRadio.Size = new System.Drawing.Size(104, 24);
			this.BCVRadio.TabIndex = 22;
			this.BCVRadio.TabStop = true;
			this.BCVRadio.Text = "Tasa BCV";
			this.BCVRadio.UseVisualStyleBackColor = false;
			this.BCVRadio.Click += new System.EventHandler(this.BCVRadioClick);
			// 
			// EURORadio
			// 
			this.EURORadio.BackColor = System.Drawing.Color.Indigo;
			this.EURORadio.ForeColor = System.Drawing.Color.White;
			this.EURORadio.Location = new System.Drawing.Point(491, 232);
			this.EURORadio.Name = "EURORadio";
			this.EURORadio.Size = new System.Drawing.Size(104, 24);
			this.EURORadio.TabIndex = 23;
			this.EURORadio.TabStop = true;
			this.EURORadio.Text = "Tasa EURO";
			this.EURORadio.UseVisualStyleBackColor = false;
			this.EURORadio.Click += new System.EventHandler(this.EURORadioClick);
			// 
			// PromRadio
			// 
			this.PromRadio.BackColor = System.Drawing.Color.Indigo;
			this.PromRadio.ForeColor = System.Drawing.Color.White;
			this.PromRadio.Location = new System.Drawing.Point(491, 263);
			this.PromRadio.Name = "PromRadio";
			this.PromRadio.Size = new System.Drawing.Size(104, 24);
			this.PromRadio.TabIndex = 24;
			this.PromRadio.TabStop = true;
			this.PromRadio.Text = "Tasa Promedio";
			this.PromRadio.UseVisualStyleBackColor = false;
			// 
			// precioVentaInput
			// 
			this.precioVentaInput.Enabled = false;
			this.precioVentaInput.Location = new System.Drawing.Point(12, 211);
			this.precioVentaInput.Name = "precioVentaInput";
			this.precioVentaInput.Size = new System.Drawing.Size(100, 20);
			this.precioVentaInput.TabIndex = 25;
			this.precioVentaInput.TextChanged += new System.EventHandler(this.PrecioVentaInputTextChanged);
			// 
			// gananciaComboBox
			// 
			this.gananciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gananciaComboBox.FormattingEnabled = true;
			this.gananciaComboBox.Items.AddRange(new object[] {
									"30",
									"40",
									"50"});
			this.gananciaComboBox.Location = new System.Drawing.Point(244, 213);
			this.gananciaComboBox.Name = "gananciaComboBox";
			this.gananciaComboBox.Size = new System.Drawing.Size(121, 21);
			this.gananciaComboBox.TabIndex = 26;
			this.gananciaComboBox.SelectedIndexChanged += new System.EventHandler(this.GananciaComboBoxSelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Indigo;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(244, 185);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(173, 25);
			this.label7.TabIndex = 27;
			this.label7.Text = "Tasa de ganancia";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Indigo;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(12, 126);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(202, 23);
			this.label8.TabIndex = 28;
			this.label8.Text = "Precio en divisa ($.)";
			// 
			// divisaText
			// 
			this.divisaText.Enabled = false;
			this.divisaText.Location = new System.Drawing.Point(12, 152);
			this.divisaText.Name = "divisaText";
			this.divisaText.Size = new System.Drawing.Size(100, 20);
			this.divisaText.TabIndex = 29;
			this.divisaText.TextChanged += new System.EventHandler(this.DivisaTextTextChanged);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Indigo;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(244, 238);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(240, 23);
			this.label9.TabIndex = 30;
			this.label9.Text = "Venta a divisa convertible";
			// 
			// refDolarInput
			// 
			this.refDolarInput.Enabled = false;
			this.refDolarInput.Location = new System.Drawing.Point(244, 264);
			this.refDolarInput.Name = "refDolarInput";
			this.refDolarInput.Size = new System.Drawing.Size(100, 20);
			this.refDolarInput.TabIndex = 31;
			// 
			// modificarProducto
			// 
			this.modificarProducto.Location = new System.Drawing.Point(341, 61);
			this.modificarProducto.Name = "modificarProducto";
			this.modificarProducto.Size = new System.Drawing.Size(91, 56);
			this.modificarProducto.TabIndex = 32;
			this.modificarProducto.Text = "Modificar Producto";
			this.modificarProducto.UseVisualStyleBackColor = true;
			this.modificarProducto.Click += new System.EventHandler(this.ModificarProductoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(722, 457);
			this.Controls.Add(this.modificarProducto);
			this.Controls.Add(this.refDolarInput);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.divisaText);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.gananciaComboBox);
			this.Controls.Add(this.precioVentaInput);
			this.Controls.Add(this.PromRadio);
			this.Controls.Add(this.EURORadio);
			this.Controls.Add(this.BCVRadio);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.aditionBtn);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.categoryCombBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.disponibleCheck);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.promInput);
			this.Controls.Add(this.euroInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BCVinput);
			this.Controls.Add(this.BCVlabel);
			this.Controls.Add(this.priceText);
			this.Controls.Add(this.labelprice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameProducto);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
			this.MaximumSize = new System.Drawing.Size(738, 496);
			this.MinimumSize = new System.Drawing.Size(738, 496);
			this.Name = "MainForm";
			this.Text = "ProyectoFinalALPProductos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button modificarProducto;
		private System.Windows.Forms.TextBox refDolarInput;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox divisaText;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox gananciaComboBox;
		private System.Windows.Forms.TextBox precioVentaInput;
		private System.Windows.Forms.RadioButton PromRadio;
		private System.Windows.Forms.RadioButton EURORadio;
		private System.Windows.Forms.RadioButton BCVRadio;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button aditionBtn;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox categoryCombBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox disponibleCheck;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox promInput;
		private System.Windows.Forms.TextBox euroInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox BCVinput;
		private System.Windows.Forms.Label BCVlabel;
		private System.Windows.Forms.TextBox priceText;
		private System.Windows.Forms.Label labelprice;
		private System.Windows.Forms.Label label1;
		
		private System.Windows.Forms.TextBox nameProducto;
		private System.Windows.Forms.PictureBox pictureBox1;
		
	}
}
