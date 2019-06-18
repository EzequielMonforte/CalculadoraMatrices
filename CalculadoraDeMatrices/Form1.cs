using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMatrices
{
	public partial class Form1 : Form
	{
		List<double[]> listaMatrices = new List<double[]>();

		int filasMat1;
		int filasMat2;
		int colMat1;
		int colMat2;

		double[,] matriz1;
		double[,] matriz2;
		double[,] matrizRes;

		DataGridView datagrid1;
		DataGridView datagrid2;
		DataGridView datagridRes;
		public Form1()
		{
			InitializeComponent();
				
		}

		private void Datagrid2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{

			CalculosMatrices.DataGridToMat(datagrid2, matriz2);
		}

		private void Datagrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			CalculosMatrices.DataGridToMat(datagrid1, matriz1);
		}

		#region Create Vector

		private void BT_CreateMatriz2_Click(object sender, EventArgs e)
		{
			var button = sender as Button;
			var arrTextbox =button.Parent.Controls.OfType<TextBox>().ToArray();

			if (button.Parent.Name == "GB_CreateM1")
			{
				try
				{
					filasMat1 = int.Parse(arrTextbox[0].Text);
					colMat1 = int.Parse(arrTextbox[1].Text);
					matriz1 = new double[filasMat1, colMat1];
				}
				catch (Exception)
				{

					MessageBox.Show("los valores ingresados no son numericos");
				}
			
				datagrid1 = CreateDataGridMat(datagrid1, filasMat1, colMat1);
				datagrid1.CellValueChanged += Datagrid1_CellValueChanged;
				
				ShowMat( Mat1, datagrid1);

			}
			else if (button.Parent.Name == "GP_CreateM2") {
				try
				{
					filasMat2 = int.Parse(arrTextbox[0].Text);
					colMat2 = int.Parse(arrTextbox[1].Text);
					matriz2 = new double[filasMat2, colMat2];
				}
				catch (Exception)
				{

					MessageBox.Show("los valores ingresados no son numericos");
				}

				datagrid2 = CreateDataGridMat(datagrid2, filasMat2, colMat2);
				datagrid2.CellValueChanged += Datagrid2_CellValueChanged;
				ShowMat( Mat2, datagrid2);
			}


		}

		private void ShowMat(GroupBox group, DataGridView datagrid)
		{
			group.Controls.Clear();
			group.Controls.Add(datagrid);
			datagrid.Size = datagrid.Parent.Size;
		}

		private DataGridView CreateDataGridMat(DataGridView dat,  int rows, int col) {

			if (rows > 0 && col > 0)
			{
				dat = new DataGridView();
				dat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				dat.ColumnCount = col;
				dat.Rows.Add(rows);
				dat.AllowUserToAddRows = false;
				dat.ColumnHeadersVisible = false;
				dat.RowHeadersVisible = false;
				return dat;
			}
			else return new DataGridView();
			
			
		}

		private void RellenarMat(DataGridView dat, double n) {
			for (int i = 0; i < dat.Columns.Count; i++) {
				for (int j = 0; j < dat.Rows.Count; j++)
				{
					dat.Rows[j].Cells[i].Value = n;
				}
			}

		}


		#endregion

		#region operaciones
		private void ButtonSumar_Click(object sender, EventArgs e)
		{
			CalculosMatrices.DataGridToMat(datagrid1, matriz1);
			CalculosMatrices.DataGridToMat(datagrid2, matriz2);
			try
			{
				var matRes = CalculosMatrices.sumarMatriz(matriz1, matriz2);
				matrizRes = matRes;
				datagridRes = CreateDataGridMat(datagridRes, matRes.GetLength(0), matRes.GetLength(1));
				ShowMat(MatRes, datagridRes);
				CalculosMatrices.MatToDataGrid(matRes, datagridRes);
			}
			catch (Exception)
			{

				MessageBox.Show("Las matrices no son del mismo orden");
			}
			
		}

		private void BT_Multiplicar_Click(object sender, EventArgs e)
		{
			CalculosMatrices.DataGridToMat(datagrid1, matriz1);
			CalculosMatrices.DataGridToMat(datagrid2, matriz2);
			var res= CalculosMatrices.MultiplicarMatriz(matriz1, matriz2);
			matrizRes = res;
			datagridRes = CreateDataGridMat(datagridRes, res.GetLength(0), res.GetLength(1));
			ShowMat(MatRes, datagridRes);
			CalculosMatrices.MatToDataGrid(res, datagridRes);
		}

		private void BT_Restar_Click(object sender, EventArgs e)
		{
			CalculosMatrices.DataGridToMat(datagrid1, matriz1);
			CalculosMatrices.DataGridToMat(datagrid2, matriz2);
			try
			{
				var matRes = CalculosMatrices.RestarMatriz(matriz1, matriz2);
				matrizRes = matRes;
				datagridRes = CreateDataGridMat(datagridRes, matRes.GetLength(0), matRes.GetLength(1));
				ShowMat(MatRes, datagridRes);
				CalculosMatrices.MatToDataGrid(matRes, datagridRes);
			}
			catch (Exception)
			{

				MessageBox.Show("Las matrices no son del mismo orden");
			}

		}
		private void Button2_Click(object sender, EventArgs e)
		{
			RellenarMat(datagrid1, 2);
		}


		private void BT_Escalar_Click_1(object sender, EventArgs e)
		{
			datagrid1.CellValueChanged -= Datagrid1_CellValueChanged;
			matriz1 = CalculosMatrices.EscalarMatriz(matriz1, double.Parse(TXB_Escalar1.Text));
			CalculosMatrices.MatToDataGrid(matriz1, datagrid1);
			datagrid1.CellValueChanged += Datagrid1_CellValueChanged;
		}

		private void BT_Escalar2_Click(object sender, EventArgs e)
		{
			datagrid2.CellValueChanged -= Datagrid2_CellValueChanged;
			matriz2 = CalculosMatrices.EscalarMatriz(matriz2, double.Parse(TXB_Escalar2.Text));
			CalculosMatrices.MatToDataGrid(matriz2, datagrid2);
			datagrid1.CellValueChanged += Datagrid2_CellValueChanged;
		}

		private void BT_Escalar3_Click(object sender, EventArgs e)
		{
			
			matrizRes = CalculosMatrices.EscalarMatriz(matrizRes, double.Parse(TXB_EscalarRes.Text));
			CalculosMatrices.MatToDataGrid(matrizRes, datagridRes);
		}




		#endregion

		private void BT_Tmat1_Click(object sender, EventArgs e)
		{
			datagrid1.CellValueChanged -= Datagrid1_CellValueChanged;
			matriz1 = CalculosMatrices.GenerarTranspuesta(matriz1);
			datagrid1=CreateDataGridMat(datagrid1, matriz1.GetLength(0), matriz1.GetLength(1));
			ShowMat(Mat1, datagrid1);
			CalculosMatrices.MatToDataGrid(matriz1, datagrid1);
			datagrid1.CellValueChanged += Datagrid1_CellValueChanged;
		}

		private void BT_Tmat2_Click(object sender, EventArgs e)
		{
			datagrid2.CellValueChanged -= Datagrid2_CellValueChanged;
			matriz2 = CalculosMatrices.GenerarTranspuesta(matriz2);
			datagrid2 = CreateDataGridMat(datagrid2, matriz2.GetLength(0), matriz2.GetLength(1));

			ShowMat(Mat2, datagrid2);
			CalculosMatrices.MatToDataGrid(matriz2, datagrid2);
			datagrid2.CellValueChanged += Datagrid2_CellValueChanged;
		}

		private void BT_TmatR_Click(object sender, EventArgs e)
		{
			matrizRes = CalculosMatrices.GenerarTranspuesta(matrizRes);
			CalculosMatrices.MatToDataGrid(matrizRes, datagridRes);
		}
	}
}
