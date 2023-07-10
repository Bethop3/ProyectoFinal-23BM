using ProyectoFinal_23BM.Context;
using ProyectoFinal_23BM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_23BM.services
{
    public class UsuarioServices
    {
        public void AddUser(Usuario request)
        {
            try
            {
                if(request != null)
                {
                    using (var _context = new ApplicationDbContext())
                    {
                        Usuario res = new Usuario();
                        res.Nombre = request.Nombre;
                        res.UserName = request.UserName;
                        res.Password = request.Password;
                        _context.Usuarios.Add(res);
                        _context.SaveChanges();

                    }
                }

            }catch (Exception ex)
            {
                throw new Exception("Sucedio un error "+ex.Message);
            }
        }
        public List<Usuario > GetUsuarios()
        {
            try
            {
                using(var _context = new ApplicationDbContext())
                {
                    List<Usuario> res = _context.Usuarios.ToList();
                    if(res.Count > 0)
                    {
                        return res;
                    }
                    return res;

                }

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
