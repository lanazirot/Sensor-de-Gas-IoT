
namespace Sensor_de_Gas_IoT {
    partial class FormPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.grbGrafico = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMQ2 = new System.Windows.Forms.TabPage();
            this.tabMQ3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnciendeAspersores = new FontAwesome.Sharp.IconButton();
            this.btnNotificarCelular = new FontAwesome.Sharp.IconButton();
            this.btnEncenderAlarmaLocalmente = new FontAwesome.Sharp.IconButton();
            this.btnPanico = new FontAwesome.Sharp.IconButton();
            this.grbGrafico.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGrafico
            // 
            this.grbGrafico.Controls.Add(this.tabControl1);
            this.grbGrafico.Location = new System.Drawing.Point(12, 12);
            this.grbGrafico.Name = "grbGrafico";
            this.grbGrafico.Size = new System.Drawing.Size(670, 475);
            this.grbGrafico.TabIndex = 0;
            this.grbGrafico.TabStop = false;
            this.grbGrafico.Text = "Visor general";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMQ2);
            this.tabControl1.Controls.Add(this.tabMQ3);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMQ2
            // 
            this.tabMQ2.Location = new System.Drawing.Point(4, 22);
            this.tabMQ2.Name = "tabMQ2";
            this.tabMQ2.Padding = new System.Windows.Forms.Padding(3);
            this.tabMQ2.Size = new System.Drawing.Size(650, 424);
            this.tabMQ2.TabIndex = 0;
            this.tabMQ2.Text = "Sensor MQ2";
            this.tabMQ2.UseVisualStyleBackColor = true;
            // 
            // tabMQ3
            // 
            this.tabMQ3.Location = new System.Drawing.Point(4, 22);
            this.tabMQ3.Name = "tabMQ3";
            this.tabMQ3.Padding = new System.Windows.Forms.Padding(3);
            this.tabMQ3.Size = new System.Drawing.Size(650, 424);
            this.tabMQ3.TabIndex = 1;
            this.tabMQ3.Text = "Sensor MQ3";
            this.tabMQ3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnciendeAspersores);
            this.groupBox1.Controls.Add(this.btnNotificarCelular);
            this.groupBox1.Controls.Add(this.btnEncenderAlarmaLocalmente);
            this.groupBox1.Controls.Add(this.btnPanico);
            this.groupBox1.Location = new System.Drawing.Point(12, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles generales";
            // 
            // btnEnciendeAspersores
            // 
            this.btnEnciendeAspersores.IconChar = FontAwesome.Sharp.IconChar.Water;
            this.btnEnciendeAspersores.IconColor = System.Drawing.Color.Cyan;
            this.btnEnciendeAspersores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnciendeAspersores.Location = new System.Drawing.Point(235, 19);
            this.btnEnciendeAspersores.Name = "btnEnciendeAspersores";
            this.btnEnciendeAspersores.Size = new System.Drawing.Size(115, 114);
            this.btnEnciendeAspersores.TabIndex = 5;
            this.btnEnciendeAspersores.Text = "Encender Aspersores";
            this.btnEnciendeAspersores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEnciendeAspersores.UseVisualStyleBackColor = true;
            // 
            // btnNotificarCelular
            // 
            this.btnNotificarCelular.IconChar = FontAwesome.Sharp.IconChar.TabletAndroid;
            this.btnNotificarCelular.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotificarCelular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotificarCelular.Location = new System.Drawing.Point(125, 19);
            this.btnNotificarCelular.Name = "btnNotificarCelular";
            this.btnNotificarCelular.Size = new System.Drawing.Size(104, 114);
            this.btnNotificarCelular.TabIndex = 4;
            this.btnNotificarCelular.Text = "Notificación Móvil";
            this.btnNotificarCelular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNotificarCelular.UseVisualStyleBackColor = true;
            // 
            // btnEncenderAlarmaLocalmente
            // 
            this.btnEncenderAlarmaLocalmente.IconChar = FontAwesome.Sharp.IconChar.Fire;
            this.btnEncenderAlarmaLocalmente.IconColor = System.Drawing.Color.Red;
            this.btnEncenderAlarmaLocalmente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEncenderAlarmaLocalmente.Location = new System.Drawing.Point(10, 19);
            this.btnEncenderAlarmaLocalmente.Name = "btnEncenderAlarmaLocalmente";
            this.btnEncenderAlarmaLocalmente.Size = new System.Drawing.Size(109, 114);
            this.btnEncenderAlarmaLocalmente.TabIndex = 3;
            this.btnEncenderAlarmaLocalmente.Text = "Encender Alarma Localmente";
            this.btnEncenderAlarmaLocalmente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEncenderAlarmaLocalmente.UseVisualStyleBackColor = true;
            this.btnEncenderAlarmaLocalmente.Click += new System.EventHandler(this.btnEncenderAlarmaLocalmente_Click);
            // 
            // btnPanico
            // 
            this.btnPanico.BackColor = System.Drawing.Color.Red;
            this.btnPanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanico.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.btnPanico.IconColor = System.Drawing.Color.Yellow;
            this.btnPanico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPanico.Location = new System.Drawing.Point(485, 19);
            this.btnPanico.Name = "btnPanico";
            this.btnPanico.Size = new System.Drawing.Size(175, 114);
            this.btnPanico.TabIndex = 2;
            this.btnPanico.Text = "PÁNICO";
            this.btnPanico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPanico.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbGrafico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Panel de control de gases - Laboratorio TecNLD";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.grbGrafico.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGrafico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMQ2;
        private System.Windows.Forms.TabPage tabMQ3;
        private FontAwesome.Sharp.IconButton btnPanico;
        private FontAwesome.Sharp.IconButton btnEncenderAlarmaLocalmente;
        private FontAwesome.Sharp.IconButton btnEnciendeAspersores;
        private FontAwesome.Sharp.IconButton btnNotificarCelular;
    }
}

