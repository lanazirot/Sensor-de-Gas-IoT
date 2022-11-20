
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPanico = new System.Windows.Forms.Button();
            this.btnEncenderAlarma = new System.Windows.Forms.Button();
            this.btnNotificacionIoT = new System.Windows.Forms.Button();
            this.btnEncenderAspersores = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGrafico
            // 
            this.grbGrafico.Location = new System.Drawing.Point(12, 12);
            this.grbGrafico.Name = "grbGrafico";
            this.grbGrafico.Size = new System.Drawing.Size(670, 475);
            this.grbGrafico.TabIndex = 0;
            this.grbGrafico.TabStop = false;
            this.grbGrafico.Text = "Visor general";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncenderAspersores);
            this.groupBox1.Controls.Add(this.btnNotificacionIoT);
            this.groupBox1.Controls.Add(this.btnEncenderAlarma);
            this.groupBox1.Location = new System.Drawing.Point(12, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles generales";
            // 
            // btnPanico
            // 
            this.btnPanico.BackColor = System.Drawing.Color.Red;
            this.btnPanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPanico.Location = new System.Drawing.Point(12, 700);
            this.btnPanico.Name = "btnPanico";
            this.btnPanico.Size = new System.Drawing.Size(670, 44);
            this.btnPanico.TabIndex = 2;
            this.btnPanico.Text = "PANICO";
            this.btnPanico.UseVisualStyleBackColor = false;
            this.btnPanico.Click += new System.EventHandler(this.btnPanico_Click);
            // 
            // btnEncenderAlarma
            // 
            this.btnEncenderAlarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncenderAlarma.Location = new System.Drawing.Point(6, 19);
            this.btnEncenderAlarma.Name = "btnEncenderAlarma";
            this.btnEncenderAlarma.Size = new System.Drawing.Size(250, 176);
            this.btnEncenderAlarma.TabIndex = 0;
            this.btnEncenderAlarma.Text = "Encender alarma local";
            this.btnEncenderAlarma.UseVisualStyleBackColor = true;
            // 
            // btnNotificacionIoT
            // 
            this.btnNotificacionIoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificacionIoT.Location = new System.Drawing.Point(262, 19);
            this.btnNotificacionIoT.Name = "btnNotificacionIoT";
            this.btnNotificacionIoT.Size = new System.Drawing.Size(145, 176);
            this.btnNotificacionIoT.TabIndex = 1;
            this.btnNotificacionIoT.Text = "Notificación celular (manual)";
            this.btnNotificacionIoT.UseVisualStyleBackColor = true;
            // 
            // btnEncenderAspersores
            // 
            this.btnEncenderAspersores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncenderAspersores.Location = new System.Drawing.Point(413, 19);
            this.btnEncenderAspersores.Name = "btnEncenderAspersores";
            this.btnEncenderAspersores.Size = new System.Drawing.Size(251, 176);
            this.btnEncenderAspersores.TabIndex = 2;
            this.btnEncenderAspersores.Text = "Encender aspersores de agua";
            this.btnEncenderAspersores.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 756);
            this.Controls.Add(this.btnPanico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbGrafico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Panel de control de gases - Laboratorio TecNLD";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGrafico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPanico;
        private System.Windows.Forms.Button btnEncenderAspersores;
        private System.Windows.Forms.Button btnNotificacionIoT;
        private System.Windows.Forms.Button btnEncenderAlarma;
    }
}

