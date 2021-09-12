using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCategoria : Form
    {
        // varialbles isNuevo & isEditar --antes de metodo constructor 
        private bool IsNuevo = false;
        private bool IsEditar = false;
        // metodo constructor--abajo de esta linea 
        public FrmCategoria()
        {
            InitializeComponent();
            // metodo constructor--aqui va el mensaje de las cajas de textos  
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el Nombre de la Categoria");
        }



        //--desde aqui se inician los distintos metodos que abilitan o desabilitan los botones -- antes del evento --Load del formulario
        
        //**metodo**mostrar mensaje de confirmacion 
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //**metodo**mostrar mensaje de confirmacion del error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo para --Limpiar-- las cajas de textos
        
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtIdcategoria.Text = string.Empty;
        }

        //metodo para habilitar los controles del formulario --- o las cajas de textos 
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtIdcategoria.ReadOnly = !valor;
        }


        //metodo para Hablitar los Botones del formulario
        private void Botones()
        {
            if(this.IsNuevo||this.IsEditar) //alt--124 para --||
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled=false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        // metodo para ocultar columnas del datagridviw---
          private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //metodo para Mostrar las columnas del datagridviw--
        private void Mostrar()
        {
            this.dataListado.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "ToTal de Registros  " + Convert.ToString(dataListado.Rows.Count);
        }

        //metodo para BuscarNombre las columnas del datagridviw--
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NCategoria.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "ToTal de Registros" + Convert.ToString(dataListado.Rows.Count);
        }

        //-- aqui se Finalizan los distintos metodos que Habilitan o deshabilitan los botones -- antes del evento --Load del formulario
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
    }
}