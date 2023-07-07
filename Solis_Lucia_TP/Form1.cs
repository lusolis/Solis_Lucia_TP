using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solis_Lucia_TP
{
    public partial class Form1 : Form
    {
        // declaración de la estructura ingreso
        public struct INGRESO
        {
            public string Dominio;
            public int Cochera;
            public string TipoVehiculo;
            public DateTime HoraIngreso;
        };

        // constante para la cantidad total de elementos del arreglo
        const int MAX = 50;

        // declaración del arreglo Ingreso de 50 elementos
        public INGRESO[] Ingreso;

        // variable para controlar la cantidad de elementos cargados
        public int Cantidad = 0;
        public int[] lugares = new int[50];
        
        //variables para guardar hora de ingreso y egreso
        public DateTime hrIngreso;
        public DateTime hrEgreso;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creación del arreglo Ingreso
            Ingreso = new INGRESO[MAX];

            // establecer el estado inicial de todos los componentes de la interfaz
            estadoInicial();
            Cantidad = 0;
            //cargar items en lista
            mostrarLugares();
        }

        private void estadoInicial()
        {
            txtDominio_Ingreso.Text = "";
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Automovil");
            cmbTipo.Items.Add("Utilitario");
            cmbTipo.SelectedIndex = 0;
            for (int i = 0; i < 50; i++)
            {
                lugares[i] = 1;
            }
            txtDominio_Egreso.Text = "";
            txtTipoVehiculo.Text = "";
            txtUbicacion.Text = "";
            txtDateIngreso.Text = "";
            txtDateEgreso.Text = "";
            txtImporte.Text = "";
            btnIngresar.Enabled = false;
            btnBuscar.Enabled = false;
            btnEgresar.Enabled = false;
        }


        private void mostrarLugares()
        {
            lstCochera.Items.Clear();
            for(int i = 0; i < 50; i++)
            {                
                lstCochera.Items.Add(i + 1);
            }
        }
        
        private void txtDominio_Ingreso_TextChanged(object sender, EventArgs e)
        {
            
            if (txtDominio_Ingreso.Text.Length > 5)
            {
                if (ValidarDatos() == true)
                {
                    btnIngresar.Enabled = true;
                }
            }
        }
        private void txtDominio_Ingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar) == true) //si es minuscula, la convierte en mayúscula
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); 
            }
            if (Char.IsLetterOrDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
            {
                // si la tecla no es ni letra ni numero y es distinta de backspace se anula
                e.Handled = true;
            }
        }

        //boton ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //asignar los valores a cada campo del arreglo, en la posición indicada por la variable Cantidad
            int nro = int.Parse(lstCochera.SelectedItem.ToString()); // obtener el número de cochera que se va a ocupar
            hrIngreso = DateTime.Now; //se le da un valor a variable de hora de ingreso

            Ingreso[Cantidad].Dominio = txtDominio_Ingreso.Text;
            Ingreso[Cantidad].Cochera = nro;
            Ingreso[Cantidad].TipoVehiculo = cmbTipo.SelectedItem.ToString();
            Ingreso[Cantidad].HoraIngreso = hrIngreso;

            // incrementar la cantidad de elementos cargados
            Cantidad++;
            // restaurar el estado inicial del formulario
            estadoInicial();
            for (int i = 0; i < 50; i++)
            {
                //lstCochera.Items.Add(i + 1);
                lstCochera.Items.Remove(nro);
            }
            MessageBox.Show("Cantidad de coches registrados: " + Cantidad.ToString()); //para ver cuantos elementos cargados hay 
        }

        private void lstCochera_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                btnIngresar.Enabled = true;
            }
        }
        // Función 'ValidarDatos', controla que los datos a ingresar sean correctos
        private bool ValidarDatos()
        {
            bool resultado = false; // valor a devolver si no se cumplen todas las validaciones

            if (!validarPatente(txtDominio_Ingreso.Text))
            {
                MessageBox.Show("Patente invalida", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (Cantidad < MAX)//si hay lugar disponible
            {
                if(lstCochera.SelectedItems.Count != 0)
                {
                    int nro = lstCochera.SelectedIndex; 
                    if (BuscarLugar(nro) == false) //controlar si el nro de cochera ya fue cargado, BuscarLugar devuelve falso si el numero no está y verdadero en caso contrario
                    {
                        //si llega acá es porque todas las condiciones se cumplen
                        resultado = true; // ValidarDatos() devolverá verdadero
                    }
                }                
            }
            else
            {
                MessageBox.Show("No hay cocheras disponibles", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // devuelve el valor asignado en la variable 'resultado'
            return resultado;
        }
        
        private bool BuscarLugar(int nro)
        {
            bool resultado = false; //será falso si el número de cochera no está almacenado en el arreglo
            int i;            
            for (i = 0; i < Cantidad; i++)
            {
                //comparar el número de cochera buscado con el número de cochera almacenado en el arreglo
                if (nro == Ingreso[i].Cochera)
                {
                    resultado = true; 
                    break; 
                }
            }
            //devuelve el valor asignado en la variable 'resultado'
            return resultado;
        }
        //funcion para validar patente
        private bool validarPatente(String patente) // la funcion recibe una variable de tipo string
        {
            //sacado de internet
            Regex regExpVieja = new Regex("^[a-zA-Z][a-zA-Z][a-zA-Z][0-9][0-9][0-9]*$");
            Regex regExpNueva = new Regex("^[a-zA-Z][a-zA-Z][0-9][0-9][0-9][a-zA-Z][a-zA-Z]*$");

            bool isPatenteViejaValida = false;
            bool isPatenteNuevaValida = false;
                        
            if (regExpVieja.IsMatch(patente))
            {
                isPatenteViejaValida = true;
            }

            if (regExpNueva.IsMatch(patente))
            {
                isPatenteViejaValida = true;
            }

            if (isPatenteViejaValida == false && isPatenteNuevaValida == false)
            {
                return false;
            }
            else
            {
                return true;
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void txtDominio_Egreso_TextChanged(object sender, EventArgs e)
        {
            string patenteEgreso = txtDominio_Egreso.Text;

            if (patenteEgreso.Length >= 6)
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }
        private void txtDominio_Egreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar) == true) //si es minuscula, la convierte en mayúscula
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if (Char.IsLetterOrDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
            {
                // si la tecla no es ni letra ni numero y es distinta de backspace se anula
                e.Handled = true;
            }
        }
        //boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string patenteEgreso = txtDominio_Egreso.Text;

            if (!validarPatente(patenteEgreso)) //si no es una patente valida
            {
                MessageBox.Show("Patente invalida", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return; //corta
            }
                        
            hrEgreso = DateTime.Now;
            TimeSpan permanencia;
            double minutos;

            int i = 0;
            for (i = 0; i < Cantidad; i++)
            {                
                if (patenteEgreso == Ingreso[i].Dominio)
                {
                    patenteEgreso = Ingreso[i].Dominio;
                    txtTipoVehiculo.Text = Ingreso[i].TipoVehiculo.ToString();
                    txtUbicacion.Text = Ingreso[i].Cochera.ToString();
                    txtDateIngreso.Text = Ingreso[i].HoraIngreso.ToString();
                    txtDateEgreso.Text = hrEgreso.ToString();
                    permanencia = hrEgreso - Ingreso[i].HoraIngreso;
                    minutos = permanencia.TotalMinutes;
                    if (txtTipoVehiculo.Text == "Automovil")
                    {
                        txtImporte.Text = (minutos * 2.5f).ToString();
                        btnEgresar.Enabled = true;
                    }
                    else
                    {
                        txtImporte.Text = (minutos * 3.0f).ToString();
                        btnEgresar.Enabled = true;
                    }
                }                
            }
            /*
            if (!Array.Exists(Ingreso, element => element.Equals(patenteEgreso))) //si 'patenteEgreso' no existe en el arreglo, mostrar mensaje de error
            {
                MessageBox.Show("Ingrese un coche registrado", "ERROR",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        
        //boton egresar
        private void btnEgresar_Click(object sender, EventArgs e)
        {
            int cocheraDisponible = int.Parse(txtUbicacion.Text);            
            estadoInicial(); //reestablecer el estado inicial
            
            Cantidad = Cantidad - 1;
            MessageBox.Show("Cantidad de coches registrados: " + Cantidad);
            
            int i = 0;

             for (i = 0; i < 50; i++)
             {
                if (cocheraDisponible < int.Parse(lstCochera.Items[i].ToString())) //si el valor de cocheraDisponible es igual al valor
                                                                                   //de lstCochera en la posición i
                {
                    lstCochera.Items.Insert(i, cocheraDisponible);//vuelve a cargar la cochera en la lista
                                                                  //insert(posición, elemento)
                    break;
                }
             }            
        }
        //boton cerrar
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }    
}