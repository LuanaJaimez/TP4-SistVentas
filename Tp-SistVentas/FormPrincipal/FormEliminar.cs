﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;

namespace FormPrincipal
{
    public partial class FormEliminar : Form
    {
        SqlConnection conexion;
        SqlCommand comando;

        DatosBD prendas = new DatosBD();
        DatosBD accesorios = new DatosBD();

        public FormEliminar()
        {
            conexion = new SqlConnection("Data Source = DESKTOP-HN6S3DK\\SQLEXPRESS; Database = Producto; Trusted_Connection=True;");
            comando = new SqlCommand();

            InitializeComponent();
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            dtMostrarPrendas.DataSource = null;
            dtMostrarAccesorios.DataSource = null;

            dtMostrarPrendas.DataSource = prendas.MostrarPrendas();
            dtMostrarAccesorios.DataSource = accesorios.MostrarAccesorios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormInicio frmInicio = new FormInicio();

            this.Hide();

            frmInicio.Show();
        }

        private void EliminarP_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM PrendaBD WHERE @PID";

            comando.Parameters.Add(new SqlParameter("PID", tbIDP.Text));

            conexion.Open();

            MessageBox.Show("Prenda eliminada");

            conexion.Close();
        }

        private void EliminarA_Click(object sender, EventArgs e)
        {
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM AccesorioBD WHERE(@AID)";

            comando.Parameters.Add(new SqlParameter("AID", tbIDA.Text));

            conexion.Open();

            MessageBox.Show("Accesorio eliminado");

            conexion.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
