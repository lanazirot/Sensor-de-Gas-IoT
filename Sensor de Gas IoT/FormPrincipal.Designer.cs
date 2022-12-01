
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grbGrafico = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMQ2 = new System.Windows.Forms.TabPage();
            this.humo = new System.Windows.Forms.PictureBox();
            this.logMq2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartSensorMQ2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabMQ3 = new System.Windows.Forms.TabPage();
            this.chartSensorMQ3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.alcohol = new System.Windows.Forms.PictureBox();
            this.logMq3 = new System.Windows.Forms.RichTextBox();
            this.lblFugaAlcohol = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMq2 = new System.Windows.Forms.Label();
            this.lblMq3 = new System.Windows.Forms.Label();
            this.ventilador = new System.Windows.Forms.PictureBox();
            this.btnEnciendeAspersores = new FontAwesome.Sharp.IconButton();
            this.btnNotificarCelular = new FontAwesome.Sharp.IconButton();
            this.btnPanico = new FontAwesome.Sharp.IconButton();
            this.grbGrafico.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMQ2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorMQ2)).BeginInit();
            this.tabMQ3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorMQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcohol)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventilador)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGrafico
            // 
            this.grbGrafico.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grbGrafico.Controls.Add(this.tabControl1);
            this.grbGrafico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbGrafico.Location = new System.Drawing.Point(14, 13);
            this.grbGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGrafico.Name = "grbGrafico";
            this.grbGrafico.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGrafico.Size = new System.Drawing.Size(1051, 512);
            this.grbGrafico.TabIndex = 0;
            this.grbGrafico.TabStop = false;
            this.grbGrafico.Text = "Visor general";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMQ2);
            this.tabControl1.Controls.Add(this.tabMQ3);
            this.tabControl1.Location = new System.Drawing.Point(7, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMQ2
            // 
            this.tabMQ2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabMQ2.Controls.Add(this.humo);
            this.tabMQ2.Controls.Add(this.logMq2);
            this.tabMQ2.Controls.Add(this.label1);
            this.tabMQ2.Controls.Add(this.chartSensorMQ2);
            this.tabMQ2.ForeColor = System.Drawing.Color.Chartreuse;
            this.tabMQ2.Location = new System.Drawing.Point(4, 23);
            this.tabMQ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMQ2.Name = "tabMQ2";
            this.tabMQ2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMQ2.Size = new System.Drawing.Size(1029, 459);
            this.tabMQ2.TabIndex = 0;
            this.tabMQ2.Text = "Sensor MQ2 (Gases)";
            // 
            // humo
            // 
            this.humo.Image = ((System.Drawing.Image)(resources.GetObject("humo.Image")));
            this.humo.Location = new System.Drawing.Point(943, 370);
            this.humo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.humo.Name = "humo";
            this.humo.Size = new System.Drawing.Size(80, 80);
            this.humo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.humo.TabIndex = 5;
            this.humo.TabStop = false;
            // 
            // logMq2
            // 
            this.logMq2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logMq2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logMq2.Location = new System.Drawing.Point(460, 57);
            this.logMq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logMq2.Name = "logMq2";
            this.logMq2.ReadOnly = true;
            this.logMq2.Size = new System.Drawing.Size(563, 103);
            this.logMq2.TabIndex = 4;
            this.logMq2.Text = "";
            this.logMq2.TextChanged += new System.EventHandler(this.logMq2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(265, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detección de humo y gases";
            // 
            // chartSensorMQ2
            // 
            this.chartSensorMQ2.BackColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ2.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ2.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ2.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ2.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ2.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.Area3DStyle.PointDepth = 25;
            chartArea4.Area3DStyle.Rotation = 15;
            chartArea4.Area3DStyle.WallWidth = 9;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.ToolTip = "MQ2";
            chartArea4.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX2.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea4.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea4.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            chartArea4.ShadowColor = System.Drawing.Color.White;
            this.chartSensorMQ2.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.TitleFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartSensorMQ2.Legends.Add(legend4);
            this.chartSensorMQ2.Location = new System.Drawing.Point(7, 57);
            this.chartSensorMQ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartSensorMQ2.Name = "chartSensorMQ2";
            this.chartSensorMQ2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartSensorMQ2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.White};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "MQ2";
            this.chartSensorMQ2.Series.Add(series4);
            this.chartSensorMQ2.Size = new System.Drawing.Size(446, 393);
            this.chartSensorMQ2.TabIndex = 2;
            this.chartSensorMQ2.Text = "Sensor MQ2";
            // 
            // tabMQ3
            // 
            this.tabMQ3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabMQ3.Controls.Add(this.chartSensorMQ3);
            this.tabMQ3.Controls.Add(this.alcohol);
            this.tabMQ3.Controls.Add(this.logMq3);
            this.tabMQ3.Controls.Add(this.lblFugaAlcohol);
            this.tabMQ3.Location = new System.Drawing.Point(4, 23);
            this.tabMQ3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMQ3.Name = "tabMQ3";
            this.tabMQ3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMQ3.Size = new System.Drawing.Size(1029, 459);
            this.tabMQ3.TabIndex = 1;
            this.tabMQ3.Text = "Sensor MQ3 (Alcoholes)";
            // 
            // chartSensorMQ3
            // 
            this.chartSensorMQ3.BackColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ3.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ3.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chartSensorMQ3.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.PointDepth = 25;
            chartArea3.Area3DStyle.Rotation = 15;
            chartArea3.Area3DStyle.WallWidth = 9;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartSensorMQ3.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartSensorMQ3.Legends.Add(legend3);
            this.chartSensorMQ3.Location = new System.Drawing.Point(7, 57);
            this.chartSensorMQ3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartSensorMQ3.Name = "chartSensorMQ3";
            this.chartSensorMQ3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartSensorMQ3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.White};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.DarkSlateGray;
            series3.Legend = "Legend1";
            series3.Name = "MQ3";
            series3.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Bisque;
            this.chartSensorMQ3.Series.Add(series3);
            this.chartSensorMQ3.Size = new System.Drawing.Size(446, 393);
            this.chartSensorMQ3.TabIndex = 7;
            this.chartSensorMQ3.Text = "Sensor MQ2";
            // 
            // alcohol
            // 
            this.alcohol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.alcohol.Image = ((System.Drawing.Image)(resources.GetObject("alcohol.Image")));
            this.alcohol.Location = new System.Drawing.Point(943, 370);
            this.alcohol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alcohol.Name = "alcohol";
            this.alcohol.Size = new System.Drawing.Size(80, 80);
            this.alcohol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alcohol.TabIndex = 6;
            this.alcohol.TabStop = false;
            // 
            // logMq3
            // 
            this.logMq3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logMq3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logMq3.Location = new System.Drawing.Point(460, 57);
            this.logMq3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logMq3.Name = "logMq3";
            this.logMq3.ReadOnly = true;
            this.logMq3.Size = new System.Drawing.Size(563, 103);
            this.logMq3.TabIndex = 5;
            this.logMq3.Text = "";
            this.logMq3.TextChanged += new System.EventHandler(this.logMq3_TextChanged);
            // 
            // lblFugaAlcohol
            // 
            this.lblFugaAlcohol.AutoSize = true;
            this.lblFugaAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFugaAlcohol.Location = new System.Drawing.Point(320, 14);
            this.lblFugaAlcohol.Name = "lblFugaAlcohol";
            this.lblFugaAlcohol.Size = new System.Drawing.Size(349, 37);
            this.lblFugaAlcohol.TabIndex = 0;
            this.lblFugaAlcohol.Text = "Detección de alcholes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.ventilador);
            this.groupBox1.Controls.Add(this.btnEnciendeAspersores);
            this.groupBox1.Controls.Add(this.btnNotificarCelular);
            this.groupBox1.Controls.Add(this.btnPanico);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 531);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1051, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles generales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblMq2);
            this.panel1.Controls.Add(this.lblMq3);
            this.panel1.Location = new System.Drawing.Point(306, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 122);
            this.panel1.TabIndex = 11;
            // 
            // lblMq2
            // 
            this.lblMq2.AutoSize = true;
            this.lblMq2.BackColor = System.Drawing.Color.Black;
            this.lblMq2.Font = new System.Drawing.Font("Digital-7 Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMq2.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblMq2.Location = new System.Drawing.Point(53, 69);
            this.lblMq2.Name = "lblMq2";
            this.lblMq2.Size = new System.Drawing.Size(144, 31);
            this.lblMq2.TabIndex = 8;
            this.lblMq2.Text = "MQ2: 0 PPM";
            // 
            // lblMq3
            // 
            this.lblMq3.AutoSize = true;
            this.lblMq3.BackColor = System.Drawing.Color.Black;
            this.lblMq3.Font = new System.Drawing.Font("Digital-7 Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMq3.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblMq3.Location = new System.Drawing.Point(53, 14);
            this.lblMq3.Name = "lblMq3";
            this.lblMq3.Size = new System.Drawing.Size(144, 31);
            this.lblMq3.TabIndex = 9;
            this.lblMq3.Text = "MQ3: 0 PPM";
            // 
            // ventilador
            // 
            this.ventilador.Image = ((System.Drawing.Image)(resources.GetObject("ventilador.Image")));
            this.ventilador.Location = new System.Drawing.Point(663, 20);
            this.ventilador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ventilador.Name = "ventilador";
            this.ventilador.Size = new System.Drawing.Size(165, 124);
            this.ventilador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventilador.TabIndex = 10;
            this.ventilador.TabStop = false;
            this.ventilador.Visible = false;
            // 
            // btnEnciendeAspersores
            // 
            this.btnEnciendeAspersores.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEnciendeAspersores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnciendeAspersores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnciendeAspersores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnciendeAspersores.IconChar = FontAwesome.Sharp.IconChar.Fan;
            this.btnEnciendeAspersores.IconColor = System.Drawing.Color.DimGray;
            this.btnEnciendeAspersores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnciendeAspersores.Location = new System.Drawing.Point(113, 20);
            this.btnEnciendeAspersores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnciendeAspersores.Name = "btnEnciendeAspersores";
            this.btnEnciendeAspersores.Size = new System.Drawing.Size(93, 124);
            this.btnEnciendeAspersores.TabIndex = 5;
            this.btnEnciendeAspersores.Text = "Encender ventiladores";
            this.btnEnciendeAspersores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEnciendeAspersores.UseVisualStyleBackColor = false;
            this.btnEnciendeAspersores.Click += new System.EventHandler(this.btnEnciendeVentiladores_Click);
            // 
            // btnNotificarCelular
            // 
            this.btnNotificarCelular.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNotificarCelular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificarCelular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNotificarCelular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNotificarCelular.IconChar = FontAwesome.Sharp.IconChar.TabletAndroid;
            this.btnNotificarCelular.IconColor = System.Drawing.Color.DimGray;
            this.btnNotificarCelular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotificarCelular.Location = new System.Drawing.Point(12, 20);
            this.btnNotificarCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotificarCelular.Name = "btnNotificarCelular";
            this.btnNotificarCelular.Size = new System.Drawing.Size(94, 124);
            this.btnNotificarCelular.TabIndex = 4;
            this.btnNotificarCelular.Text = "Notificación Móvil";
            this.btnNotificarCelular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNotificarCelular.UseVisualStyleBackColor = false;
            this.btnNotificarCelular.Click += new System.EventHandler(this.btnNotificarCelular_Click);
            // 
            // btnPanico
            // 
            this.btnPanico.BackColor = System.Drawing.Color.Crimson;
            this.btnPanico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPanico.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.btnPanico.IconColor = System.Drawing.Color.Yellow;
            this.btnPanico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPanico.Location = new System.Drawing.Point(835, 18);
            this.btnPanico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPanico.Name = "btnPanico";
            this.btnPanico.Size = new System.Drawing.Size(204, 124);
            this.btnPanico.TabIndex = 2;
            this.btnPanico.Text = "  PÁNICO";
            this.btnPanico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPanico.UseVisualStyleBackColor = false;
            this.btnPanico.Click += new System.EventHandler(this.btnPanico_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1079, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbGrafico);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de control de gases - Laboratorio TecNLD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.grbGrafico.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabMQ2.ResumeLayout(false);
            this.tabMQ2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorMQ2)).EndInit();
            this.tabMQ3.ResumeLayout(false);
            this.tabMQ3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensorMQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alcohol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventilador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGrafico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMQ2;
        private System.Windows.Forms.TabPage tabMQ3;
        private FontAwesome.Sharp.IconButton btnPanico;
        private FontAwesome.Sharp.IconButton btnEnciendeAspersores;
        private FontAwesome.Sharp.IconButton btnNotificarCelular;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorMQ2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFugaAlcohol;
        private System.Windows.Forms.RichTextBox logMq2;
        private System.Windows.Forms.PictureBox alcohol;
        private System.Windows.Forms.RichTextBox logMq3;
        private System.Windows.Forms.PictureBox humo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensorMQ3;
        private System.Windows.Forms.Label lblMq2;
        private System.Windows.Forms.Label lblMq3;
        private System.Windows.Forms.PictureBox ventilador;
        private System.Windows.Forms.Panel panel1;
    }
}

