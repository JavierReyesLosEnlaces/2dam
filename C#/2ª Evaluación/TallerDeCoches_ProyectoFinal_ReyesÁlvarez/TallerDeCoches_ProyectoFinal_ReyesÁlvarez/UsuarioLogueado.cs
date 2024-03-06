using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public class UsuarioLogueado
    {
        private int id_usuario;

        // Constructor
        public UsuarioLogueado(int id_usuario)
        {
            this.id_usuario = id_usuario;
        }

        public int GetIdUsuario()
        {
            return id_usuario;
        }

        public void SetIdUsuario(int id_usuario)
        {
            this.id_usuario = id_usuario;
        }
    }
}
