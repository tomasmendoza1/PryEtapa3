using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEtapa3
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto;
        clsVehiculo ObjAvion;
        clsVehiculo ObjBarco;

        bool EstadoAuto = false;
        bool EstadoAvion = false;   
        bool EstadoBarco = false;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            ObjAvion = new clsVehiculo();   
            ObjBarco = new clsVehiculo();

            objAuto.CrearAuto();
            ObjAvion.CrearAuto();   
            ObjBarco.CrearAuto();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            objAuto.CrearAuto();
            objAuto.pctAuto.Location = new Point(10, 50);
            Controls.Add(objAuto.pctAuto);
            LblVehiculoSeleccionado.Text = objAuto.TipoDeVehiculo;
            EstadoAuto = true;
            if (EstadoAvion == true)
            {
                ObjAvion.pctAvion.Dispose(); EstadoAvion = false ;
            }
            if(EstadoBarco == true)
            {
                ObjBarco.pctBarco.Dispose(); EstadoBarco = false ;
            }

        }
        private void BtnCrearAvion_Click(object sender, EventArgs e)
        {
            ObjAvion.CrearAvion();
            ObjAvion.pctAvion.Location = new Point(140, 50);
            Controls.Add(ObjAvion.pctAvion);
            LblVehiculoSeleccionado.Text = ObjAvion.TipoDeVehiculo;
            EstadoAvion = true;
            if (EstadoAuto == true)
            {
                objAuto.pctAuto.Dispose(); EstadoAuto = false;
            }
            if (EstadoBarco == true)
            {
                ObjBarco.pctBarco.Dispose(); EstadoBarco = false;
            }
        }
        private void BtnCrearBarco_Click(object sender, EventArgs e)
        {
            ObjBarco.CrearBarco();
            ObjBarco.pctBarco.Location = new Point(300, 50);
            Controls.Add(ObjBarco.pctBarco);
            LblVehiculoSeleccionado.Text = ObjBarco.TipoDeVehiculo;
            EstadoBarco = true;
            if (EstadoAuto == true)
            {
                objAuto.pctAuto.Dispose(); EstadoAuto = false;
            }
            if (EstadoAvion == true)
            {
                ObjAvion.pctAvion.Dispose(); EstadoAvion = false;
            }
        }
    }
}
