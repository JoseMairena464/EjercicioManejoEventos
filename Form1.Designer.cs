namespace TodoList
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxTarea = new TextBox();
            cbPrioridad = new ComboBox();
            btnAgregar = new Button();
            txtBoxBuscar = new TextBox();
            btnBuscar = new Button();
            lblTarea = new Label();
            lblPrioridad = new Label();
            flowPanelTodoList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtBoxTarea
            // 
            txtBoxTarea.Location = new Point(42, 51);
            txtBoxTarea.Name = "txtBoxTarea";
            txtBoxTarea.PlaceholderText = "Indique el nombre de su tarea";
            txtBoxTarea.Size = new Size(550, 27);
            txtBoxTarea.TabIndex = 0;
            // 
            // cbPrioridad
            // 
            cbPrioridad.FormattingEnabled = true;
            cbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cbPrioridad.Location = new Point(616, 52);
            cbPrioridad.Name = "cbPrioridad";
            cbPrioridad.Size = new Size(187, 28);
            cbPrioridad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(823, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += onBtnAgregarClick;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(617, 117);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Nombre de la tarea ...";
            txtBoxBuscar.Size = new Size(187, 27);
            txtBoxBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(824, 117);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Location = new Point(48, 34);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(44, 20);
            lblTarea.TabIndex = 5;
            lblTarea.Text = "Tarea";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(623, 34);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(70, 20);
            lblPrioridad.TabIndex = 6;
            lblPrioridad.Text = "Prioridad";
            // 
            // flowPanelTodoList
            // 
            flowPanelTodoList.Location = new Point(28, 156);
            flowPanelTodoList.Name = "flowPanelTodoList";
            flowPanelTodoList.Size = new Size(878, 386);
            flowPanelTodoList.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 563);
            Controls.Add(flowPanelTodoList);
            Controls.Add(lblPrioridad);
            Controls.Add(lblTarea);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(cbPrioridad);
            Controls.Add(txtBoxTarea);
            Name = "Form1";
            Padding = new Padding(6);
            Text = "Control de Tareas";
            Click += onBtnAgregarClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxTarea;
		private ComboBox cbPrioridad;
		private Button btnAgregar;
		private TextBox txtBoxBuscar;
		private Button btnBuscar;
		private Label lblTarea;
		private Label lblPrioridad;
		private FlowLayoutPanel flowPanelTodoList;
	}
}
