using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualRace;

namespace VirtualRaceUI
{
    public partial class Form1 : Form
    {
        private Carrera _miCarrera;

        public Form1()
        {
            InitializeComponent();
            foreach (eFabricante item in Enum.GetValues(typeof(eFabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }

            this.gpbAuto.Enabled = false;
            this.gpbResultado.Enabled = false;

            this.cmbFabricante.SelectedIndex = 1;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbCorrerCarreraPor.Items.Add("Tiempo");
            this.cmbCorrerCarreraPor.Items.Add("Kilometros");
            this.cmbCorrerCarreraPor.SelectedIndex = 1;
            this.cmbCorrerCarreraPor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearCarrera_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string fecha = this.txtFecha.Text;
            string lugar = this.txtLugar.Text;

            this._miCarrera = new Carrera(nombre, lugar, fecha);

            this.gpbCarrera.Enabled = false;
            this.gpbAuto.Enabled = true;
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            Auto nuevoAuto = new Auto(this.txtNombrePiloto.Text, (eFabricante)this.cmbFabricante.SelectedItem);
            this._miCarrera = this._miCarrera + nuevoAuto;
            cargarListado();

            this.gpbResultado.Enabled = true;
        }

        private void cargarListado()
        {
            this.lsbAutos.Items.Clear();

            foreach (Auto item in this._miCarrera.listaDeAutos)
            {
                this.lsbAutos.Items.Add(item.DatosEnString);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCorrerCarrera_Click(object sender, EventArgs e)
        {
            string correrPor = this.cmbCorrerCarreraPor.Text;

            switch (correrPor)
            {
                case "Tiempo":

                    Tiempo time = (int)this.numCantidad.Value;
                    
                    this.txtResultado.Text = this._miCarrera.correrCarrera(time);

                    break;

                case "Kilometros":

                    Kilometros km = (int)this.numCantidad.Value;
                    
                    this.txtResultado.Text = this._miCarrera.correrCarrera(km);

                    break;
            }
        }

    }
}
