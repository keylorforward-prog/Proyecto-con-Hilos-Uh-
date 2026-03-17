using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace NominaSalarios
{
    public partial class Form1 : Form
    {
        static Cla_Empleado[] Array_Empleados = new Cla_Empleado[40];
        static int totalEmpleados = 0;

        Thread hiloHombres;
        Thread hiloMujeres;
        Thread hiloMenorMillon;
        Thread hiloMayorMillon;
        Thread hiloMayorTres;

        public Form1()
        {
            InitializeComponent();
            btnCargarPanel.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath + "\\SALARIOS.TXT";

            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró el archivo SALARIOS.TXT");
                return;
            }

            int Indice_Empleado = 0;

            using (StreamReader sr = new StreamReader(ruta))
            {
                string PLinea;
                while ((PLinea = sr.ReadLine()) != null && Indice_Empleado < 40)
                {
                    if (PLinea.Trim().Length >= 50)
                    {
                        Array_Empleados[Indice_Empleado] = new Cla_Empleado();
                        Array_Empleados[Indice_Empleado].Cedula = int.Parse(PLinea.Substring(0, 9));
                        Array_Empleados[Indice_Empleado].Nombre = PLinea.Substring(9, 30).Trim();
                        Array_Empleados[Indice_Empleado].Genero = int.Parse(PLinea.Substring(39, 1));
                        Array_Empleados[Indice_Empleado].Salario_Mensual = double.Parse(PLinea.Substring(40, 10).Trim());
                        Array_Empleados[Indice_Empleado].Salario_Menor = false;
                        Array_Empleados[Indice_Empleado].Salario_Mayor = false;
                        Indice_Empleado++;
                    }
                }
            }

            totalEmpleados = Indice_Empleado;
            MessageBox.Show("Archivo Leído");

            CargarDataGridGeneral();
            MessageBox.Show("DataGrid Primario Cargado");

            MarcarSalarios();

            hiloHombres = new Thread(CargarHombres);
            hiloMujeres = new Thread(CargarMujeres);
            hiloMenorMillon = new Thread(CargarMenorMillon);
            hiloMayorMillon = new Thread(CargarMayorMillon);
            hiloMayorTres = new Thread(CargarMayorTres);

            hiloHombres.Start();
            hiloMujeres.Start();
            hiloMenorMillon.Start();
            hiloMayorMillon.Start();
            hiloMayorTres.Start();

            Thread hiloEspera = new Thread(() =>
            {
                hiloHombres.Join();
                hiloMujeres.Join();
                hiloMenorMillon.Join();
                hiloMayorMillon.Join();
                hiloMayorTres.Join();

                this.Invoke((MethodInvoker)delegate {
                    btnCargarPanel.Enabled = true;
                });
            });
            hiloEspera.IsBackground = true;
            hiloEspera.Start();
        }

        private void MarcarSalarios()
        {
            double mayor = Array_Empleados[0].Salario_Mensual;
            double menor = Array_Empleados[0].Salario_Mensual;

            for (int i = 1; i < totalEmpleados; i++)
            {
                if (Array_Empleados[i].Salario_Mensual > mayor)
                    mayor = Array_Empleados[i].Salario_Mensual;
                if (Array_Empleados[i].Salario_Mensual < menor)
                    menor = Array_Empleados[i].Salario_Mensual;
            }

            for (int i = 0; i < totalEmpleados; i++)
            {
                Array_Empleados[i].Salario_Mayor = (Array_Empleados[i].Salario_Mensual == mayor);
                Array_Empleados[i].Salario_Menor = (Array_Empleados[i].Salario_Mensual == menor);
            }
        }

        private void CargarDataGridGeneral()
        {
            dgvGeneral.Rows.Clear();
            dgvGeneral.Columns.Clear();
            dgvGeneral.Columns.Add("Cedula", "Cedula");
            dgvGeneral.Columns.Add("Nombre", "Nombre");
            dgvGeneral.Columns.Add("Salario", "Salario");

            double total = 0;
            for (int i = 0; i < totalEmpleados; i++)
            {
                dgvGeneral.Rows.Add(
                    Array_Empleados[i].Cedula,
                    Array_Empleados[i].Nombre,
                    Array_Empleados[i].Salario_Mensual.ToString("N0")
                );
                total += Array_Empleados[i].Salario_Mensual;
            }
            dgvGeneral.Rows.Add("", "*** TOTAL GENERAL ***", total.ToString("N0"));
            dgvGeneral.Rows.Add("", "*** CANTIDAD DE FUNCIONARIOS ***", totalEmpleados);
        }

        private void CargarHombres()
        {
            dgvHombres.Invoke((MethodInvoker)delegate {
                dgvHombres.Rows.Clear();
                dgvHombres.Columns.Clear();
                dgvHombres.Columns.Add("Cedula", "Cedula");
                dgvHombres.Columns.Add("Nombre", "Nombre");
                dgvHombres.Columns.Add("Salario", "Salario");

                double total = 0; int cant = 0;
                for (int i = 0; i < totalEmpleados; i++)
                {
                    if (Array_Empleados[i].Genero == 1)
                    {
                        dgvHombres.Rows.Add(
                            Array_Empleados[i].Cedula,
                            Array_Empleados[i].Nombre,
                            Array_Empleados[i].Salario_Mensual.ToString("N0")
                        );
                        total += Array_Empleados[i].Salario_Mensual;
                        cant++;
                    }
                }
                dgvHombres.Rows.Add("", "*** TOTAL GENERAL ***", total.ToString("N0"));
                dgvHombres.Rows.Add("", "*** CANTIDAD DE FUNCIONARIOS ***", cant);
            });
        }

        private void CargarMujeres()
        {
            dgvMujeres.Invoke((MethodInvoker)delegate {
                dgvMujeres.Rows.Clear();
                dgvMujeres.Columns.Clear();
                dgvMujeres.Columns.Add("Cedula", "Cedula");
                dgvMujeres.Columns.Add("Nombre", "Nombre");
                dgvMujeres.Columns.Add("Salario", "Salario");

                double total = 0; int cant = 0;
                for (int i = 0; i < totalEmpleados; i++)
                {
                    if (Array_Empleados[i].Genero == 2)
                    {
                        dgvMujeres.Rows.Add(
                            Array_Empleados[i].Cedula,
                            Array_Empleados[i].Nombre,
                            Array_Empleados[i].Salario_Mensual.ToString("N0")
                        );
                        total += Array_Empleados[i].Salario_Mensual;
                        cant++;
                    }
                }
                dgvMujeres.Rows.Add("", "*** TOTAL GENERAL ***", total.ToString("N0"));
                dgvMujeres.Rows.Add("", "*** CANTIDAD DE FUNCIONARIOS ***", cant);
            });
        }

        private void CargarMenorMillon()
        {
            dgvMenorMillon.Invoke((MethodInvoker)delegate {
                dgvMenorMillon.Rows.Clear();
                dgvMenorMillon.Columns.Clear();
                dgvMenorMillon.Columns.Add("Cedula", "Cedula");
                dgvMenorMillon.Columns.Add("Nombre", "Nombre");
                dgvMenorMillon.Columns.Add("Salario", "Salario");

                double total = 0; int cant = 0;
                for (int i = 0; i < totalEmpleados; i++)
                {
                    if (Array_Empleados[i].Salario_Mensual < 1000000)
                    {
                        dgvMenorMillon.Rows.Add(
                            Array_Empleados[i].Cedula,
                            Array_Empleados[i].Nombre,
                            Array_Empleados[i].Salario_Mensual.ToString("N0")
                        );
                        total += Array_Empleados[i].Salario_Mensual;
                        cant++;
                    }
                }
                dgvMenorMillon.Rows.Add("", "*** TOTAL GENERAL ***", total.ToString("N0"));
                dgvMenorMillon.Rows.Add("", "*** CANTIDAD DE FUNCIONARIOS ***", cant);
            });
        }

        private void CargarMayorMillon()
        {
            dgvMayorMillon.Invoke((MethodInvoker)delegate {
                dgvMayorMillon.Rows.Clear();
                dgvMayorMillon.Columns.Clear();
                dgvMayorMillon.Columns.Add("Cedula", "Cedula");
                dgvMayorMillon.Columns.Add("Nombre", "Nombre");
                dgvMayorMillon.Columns.Add("Salario", "Salario");

                double total = 0; int cant = 0;
                for (int i = 0; i < totalEmpleados; i++)
                {
                    double sal = Array_Empleados[i].Salario_Mensual;
                    if (sal >= 1000000 && sal < 3000000)
                    {
                        dgvMayorMillon.Rows.Add(
                            Array_Empleados[i].Cedula,
                            Array_Empleados[i].Nombre,
                            sal.ToString("N0")
                        );
                        total += sal;
                        cant++;
                    }
                }
                dgvMayorMillon.Rows.Add("", "*** TOTAL GENERAL ***", total.ToString("N0"));
                dgvMayorMillon.Rows.Add("", "*** CANTIDAD DE FUNCIONARIOS ***", cant);
            });
        }

        private void CargarMayorTres()
        {
            dgvMayorTres.Invoke((MethodInvoker)delegate {
                dgvMayorTres.Rows.Clear();
                dgvMayorTres.Columns.Clear();
                dgvMayorTres.Columns.Add("Cedula", "Cedula");
                dgvMayorTres.Columns.Add("Nombre", "Nombre");
                dgvMayorTres.Columns.Add("Salario", "Salario");

                double total = 0; int cant = 0;
                for (int i = 0; i < totalEmpleados; i++)
                {
                    if (Array_Empleados[i].Salario_Mensual >= 3000000)
                    {
                        dgvMayorTres.Rows.Add(
                            Array_Empleados[i].Cedula,
                            Array_Empleados[i].Nombre,
                            Array_Empleados[i].Salario_Mensual.ToString("N0")
                        );
                        total += Array_Empleados[i].Salario_Mensual;
                        cant++;
                    }
                }
                dgvMayorTres.Rows.Add("", "*** TOTAL GENERAL ***", total.ToString("N0"));
                dgvMayorTres.Rows.Add("", "*** CANTIDAD DE FUNCIONARIOS ***", cant);
            });
        }

        private void btnCargarPanel_Click(object sender, EventArgs e)
        {
            Form2 frmSecundario = new Form2(Array_Empleados, totalEmpleados);
            frmSecundario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            bool activos = false;

            if (hiloHombres != null && hiloHombres.IsAlive) activos = true;
            if (hiloMujeres != null && hiloMujeres.IsAlive) activos = true;
            if (hiloMenorMillon != null && hiloMenorMillon.IsAlive) activos = true;
            if (hiloMayorMillon != null && hiloMayorMillon.IsAlive) activos = true;
            if (hiloMayorTres != null && hiloMayorTres.IsAlive) activos = true;

            if (activos)
                MessageBox.Show("Hay hilos en ejecución. Espere.");
            else
                Application.Exit();
        }
    }
}