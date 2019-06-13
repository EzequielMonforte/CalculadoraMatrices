using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMatrices
{
	class CalculosMatrices
	{
		public static double[,] sumarMatriz(double[,] mat1, double[,] mat2) {
			double[,] matRes=(double[,])mat1.Clone();
			if (mat1.GetLength(0) != mat2.GetLength(0) || mat1.GetLength(1) != mat2.GetLength(1))
				throw new Exception("Las matrices no son iguales, no se puede sumar");

			for (int i = 0; i < mat1.GetLength(1); i++)
			{

				for (int j = 0; j < mat1.GetLength(0); j++)
				{
					matRes[j, i] = mat1[j, i] + mat2[j, i];
				}
			}

			return matRes;
		}

		public static void DataGridToMat(DataGridView datagrid, double[,] mat)
		{
			for (int i = 0; i < mat.GetLength(1); i++)
			{
				for (int j = 0; j < mat.GetLength(0); j++)
				{
					if (datagrid.Rows[j].Cells[i].Value != null)
					{
						mat[j, i] = double.Parse(datagrid.Rows[j].Cells[i].Value.ToString());
					}
					else mat[j, i] = 0;
				}
			}

		}

		public static void MatToDataGrid(double[,] mat, DataGridView dat) {
			for (int i = 0; i < mat.GetLength(1); i++)
			{
				for (int j = 0; j < mat.GetLength(0); j++)
				{
					
						dat.Rows[j].Cells[i].Value = mat[j, i];
					
				}
			}
		}

		public static double[,] EscalarMatriz(double[,] mat, double k) {
			for (int i = 0; i < mat.GetLength(1); i++)
			{
				for (int j = 0; j < mat.GetLength(0); j++)
				{
					mat[j, i] *= k;
				}
			}
			return mat;

		}
	}
}
