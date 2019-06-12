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

		/*private string ConvertirMatrizDoubleString(double[] arr)
		{
			string res = "Resultado: ";
			foreach (var item in arr)
			{
				res += item + ", ";
			}
			return res;
		}
		private double[] CargarEntradaArreglo()
		{
			try
			{
				var caracteres = Tx_CargarMatriz.Text.Trim(' ').Split(' ');
				double[] arreglo = new double[caracteres.Length];
				for (int i = 0; i < arreglo.Length; i++)
				{
					arreglo[i] = Convert.ToDouble(caracteres[i]);
				}
				listaMatrices.Add(arreglo);
				LB_MatrizPrecargada.Text = "ultima matriz cargada: "+ Tx_CargarMatriz.Text;
				Tx_CargarMatriz.Text = "";
				return arreglo;
			}
			catch
			{

			}
			return null;
			
		}

		private void AgregarArregloLista(double[] arreglo)
		{
			LSB_MatricesCargadas.Items.Add(arreglo);
		}

		
		private void BT_Escalar_Click(object sender, EventArgs e)
		{
			var arreglo= CargarEntradaArreglo();
			double[] arr;
			if (arreglo != null)
			{
				arr = (double[])arreglo.Clone();
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = Convert.ToDouble(TXB_K.Text) * arreglo[i];
				}
			}
			else if (listaMatrices.Count > 0)
			{
				arr = listaMatrices[listaMatrices.Count - 1];
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = Convert.ToDouble(TXB_K.Text) * arr[i];
				}

			}
			else return;
			
			
			LB_Resultado.Text = ConvertirMatrizDoubleString(arr);
		}

		private void BT_SumarMatriz_Click(object sender, EventArgs e)
		{
			var arr= CargarEntradaArreglo();
			double[] res = new double[arr.Length];
			if (listaMatrices.Count > 1)
			{
				var arr2 = listaMatrices[listaMatrices.Count - 2];


				if (arr.Length == arr2.Length)
				{
					for (int i = 0; i < res.Length; i++)
					{
						res[i] = arr[i] + arr2[i];
					}
					LB_Resultado.Text = ConvertirMatrizDoubleString(res);
				}
				else LB_Resultado.Text = "Las matrices no son del mismo orden";
			}
			
		} */
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
			
			dat= new DataGridView();
			dat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dat.ColumnCount = col;
			dat.Rows.Add(rows);
			dat.AllowUserToAddRows = false;
			dat.ColumnHeadersVisible = false;
			dat.RowHeadersVisible = false;
			return dat;
			
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

		private void ButtonSumar_Click(object sender, EventArgs e)
		{
			CalculosMatrices.DataGridToMat(datagrid1, matriz1);
			var matRes= CalculosMatrices.sumarMatriz(matriz1, matriz2);

			datagridRes = CreateDataGridMat(datagridRes, matRes.GetLength(0), matRes.GetLength(1));
			ShowMat(MatRes, datagridRes);
			CalculosMatrices.MatToDataGrid(matRes, datagridRes);
		}

		

		private void Button2_Click(object sender, EventArgs e)
		{
			RellenarMat(datagrid1, 2);
		}


	}
}
