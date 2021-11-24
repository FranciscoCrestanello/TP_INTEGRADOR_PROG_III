﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;
using Entidades; 

namespace Vistas.Usuario
{
    public partial class EditarUsuario : System.Web.UI.Page
    {
        NegocioUsuarios negUsuarios = new NegocioUsuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarGridViewUsuarios();
        }

        private void CargarGridViewUsuarios()
        {
            grdUsuarios.DataSource = negUsuarios.getTablaUsuarios();
            grdUsuarios.DataBind();
        }

        protected void grdUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdUsuarios.EditIndex = e.NewEditIndex;
            CargarGridViewUsuarios();
        }

        protected void grdUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdUsuarios.EditIndex = -1;
            CargarGridViewUsuarios();
        }

        protected void grdUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String idUsuario = ((Label)grdUsuarios.Rows[e.RowIndex].FindControl("lbl_eit_IdCliente")).Text;
            String nombre = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Nombre")).Text;
            String apellido = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Apellido")).Text;
            String provincia = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Provincia")).Text;
            String celular = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Celular")).Text;
            String dni = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Dni")).Text;
            String direccion = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Direccion")).Text;
            String email = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Email")).Text;
            String contrasena = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_Contrasena")).Text;
            String tUsuario = ((TextBox)grdUsuarios.Rows[e.RowIndex].FindControl("txt_eit_TipoUsuario")).Text;

            //lblmensaje.Text = provincia.ToString(); 

            negUsuarios.ModificarUsuario(idUsuario, nombre, apellido, provincia, celular, dni, direccion, email, contrasena, tUsuario);

            grdUsuarios.EditIndex = -1;
            CargarGridViewUsuarios();
        }

    }

}