using System;
using System.Windows.Forms;

namespace NominaSalarios
{
    public partial class Form2 : Form
    {
        Cla_Empleado[] empleados;
        int total;

        public Form2(Cla_Empleado[] arr, int totalEmp)
        {
            InitializeComponent();
            empleados = arr;
            total = totalEmp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Salario MENOR
            dgvMenor.Columns.Add("Cedula", "Cedula");
            dgvMenor.Columns.Add("Nombre", "Nombre");
            dgvMenor.Columns.Add("Salario", "Salario");

            double totalMenor = 0; int cantMenor = 0;
            for (int i = 0; i < total; i++)
            {
                if (empleados[i].Salario_Menor)
                {
                    dgvMenor.Rows.Add(
                        empleados[i].Cedula,
                        empleados[i].Nombre,
                        empleados[i].Salario_Mensual.ToString("N0")
                    );
                    totalMenor += empleados[i].Salario_Mensual;
                    cantMenor++;
                }
            }
            dgvMenor.Rows.Add("", "*** TOTAL GENERAL ***", totalMenor.ToString("N0"));
            dgvMenor.Rows.Add("", "*** CANTIDAD DE FUNCIONARIOS ***", cantMenor);

            // Salario MAYOR
            dgvMayor.Columns.Add("Cedula", "Cedula");
            dgvMayor.Columns.Add("Nombre", "Nombre");
            dgvMayor.Columns.Add("Salario", "Salario");

            double totalMayor = 0; int cantMayor = 0;
            for (int i = 0; i < total; i++)
            {
                if (empleados[i].Salario_Mayor)
                {
                    dgvMayor.Rows.Add(
                        empleados[i].Cedula,
                        empleados[i].Nombre,
                        empleados[i].Salario_Mensual.ToString("N0")
                    );
                    totalMayor += empleados[i].Salario_Mensual;
                    cantMayor++;
                }
            }
            dgvMayor.Rows.Add("", "*** TOTAL GENERAL ***", totalMayor.ToString("N0"));
            dgvMayor.Rows.Add("", "*** CANTIDAD DE FUNCIONARIOS ***", cantMayor);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}