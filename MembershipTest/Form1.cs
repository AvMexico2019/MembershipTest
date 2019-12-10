using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipTest
{
    public partial class Form1 : Form
    {
        List<ApplicationClass> ListaApps = new List<ApplicationClass>();
        Dictionary<int, AppRols> ListaRoles = new Dictionary<int, AppRols>();
        Dictionary<int, int> RenglonRol = new Dictionary<int, int>();
        List<Usuarios> ListaUsuarios = new List<Usuarios>();
        List<int> RolesUsuario = new List<int>();
        int UsuarioSeleccionado = -1;

        public Form1()
        {
            InitializeComponent();
            LlenaAplicaciones();
            textBoxUsuarioBuscado.Enabled = false;
            listBoxRoles.Enabled = false;
            listBoxUsuariosEncontrados.Enabled = false;
        }

        void LlenaAplicaciones()
        {
            MEFDLL.MembershipEntities ctx = new MEFDLL.MembershipEntities();
            var applications = from app in ctx.Application
                               orderby app.ApplicationName
                               select app  ;
            ListaApps.Clear();
            comboBoxAplicaciones.Items.Clear();
            foreach (var app in applications)
            {
                comboBoxAplicaciones.Items.Add(app.ApplicationName + "(" + app.IDApplication + ")");
                ListaApps.Add(new ApplicationClass { IDApplication = app.IDApplication, ApplicationName = app.ApplicationName });
            }
        }

        private void comboBoxAplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int AppSeleccionada = ListaApps[comboBoxAplicaciones.SelectedIndex].IDApplication;
            textBoxUsuarioBuscado.Enabled = true;
            MEFDLL.MembershipEntities ctx = new MEFDLL.MembershipEntities();
            var roles = from rol in ctx.Role where rol.IDApplication == AppSeleccionada
                        select rol;
            ListaRoles.Clear();
            listBoxRoles.Items.Clear();
            RenglonRol.Clear();
            int renglon = 0;
            foreach (var rol in roles)
            {
                RenglonRol.Add(renglon++, rol.IDRole);
                listBoxRoles.Items.Add(rol.RoleName + "(" + rol.IDRole + ")");
                ListaRoles.Add(rol.IDRole, new AppRols { IDRole = rol.IDRole, IDApplication = rol.IDApplication, RoleName = rol.RoleName });
            }
        }

        private void textBoxUsuarioBuscado_TextChanged(object sender, EventArgs e)
        {
            MEFDLL.MembershipEntities ctx = new MEFDLL.MembershipEntities();
            listBoxUsuariosEncontrados.Enabled = true;
            string UsuarioBuscado = textBoxUsuarioBuscado.Text;
            var usuarios = from usuario in ctx.User
                           where usuario.UserName.Contains(UsuarioBuscado)
                           orderby usuario.UserName
                           select usuario;
            ListaUsuarios.Clear();
            listBoxUsuariosEncontrados.Items.Clear();
            foreach (var user in usuarios)
            {
                listBoxUsuariosEncontrados.Items.Add(user.UserName + "(" + user.IDUser + "." + user.IsApproved + "." + user.Deleted + "." + user.IsLockedOut + ")");
                ListaUsuarios.Add(new Usuarios { IDUser = user.IDUser, UserName = user.UserName });
            }
        }

        private void listBoxUsuariosEncontrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsuarioSeleccionado = ListaUsuarios[listBoxUsuariosEncontrados.SelectedIndex].IDUser;
            listBoxRoles.Enabled = true;
            MEFDLL.MembershipEntities ctx = new MEFDLL.MembershipEntities();
            var rolesUsuario = from rol in ctx.UserInRole
                               where rol.IDUser == UsuarioSeleccionado
                               select rol;
            listBoxRolesUsuario.Items.Clear();
            RolesUsuario.Clear();
            foreach (var rolUser in rolesUsuario)
            {
                if (ListaRoles.ContainsKey(rolUser.IDRole))
                {
                    listBoxRolesUsuario.Items.Add(ListaRoles[rolUser.IDRole].RoleName);
                    RolesUsuario.Add(rolUser.IDRole);
                }
                else
                    listBoxRolesUsuario.Items.Add("rol " + rolUser.IDRole);
            }
        }

        private void listBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgregarQuitarRol AQR = new AgregarQuitarRol();
            AQR.ShowDialog();

            int RoleID = RenglonRol[listBoxRoles.SelectedIndex];
            //int rolAdminitrado = ListaRoles[]
            using(MEFDLL.MembershipEntities ctxUpdate = new MEFDLL.MembershipEntities())
            {
                switch (AQR.result)
                {
                    case 1:  // agregar
                        if (!RolesUsuario.Contains(RoleID))
                        {
                            var AgregarRol = ctxUpdate.Set<MEFDLL.UserInRole>();
                            AgregarRol.Add(new MEFDLL.UserInRole { IDUser = UsuarioSeleccionado, IDRole = RoleID });
                        }
                        break;
                    case 2: // quitar
                        if (RolesUsuario.Contains(RoleID))
                        {
                            ctxUpdate.UserInRole.Remove(ctxUpdate.UserInRole.Single(r => r.IDUser == UsuarioSeleccionado && r.IDRole == RoleID));
                        }
                        break;
                }
                ctxUpdate.SaveChanges();
                var rolesUsuario = from rol in ctxUpdate.UserInRole
                                   where rol.IDUser == UsuarioSeleccionado
                                   select rol;
                listBoxRolesUsuario.Items.Clear();
                foreach (var rolUser in rolesUsuario)
                {
                    if (ListaRoles.ContainsKey(rolUser.IDRole))
                    {
                        listBoxRolesUsuario.Items.Add(ListaRoles[rolUser.IDRole].RoleName);
                    }
                    else
                        listBoxRolesUsuario.Items.Add("rol " + rolUser.IDRole);
                }
            }
             
            //MEFDLL.MembershipEntities ctx = new MEFDLL.MembershipEntities();
          
           
        }

        private void listBoxRolesUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBorraUsuario_Click(object sender, EventArgs e)
        {
            if (UsuarioSeleccionado > -1)
            {
                using (MEFDLL.MembershipEntities ctxUpdate = new MEFDLL.MembershipEntities())
                {
                    ctxUpdate.Telefono.Remove(ctxUpdate.Telefono.Single(r => r.Fk_IdUser == UsuarioSeleccionado));
                    ctxUpdate.Rel_UserDomicilio.Remove(ctxUpdate.Rel_UserDomicilio.Single(r => r.FkIdUser == UsuarioSeleccionado));
                    ctxUpdate.User.Remove(ctxUpdate.User.Single(r => r.IDUser == UsuarioSeleccionado));
                    ctxUpdate.SaveChanges();
                }
            }
            
        }
    }
}