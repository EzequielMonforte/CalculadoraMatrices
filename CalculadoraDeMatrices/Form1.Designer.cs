﻿namespace CalculadoraDeMatrices
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.LB_MatrizPrecargada = new System.Windows.Forms.Label();
			this.LB_Resultado = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TXB_filas1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TXB_columnas1 = new System.Windows.Forms.TextBox();
			this.BT_CreateMatriz1 = new System.Windows.Forms.Button();
			this.BT_CreateMatriz2 = new System.Windows.Forms.Button();
			this.TXB_columnas2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TXB_filas2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.GB_CreateM1 = new System.Windows.Forms.GroupBox();
			this.GP_CreateM2 = new System.Windows.Forms.GroupBox();
			this.Mat1 = new System.Windows.Forms.GroupBox();
			this.Mat2 = new System.Windows.Forms.GroupBox();
			this.MatRes = new System.Windows.Forms.GroupBox();
			this.BT_Suma = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.BT_Escalar = new System.Windows.Forms.Button();
			this.BT_Escalar2 = new System.Windows.Forms.Button();
			this.BT_Escalar3 = new System.Windows.Forms.Button();
			this.TXB_Escalar1 = new System.Windows.Forms.TextBox();
			this.TXB_Escalar2 = new System.Windows.Forms.TextBox();
			this.TXB_EscalarRes = new System.Windows.Forms.TextBox();
			this.BT_Multiplicar = new System.Windows.Forms.Button();
			this.BT_Restar = new System.Windows.Forms.Button();
			this.BT_Tmat1 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.BT_Tmat2 = new System.Windows.Forms.Button();
			this.BT_TmatR = new System.Windows.Forms.Button();
			this.GB_CreateM1.SuspendLayout();
			this.GP_CreateM2.SuspendLayout();
			this.SuspendLayout();
			// 
			// LB_MatrizPrecargada
			// 
			this.LB_MatrizPrecargada.AutoSize = true;
			this.LB_MatrizPrecargada.Location = new System.Drawing.Point(16, 91);
			this.LB_MatrizPrecargada.Name = "LB_MatrizPrecargada";
			this.LB_MatrizPrecargada.Size = new System.Drawing.Size(0, 17);
			this.LB_MatrizPrecargada.TabIndex = 4;
			// 
			// LB_Resultado
			// 
			this.LB_Resultado.AutoSize = true;
			this.LB_Resultado.Location = new System.Drawing.Point(13, 112);
			this.LB_Resultado.Name = "LB_Resultado";
			this.LB_Resultado.Size = new System.Drawing.Size(0, 17);
			this.LB_Resultado.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Matriz 1";
			// 
			// TXB_filas1
			// 
			this.TXB_filas1.Location = new System.Drawing.Point(70, 38);
			this.TXB_filas1.Name = "TXB_filas1";
			this.TXB_filas1.Size = new System.Drawing.Size(53, 22);
			this.TXB_filas1.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(129, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "X";
			// 
			// TXB_columnas1
			// 
			this.TXB_columnas1.Location = new System.Drawing.Point(152, 38);
			this.TXB_columnas1.Name = "TXB_columnas1";
			this.TXB_columnas1.Size = new System.Drawing.Size(53, 22);
			this.TXB_columnas1.TabIndex = 11;
			// 
			// BT_CreateMatriz1
			// 
			this.BT_CreateMatriz1.Location = new System.Drawing.Point(231, 38);
			this.BT_CreateMatriz1.Name = "BT_CreateMatriz1";
			this.BT_CreateMatriz1.Size = new System.Drawing.Size(75, 23);
			this.BT_CreateMatriz1.TabIndex = 12;
			this.BT_CreateMatriz1.Text = "Crear";
			this.BT_CreateMatriz1.UseVisualStyleBackColor = true;
			this.BT_CreateMatriz1.Click += new System.EventHandler(this.BT_CreateMatriz2_Click);
			// 
			// BT_CreateMatriz2
			// 
			this.BT_CreateMatriz2.Location = new System.Drawing.Point(231, 38);
			this.BT_CreateMatriz2.Name = "BT_CreateMatriz2";
			this.BT_CreateMatriz2.Size = new System.Drawing.Size(75, 23);
			this.BT_CreateMatriz2.TabIndex = 17;
			this.BT_CreateMatriz2.Text = "Crear";
			this.BT_CreateMatriz2.UseVisualStyleBackColor = true;
			this.BT_CreateMatriz2.Click += new System.EventHandler(this.BT_CreateMatriz2_Click);
			// 
			// TXB_columnas2
			// 
			this.TXB_columnas2.Location = new System.Drawing.Point(152, 38);
			this.TXB_columnas2.Name = "TXB_columnas2";
			this.TXB_columnas2.Size = new System.Drawing.Size(53, 22);
			this.TXB_columnas2.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(129, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "X";
			// 
			// TXB_filas2
			// 
			this.TXB_filas2.Location = new System.Drawing.Point(70, 38);
			this.TXB_filas2.Name = "TXB_filas2";
			this.TXB_filas2.Size = new System.Drawing.Size(53, 22);
			this.TXB_filas2.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "Matriz 2";
			// 
			// GB_CreateM1
			// 
			this.GB_CreateM1.AutoSize = true;
			this.GB_CreateM1.Controls.Add(this.label1);
			this.GB_CreateM1.Controls.Add(this.TXB_filas1);
			this.GB_CreateM1.Controls.Add(this.label2);
			this.GB_CreateM1.Controls.Add(this.TXB_columnas1);
			this.GB_CreateM1.Controls.Add(this.BT_CreateMatriz1);
			this.GB_CreateM1.Location = new System.Drawing.Point(22, 12);
			this.GB_CreateM1.Name = "GB_CreateM1";
			this.GB_CreateM1.Size = new System.Drawing.Size(312, 82);
			this.GB_CreateM1.TabIndex = 18;
			this.GB_CreateM1.TabStop = false;
			// 
			// GP_CreateM2
			// 
			this.GP_CreateM2.AutoSize = true;
			this.GP_CreateM2.Controls.Add(this.label4);
			this.GP_CreateM2.Controls.Add(this.TXB_filas2);
			this.GP_CreateM2.Controls.Add(this.BT_CreateMatriz2);
			this.GP_CreateM2.Controls.Add(this.label3);
			this.GP_CreateM2.Controls.Add(this.TXB_columnas2);
			this.GP_CreateM2.Location = new System.Drawing.Point(359, 12);
			this.GP_CreateM2.Margin = new System.Windows.Forms.Padding(0);
			this.GP_CreateM2.Name = "GP_CreateM2";
			this.GP_CreateM2.Size = new System.Drawing.Size(339, 82);
			this.GP_CreateM2.TabIndex = 19;
			this.GP_CreateM2.TabStop = false;
			// 
			// Mat1
			// 
			this.Mat1.Location = new System.Drawing.Point(22, 112);
			this.Mat1.Name = "Mat1";
			this.Mat1.Size = new System.Drawing.Size(377, 203);
			this.Mat1.TabIndex = 20;
			this.Mat1.TabStop = false;
			this.Mat1.Text = "Matriz 1";
			// 
			// Mat2
			// 
			this.Mat2.Location = new System.Drawing.Point(432, 112);
			this.Mat2.Name = "Mat2";
			this.Mat2.Size = new System.Drawing.Size(377, 203);
			this.Mat2.TabIndex = 21;
			this.Mat2.TabStop = false;
			this.Mat2.Text = "Matriz 2";
			// 
			// MatRes
			// 
			this.MatRes.Location = new System.Drawing.Point(857, 112);
			this.MatRes.Name = "MatRes";
			this.MatRes.Size = new System.Drawing.Size(377, 203);
			this.MatRes.TabIndex = 22;
			this.MatRes.TabStop = false;
			this.MatRes.Text = "Resultado";
			// 
			// BT_Suma
			// 
			this.BT_Suma.Location = new System.Drawing.Point(432, 322);
			this.BT_Suma.Name = "BT_Suma";
			this.BT_Suma.Size = new System.Drawing.Size(83, 23);
			this.BT_Suma.TabIndex = 23;
			this.BT_Suma.Text = "Sumar";
			this.BT_Suma.UseVisualStyleBackColor = true;
			this.BT_Suma.Click += new System.EventHandler(this.ButtonSumar_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(784, 341);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 24;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// BT_Escalar
			// 
			this.BT_Escalar.Location = new System.Drawing.Point(319, 321);
			this.BT_Escalar.Name = "BT_Escalar";
			this.BT_Escalar.Size = new System.Drawing.Size(32, 23);
			this.BT_Escalar.TabIndex = 25;
			this.BT_Escalar.Text = "k";
			this.BT_Escalar.UseVisualStyleBackColor = true;
			this.BT_Escalar.Click += new System.EventHandler(this.BT_Escalar_Click_1);
			// 
			// BT_Escalar2
			// 
			this.BT_Escalar2.Location = new System.Drawing.Point(733, 321);
			this.BT_Escalar2.Name = "BT_Escalar2";
			this.BT_Escalar2.Size = new System.Drawing.Size(32, 23);
			this.BT_Escalar2.TabIndex = 26;
			this.BT_Escalar2.Text = "k";
			this.BT_Escalar2.UseVisualStyleBackColor = true;
			this.BT_Escalar2.Click += new System.EventHandler(this.BT_Escalar2_Click);
			// 
			// BT_Escalar3
			// 
			this.BT_Escalar3.Location = new System.Drawing.Point(1193, 321);
			this.BT_Escalar3.Name = "BT_Escalar3";
			this.BT_Escalar3.Size = new System.Drawing.Size(32, 23);
			this.BT_Escalar3.TabIndex = 27;
			this.BT_Escalar3.Text = "k";
			this.BT_Escalar3.UseVisualStyleBackColor = true;
			this.BT_Escalar3.Click += new System.EventHandler(this.BT_Escalar3_Click);
			// 
			// TXB_Escalar1
			// 
			this.TXB_Escalar1.Location = new System.Drawing.Point(267, 321);
			this.TXB_Escalar1.Name = "TXB_Escalar1";
			this.TXB_Escalar1.Size = new System.Drawing.Size(46, 22);
			this.TXB_Escalar1.TabIndex = 28;
			// 
			// TXB_Escalar2
			// 
			this.TXB_Escalar2.Location = new System.Drawing.Point(681, 322);
			this.TXB_Escalar2.Name = "TXB_Escalar2";
			this.TXB_Escalar2.Size = new System.Drawing.Size(46, 22);
			this.TXB_Escalar2.TabIndex = 29;
			// 
			// TXB_EscalarRes
			// 
			this.TXB_EscalarRes.Location = new System.Drawing.Point(1141, 322);
			this.TXB_EscalarRes.Name = "TXB_EscalarRes";
			this.TXB_EscalarRes.Size = new System.Drawing.Size(46, 22);
			this.TXB_EscalarRes.TabIndex = 30;
			// 
			// BT_Multiplicar
			// 
			this.BT_Multiplicar.Location = new System.Drawing.Point(429, 402);
			this.BT_Multiplicar.Name = "BT_Multiplicar";
			this.BT_Multiplicar.Size = new System.Drawing.Size(83, 23);
			this.BT_Multiplicar.TabIndex = 31;
			this.BT_Multiplicar.Text = "Multiplicar";
			this.BT_Multiplicar.UseVisualStyleBackColor = true;
			this.BT_Multiplicar.Click += new System.EventHandler(this.BT_Multiplicar_Click);
			// 
			// BT_Restar
			// 
			this.BT_Restar.Location = new System.Drawing.Point(432, 363);
			this.BT_Restar.Name = "BT_Restar";
			this.BT_Restar.Size = new System.Drawing.Size(83, 23);
			this.BT_Restar.TabIndex = 32;
			this.BT_Restar.Text = "Restar";
			this.BT_Restar.UseVisualStyleBackColor = true;
			this.BT_Restar.Click += new System.EventHandler(this.BT_Restar_Click);
			// 
			// BT_Tmat1
			// 
			this.BT_Tmat1.Location = new System.Drawing.Point(400, 121);
			this.BT_Tmat1.Name = "BT_Tmat1";
			this.BT_Tmat1.Size = new System.Drawing.Size(26, 23);
			this.BT_Tmat1.TabIndex = 33;
			this.BT_Tmat1.Text = "t";
			this.BT_Tmat1.UseVisualStyleBackColor = true;
			this.BT_Tmat1.Click += new System.EventHandler(this.BT_Tmat1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(630, 277);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(26, 23);
			this.button1.TabIndex = 34;
			this.button1.Text = "t";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// BT_Tmat2
			// 
			this.BT_Tmat2.Location = new System.Drawing.Point(815, 121);
			this.BT_Tmat2.Name = "BT_Tmat2";
			this.BT_Tmat2.Size = new System.Drawing.Size(26, 23);
			this.BT_Tmat2.TabIndex = 35;
			this.BT_Tmat2.Text = "t";
			this.BT_Tmat2.UseVisualStyleBackColor = true;
			this.BT_Tmat2.Click += new System.EventHandler(this.BT_Tmat2_Click);
			// 
			// BT_TmatR
			// 
			this.BT_TmatR.Location = new System.Drawing.Point(1240, 121);
			this.BT_TmatR.Name = "BT_TmatR";
			this.BT_TmatR.Size = new System.Drawing.Size(26, 23);
			this.BT_TmatR.TabIndex = 36;
			this.BT_TmatR.Text = "t";
			this.BT_TmatR.UseVisualStyleBackColor = true;
			this.BT_TmatR.Click += new System.EventHandler(this.BT_TmatR_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1286, 576);
			this.Controls.Add(this.BT_TmatR);
			this.Controls.Add(this.BT_Tmat2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BT_Tmat1);
			this.Controls.Add(this.BT_Restar);
			this.Controls.Add(this.BT_Multiplicar);
			this.Controls.Add(this.TXB_EscalarRes);
			this.Controls.Add(this.TXB_Escalar2);
			this.Controls.Add(this.TXB_Escalar1);
			this.Controls.Add(this.BT_Escalar3);
			this.Controls.Add(this.BT_Escalar2);
			this.Controls.Add(this.BT_Escalar);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.BT_Suma);
			this.Controls.Add(this.GB_CreateM1);
			this.Controls.Add(this.MatRes);
			this.Controls.Add(this.Mat2);
			this.Controls.Add(this.Mat1);
			this.Controls.Add(this.GP_CreateM2);
			this.Controls.Add(this.LB_Resultado);
			this.Controls.Add(this.LB_MatrizPrecargada);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.GB_CreateM1.ResumeLayout(false);
			this.GB_CreateM1.PerformLayout();
			this.GP_CreateM2.ResumeLayout(false);
			this.GP_CreateM2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LB_MatrizPrecargada;
		private System.Windows.Forms.Label LB_Resultado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TXB_filas1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TXB_columnas1;
		private System.Windows.Forms.Button BT_CreateMatriz1;
		private System.Windows.Forms.Button BT_CreateMatriz2;
		private System.Windows.Forms.TextBox TXB_columnas2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TXB_filas2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox GB_CreateM1;
		private System.Windows.Forms.GroupBox GP_CreateM2;
		private System.Windows.Forms.GroupBox Mat1;
		private System.Windows.Forms.GroupBox Mat2;
		private System.Windows.Forms.GroupBox MatRes;
		private System.Windows.Forms.Button BT_Suma;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button BT_Escalar;
		private System.Windows.Forms.Button BT_Escalar2;
		private System.Windows.Forms.Button BT_Escalar3;
		private System.Windows.Forms.TextBox TXB_Escalar1;
		private System.Windows.Forms.TextBox TXB_Escalar2;
		private System.Windows.Forms.TextBox TXB_EscalarRes;
		private System.Windows.Forms.Button BT_Multiplicar;
		private System.Windows.Forms.Button BT_Restar;
		private System.Windows.Forms.Button BT_Tmat1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button BT_Tmat2;
		private System.Windows.Forms.Button BT_TmatR;
	}
}

