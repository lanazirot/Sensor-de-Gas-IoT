
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.grbGrafico = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMQ2 = new System.Windows.Forms.TabPage();
            this.logMq2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartSensorMQ2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabMQ3 = new System.Windows.Forms.TabPage();
            this.estadoMq3 = new System.Windows.Forms.PictureBox();
            this.logMq3 = new System.Windows.Forms.RichTextBox();
            this.lblFugaAlcohol = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnciendeAspersores = new FontAwesome.Sharp.IconButton();
            this.btnNotificarCelular = new FontAwesome.Sharp.IconButton();
            this.btnEncenderAlarmaLocalmente = new FontAwesome.Sharp.IconButton();
            this.btnPanico = new FontAwesome.Sharp.IconButton();
            this.humo = new System.Windows.Forms.PictureBox();
            this.grbGrafico.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMQ2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorMQ2)).BeginInit();
            this.tabMQ3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoMq3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humo)).BeginInit();
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
            this.tabMQ2.Controls.Add(this.humo);
            this.tabMQ2.Controls.Add(this.logMq2);
            this.tabMQ2.Controls.Add(this.label1);
            this.tabMQ2.Controls.Add(this.chartSensorMQ2);
            this.tabMQ2.Location = new System.Drawing.Point(4, 22);
            this.tabMQ2.Name = "tabMQ2";
            this.tabMQ2.Padding = new System.Windows.Forms.Padding(3);
            this.tabMQ2.Size = new System.Drawing.Size(650, 424);
            this.tabMQ2.TabIndex = 0;
            this.tabMQ2.Text = "Sensor MQ2 (Gases)";
            this.tabMQ2.UseVisualStyleBackColor = true;
            // 
            // logMq2
            // 
            this.logMq2.Location = new System.Drawing.Point(394, 53);
            this.logMq2.Name = "logMq2";
            this.logMq2.Size = new System.Drawing.Size(246, 123);
            this.logMq2.TabIndex = 4;
            this.logMq2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detección de humo y gases";
            // 
            // chartSensorMQ2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSensorMQ2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSensorMQ2.Legends.Add(legend2);
            this.chartSensorMQ2.Location = new System.Drawing.Point(6, 53);
            this.chartSensorMQ2.Name = "chartSensorMQ2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "PPM";
            this.chartSensorMQ2.Series.Add(series2);
            this.chartSensorMQ2.Size = new System.Drawing.Size(382, 365);
            this.chartSensorMQ2.TabIndex = 2;
            this.chartSensorMQ2.Text = "Sensor MQ2";
            // 
            // tabMQ3
            // 
            this.tabMQ3.Controls.Add(this.estadoMq3);
            this.tabMQ3.Controls.Add(this.logMq3);
            this.tabMQ3.Controls.Add(this.lblFugaAlcohol);
            this.tabMQ3.Location = new System.Drawing.Point(4, 22);
            this.tabMQ3.Name = "tabMQ3";
            this.tabMQ3.Padding = new System.Windows.Forms.Padding(3);
            this.tabMQ3.Size = new System.Drawing.Size(650, 424);
            this.tabMQ3.TabIndex = 1;
            this.tabMQ3.Text = "Sensor MQ3 (Alcoholes)";
            this.tabMQ3.UseVisualStyleBackColor = true;
            // 
            // estadoMq3
            // 
            this.estadoMq3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.estadoMq3.Image = ((System.Drawing.Image)(resources.GetObject("estadoMq3.Image")));
            this.estadoMq3.Location = new System.Drawing.Point(295, 53);
            this.estadoMq3.Name = "estadoMq3";
            this.estadoMq3.Size = new System.Drawing.Size(349, 365);
            this.estadoMq3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.estadoMq3.TabIndex = 6;
            this.estadoMq3.TabStop = false;
            // 
            // logMq3
            // 
            this.logMq3.Location = new System.Drawing.Point(6, 53);
            this.logMq3.Name = "logMq3";
            this.logMq3.Size = new System.Drawing.Size(283, 365);
            this.logMq3.TabIndex = 5;
            this.logMq3.Text = "";
            // 
            // lblFugaAlcohol
            // 
            this.lblFugaAlcohol.AutoSize = true;
            this.lblFugaAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFugaAlcohol.Location = new System.Drawing.Point(153, 13);
            this.lblFugaAlcohol.Name = "lblFugaAlcohol";
            this.lblFugaAlcohol.Size = new System.Drawing.Size(349, 37);
            this.lblFugaAlcohol.TabIndex = 0;
            this.lblFugaAlcohol.Text = "Detección de alcholes";
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
            this.btnNotificarCelular.Click += new System.EventHandler(this.btnNotificarCelular_Click);
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
            this.btnPanico.Click += new System.EventHandler(this.btnPanico_Click);
            // 
            // humo
            // 
            this.humo.Image = ((System.Drawing.Image)(resources.GetObject("humo.Image")));
            this.humo.Location = new System.Drawing.Point(394, 182);
            this.humo.Name = "humo";
            this.humo.Size = new System.Drawing.Size(245, 235);
            this.humo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humo.TabIndex = 5;
            this.humo.TabStop = false;
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
            this.tabMQ2.ResumeLayout(false);
            this.tabMQ2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorMQ2)).EndInit();
            this.tabMQ3.ResumeLayout(false);
            this.tabMQ3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoMq3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.humo)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorMQ2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFugaAlcohol;
        private System.Windows.Forms.RichTextBox logMq2;
        private System.Windows.Forms.PictureBox estadoMq3;
        private System.Windows.Forms.RichTextBox logMq3;
        private System.Windows.Forms.PictureBox humo;
    }
}

