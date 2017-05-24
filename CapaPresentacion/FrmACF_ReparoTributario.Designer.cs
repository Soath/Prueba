namespace CapaPresentacion
{
    partial class FrmACF_ReparoTributario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmACF_ReparoTributario));
            this.dtRTRfecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRTRestado = new System.Windows.Forms.TextBox();
            this.txtRTRresponsable = new System.Windows.Forms.TextBox();
            this.txtRTRperiodo = new System.Windows.Forms.TextBox();
            this.txtRTRcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrimero = new System.Windows.Forms.ToolStripButton();
            this.toolStripUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSiguiente = new System.Windows.Forms.ToolStripButton();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.datalistado1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRTRfecha
            // 
            this.dtRTRfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRTRfecha.Location = new System.Drawing.Point(153, 224);
            this.dtRTRfecha.Name = "dtRTRfecha";
            this.dtRTRfecha.Size = new System.Drawing.Size(97, 20);
            this.dtRTRfecha.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtRTRestado
            // 
            this.txtRTRestado.Location = new System.Drawing.Point(153, 300);
            this.txtRTRestado.Name = "txtRTRestado";
            this.txtRTRestado.Size = new System.Drawing.Size(126, 20);
            this.txtRTRestado.TabIndex = 27;
            // 
            // txtRTRresponsable
            // 
            this.txtRTRresponsable.Location = new System.Drawing.Point(153, 263);
            this.txtRTRresponsable.Name = "txtRTRresponsable";
            this.txtRTRresponsable.Size = new System.Drawing.Size(274, 20);
            this.txtRTRresponsable.TabIndex = 26;
            // 
            // txtRTRperiodo
            // 
            this.txtRTRperiodo.Location = new System.Drawing.Point(153, 194);
            this.txtRTRperiodo.Name = "txtRTRperiodo";
            this.txtRTRperiodo.Size = new System.Drawing.Size(180, 20);
            this.txtRTRperiodo.TabIndex = 25;
            // 
            // txtRTRcodigo
            // 
            this.txtRTRcodigo.Location = new System.Drawing.Point(153, 162);
            this.txtRTRcodigo.Name = "txtRTRcodigo";
            this.txtRTRcodigo.Size = new System.Drawing.Size(109, 20);
            this.txtRTRcodigo.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Responsable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha Calculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Periodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID Calculo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 18;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(29, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(169, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Generar desde Base de Datos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Importar desde Excel";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefrescar,
            this.toolStripAgregar,
            this.toolStripEditar,
            this.toolStripGuardar,
            this.toolStripCancelar,
            this.toolStripPrimero,
            this.toolStripUltimo,
            this.toolStripAnterior,
            this.toolStripSiguiente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 67);
            this.toolStrip1.TabIndex = 156;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripRefrescar
            // 
            this.toolStripRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefrescar.Image")));
            this.toolStripRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefrescar.Name = "toolStripRefrescar";
            this.toolStripRefrescar.Size = new System.Drawing.Size(63, 64);
            this.toolStripRefrescar.Text = "Actualizar";
            this.toolStripRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripAgregar
            // 
            this.toolStripAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAgregar.Image")));
            this.toolStripAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAgregar.Name = "toolStripAgregar";
            this.toolStripAgregar.Size = new System.Drawing.Size(99, 64);
            this.toolStripAgregar.Text = "Agregar/Generar";
            this.toolStripAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAgregar.Click += new System.EventHandler(this.toolStripAgregar_Click);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditar.Image")));
            this.toolStripEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(41, 64);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(53, 64);
            this.toolStripGuardar.Text = "Guardar";
            this.toolStripGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripGuardar.Visible = false;
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click);
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
            this.toolStripCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(57, 64);
            this.toolStripCancelar.Text = "Cancelar";
            this.toolStripCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Visible = false;
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
            // 
            // toolStripPrimero
            // 
            this.toolStripPrimero.AutoSize = false;
            this.toolStripPrimero.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrimero.Image")));
            this.toolStripPrimero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrimero.Name = "toolStripPrimero";
            this.toolStripPrimero.Size = new System.Drawing.Size(60, 79);
            this.toolStripPrimero.Text = "Primero";
            this.toolStripPrimero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripPrimero.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripPrimero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripPrimero.Click += new System.EventHandler(this.toolStripPrimero_Click);
            // 
            // toolStripUltimo
            // 
            this.toolStripUltimo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUltimo.Image")));
            this.toolStripUltimo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUltimo.Name = "toolStripUltimo";
            this.toolStripUltimo.Size = new System.Drawing.Size(47, 64);
            this.toolStripUltimo.Text = "Ultimo";
            this.toolStripUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripUltimo.Click += new System.EventHandler(this.toolStripUltimo_Click);
            // 
            // toolStripAnterior
            // 
            this.toolStripAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripAnterior.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAnterior.Image")));
            this.toolStripAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAnterior.Name = "toolStripAnterior";
            this.toolStripAnterior.Size = new System.Drawing.Size(54, 64);
            this.toolStripAnterior.Text = "Anterior";
            this.toolStripAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAnterior.Click += new System.EventHandler(this.toolStripAnterior_Click);
            // 
            // toolStripSiguiente
            // 
            this.toolStripSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSiguiente.Image")));
            this.toolStripSiguiente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSiguiente.Name = "toolStripSiguiente";
            this.toolStripSiguiente.Size = new System.Drawing.Size(60, 64);
            this.toolStripSiguiente.Text = "Siguiente";
            this.toolStripSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSiguiente.Click += new System.EventHandler(this.toolStripSiguiente_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // datalistado1
            // 
            this.datalistado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado1.Location = new System.Drawing.Point(12, 346);
            this.datalistado1.Name = "datalistado1";
            this.datalistado1.Size = new System.Drawing.Size(645, 286);
            this.datalistado1.TabIndex = 157;
            // 
            // FrmACF_ReparoTributario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 644);
            this.Controls.Add(this.datalistado1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtRTRfecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtRTRestado);
            this.Controls.Add(this.txtRTRresponsable);
            this.Controls.Add(this.txtRTRperiodo);
            this.Controls.Add(this.txtRTRcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "FrmACF_ReparoTributario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmACF_ReparoTributario";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtRTRfecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRTRestado;
        private System.Windows.Forms.TextBox txtRTRresponsable;
        private System.Windows.Forms.TextBox txtRTRperiodo;
        private System.Windows.Forms.TextBox txtRTRcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripRefrescar;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripEditar;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripPrimero;
        private System.Windows.Forms.ToolStripButton toolStripUltimo;
        private System.Windows.Forms.ToolStripButton toolStripAnterior;
        private System.Windows.Forms.ToolStripButton toolStripSiguiente;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.DataGridView datalistado1;
    }
}