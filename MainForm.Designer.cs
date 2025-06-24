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
			this.tasaText = new System.Windows.Forms.Label();
			this.tasaInput = new System.Windows.Forms.TextBox();
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
			this.labelprice.Size = new System.Drawing.Size(113, 23);
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
			// tasaText
			// 
			this.tasaText.BackColor = System.Drawing.Color.Indigo;
			this.tasaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.tasaText.ForeColor = System.Drawing.Color.White;
			this.tasaText.Location = new System.Drawing.Point(12, 132);
			this.tasaText.Name = "tasaText";
			this.tasaText.Size = new System.Drawing.Size(124, 23);
			this.tasaText.TabIndex = 5;
			this.tasaText.Text = "Tasa actual";
			// 
			// tasaInput
			// 
			this.tasaInput.Location = new System.Drawing.Point(12, 158);
			this.tasaInput.Name = "tasaInput";
			this.tasaInput.Size = new System.Drawing.Size(100, 20);
			this.tasaInput.TabIndex = 6;
			// 
			// BCVlabel
			// 
			this.BCVlabel.BackColor = System.Drawing.Color.Indigo;
			this.BCVlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.BCVlabel.ForeColor = System.Drawing.Color.White;
			this.BCVlabel.Location = new System.Drawing.Point(438, 12);
			this.BCVlabel.Name = "BCVlabel";
			this.BCVlabel.Size = new System.Drawing.Size(104, 23);
			this.BCVlabel.TabIndex = 7;
			this.BCVlabel.Text = "Tasa BCV";
			// 
			// BCVinput
			// 
			this.BCVinput.Location = new System.Drawing.Point(438, 38);
			this.BCVinput.Name = "BCVinput";
			this.BCVinput.Size = new System.Drawing.Size(100, 20);
			this.BCVinput.TabIndex = 8;
			this.BCVinput.TextChanged += new System.EventHandler(this.BCVinputTextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Indigo;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(438, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Tasa Euro";
			// 
			// euroInput
			// 
			this.euroInput.Location = new System.Drawing.Point(438, 97);
			this.euroInput.Name = "euroInput";
			this.euroInput.Size = new System.Drawing.Size(100, 20);
			this.euroInput.TabIndex = 10;
			this.euroInput.TextChanged += new System.EventHandler(this.EuroInputTextChanged);
			// 
			// promInput
			// 
			this.promInput.Enabled = false;
			this.promInput.Location = new System.Drawing.Point(438, 162);
			this.promInput.Name = "promInput";
			this.promInput.Size = new System.Drawing.Size(148, 20);
			this.promInput.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Indigo;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(438, 132);
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
			this.disponibleCheck.Location = new System.Drawing.Point(12, 211);
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
			this.label4.Location = new System.Drawing.Point(12, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Disponibilidad";
			// 
			// categoryCombBox
			// 
			this.categoryCombBox.FormattingEnabled = true;
			this.categoryCombBox.Items.AddRange(new object[] {
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
			this.categoryCombBox.Text = "--- Opciones ---";
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
			this.dgvProductos.Location = new System.Drawing.Point(12, 236);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.Size = new System.Drawing.Size(448, 150);
			this.dgvProductos.TabIndex = 18;
			// 
			// aditionBtn
			// 
			this.aditionBtn.Location = new System.Drawing.Point(244, 61);
			this.aditionBtn.Name = "aditionBtn";
			this.aditionBtn.Size = new System.Drawing.Size(121, 56);
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
			this.label6.Location = new System.Drawing.Point(486, 330);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "Precio de venta";
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(244, 126);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(121, 56);
			this.deleteBtn.TabIndex = 21;
			this.deleteBtn.Text = "Eliminar Producto";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(722, 458);
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
			this.Controls.Add(this.tasaInput);
			this.Controls.Add(this.tasaText);
			this.Controls.Add(this.priceText);
			this.Controls.Add(this.labelprice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameProducto);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F);
			this.Name = "MainForm";
			this.Text = "ProyectoFinalALPProductos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
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
		private System.Windows.Forms.TextBox tasaInput;
		private System.Windows.Forms.Label tasaText;
		private System.Windows.Forms.TextBox priceText;
		private System.Windows.Forms.Label labelprice;
		private System.Windows.Forms.Label label1;
		
		private System.Windows.Forms.TextBox nameProducto;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
