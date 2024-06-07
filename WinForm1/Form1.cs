using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona a1 = new Persona();

        private void button1_Click(object sender, EventArgs e)
        {
            a1.nombre = txtNombre.Text;
            a1.direccion = txtDireccion.Text;
            a1.FNacimiento = dtNacimiento.Value;
            a1.propietario = cbxPropietario.Checked == true ? "es propietario" : "no es propietario";
            string politico;
            if (rbIzq.Checked)
                politico = "Izquierda";
            else if (rbCentro.Checked)
                politico = "Centro";
            else
                politico = "Derecha";

            a1.politico = politico;
            a1.destino = cbDestino.SelectedItem.ToString();
            a1.grupoFamiliar = numGrupoFamiliar.Value.ToString();

            string mensaje = "Nombre : " + a1.nombre + ", su direccion es: " + a1.direccion + ", su fecha de nacimiento es: " + a1.FNacimiento.ToString("D,dd/MM/yyyy") + ", usted " + a1.propietario + " y convive con " + a1.grupoFamiliar + " personas. Su alineamiento politico es " + a1.politico + ". Y su destino preferido es " + a1.destino + ".";
            MessageBox.Show(mensaje);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDestino.Items.Add("Playa");
            cbDestino.Items.Add("Montaña");
            cbDestino.Items.Add("Campo");
            cbDestino.Items.Add("Ciudad");

        }
    }
}
