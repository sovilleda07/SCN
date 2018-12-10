using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notas1.Clases;

namespace Notas1
{
    public partial class frmUsuarios : Form
    {
        // Propiedades para Habilitar
        private int codigoAlumno;
        private int codigoCarrera;
        private int codigoClase;
        private int codigoPeriodo;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para limpiar los valores del formulario
        /// </summary>
        private void Limpiar()
        {
            this.codigoAlumno = 0;
            this.codigoCarrera = 0;
            this.codigoClase = 0;
            this.codigoPeriodo = 0;

            dgvHabilitar.DataSource = null;
            toolStripBuscar.Enabled = true;
            toolStripHabilitar.Enabled = true;
            cmbHabilitar.SelectedIndex = -1;

        }

        private void toolStripSaliru_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        /// <summary>
        /// Evento para cargar los datos al DataGridView
        /// Segun lo seleccionado en el ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            if (cmbHabilitar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar una Categoría");
            }
            else
            {
                if (cmbHabilitar.SelectedIndex == 0)    //Alumno
                {
                    dgvHabilitar.DataSource = Alumnos.GetDataViewInhabilitados();
                    dgvHabilitar.Columns[0].Visible = false;
                }

                if (cmbHabilitar.SelectedIndex == 1)    //Carrera
                {
                    dgvHabilitar.DataSource = Carreras.GetDataViewInhabilitados();
                    dgvHabilitar.Columns[0].Visible = false;

                }

                if (cmbHabilitar.SelectedIndex == 2)    //Clase
                {
                    dgvHabilitar.DataSource = Clases.Clases.GetDataViewInhabilitadas();
                    dgvHabilitar.Columns[0].Visible = false;
                }

                if (cmbHabilitar.SelectedIndex == 3)    //Periodo
                {
                    dgvHabilitar.DataSource = Periodos.GetDataViewInhabilado();
                    dgvHabilitar.Columns[0].Visible = false;
                }
            }
            
        }

        /// <summary>
        /// Evento para Cargar los códigos a las variables
        /// dependiendo de la selección en el ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHabilitar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbHabilitar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar una Categoría");
            }
            else
            {
                if (cmbHabilitar.SelectedIndex == 0)    //Alumno
                {
                   this.codigoAlumno = Convert.ToInt16(dgvHabilitar.Rows[e.RowIndex].Cells["Código"].Value);                   
                
                }

                if (cmbHabilitar.SelectedIndex == 1)    //Carrera
                {
                    this.codigoCarrera = Convert.ToInt16(dgvHabilitar.Rows[e.RowIndex].Cells["Código"].Value);

                }

                if (cmbHabilitar.SelectedIndex == 2)    //Clase
                {
                    this.codigoClase = Convert.ToInt16(dgvHabilitar.Rows[e.RowIndex].Cells["Código"].Value);
                }

                if (cmbHabilitar.SelectedIndex == 3)    //Periodo
                {
                    this.codigoPeriodo = Convert.ToInt16(dgvHabilitar.Rows[e.RowIndex].Cells["Código"].Value);
                }
            }
        }

        /// <summary>
        /// Evento para Habilitar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripHabilitar_Click(object sender, EventArgs e)
        {
            if (cmbHabilitar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar una Categoría");
            }
            else
            {
                if (dgvHabilitar.SelectedRows.Count == 1)
                {
                    if (cmbHabilitar.SelectedIndex == 0)    //Alumno
                    {
                        // Instanciamos la clase Alumno
                        Alumnos elAlumno = new Alumnos();

                        // Nuestro objeto adquiere los valores del formulario
                        elAlumno.id = this.codigoAlumno;

                        // Verificamos el método
                        if (Alumnos.HabilitarAlumno(elAlumno))
                        {
                            MessageBox.Show("Alumno Habilitado", "Información");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                        }
                    }

                    if (cmbHabilitar.SelectedIndex == 1)    //Carrera
                    {
                        // Instanciamos la Clase Carreras
                        Carreras laCarrera = new Carreras();

                        // Nuestro objeto adquiere los valores del formulario
                        laCarrera.codigo = this.codigoCarrera;

                        // Verificamos el método
                        if (Carreras.HabilitarCarrera(laCarrera))
                        {
                            MessageBox.Show("Carrera Habilitada", "Información");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                        }
                    }

                    if (cmbHabilitar.SelectedIndex == 2)    //Clase
                    {
                        // Instanciamos la Clase Clases
                        Clases.Clases laClase = new Clases.Clases();

                        // Nuestro objeto adquiere los valores del formulario
                        laClase.codigo = this.codigoClase;

                        // Verificamos el Método
                        if (Clases.Clases.HabilitarCarrera(laClase))
                        {
                            MessageBox.Show("Clase Habilitada", "Información");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                        }


                    }

                    if (cmbHabilitar.SelectedIndex == 3)    //Periodo
                    {
                        // Instanciamos la Clase Periodos
                        Periodos elPeriodo = new Periodos();

                        // Nuestro Objeto Adquiere los valores del Formulario
                        elPeriodo.codigo = this.codigoPeriodo;

                        // Verificamos el Método
                        if (Periodos.HabilitarCarrera(elPeriodo))
                        {
                            MessageBox.Show("Periodo Habilitado", "Información");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione Un dato a habilitar");
                }
                
            }
        }

        /// <summary>
        /// Evento para Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Evento para salir del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void cmbHabilitar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
