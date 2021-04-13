using AprendendoBlazor.Server.Data;
using AprendendoBlazor.Shared.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendendoBlazor.Server.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private ApplicationDbContext _Contexto;

        public UsuariosController(ApplicationDbContext Contexto)
        {
            _Contexto = Contexto;
        }
        public ActionResult<bool> VerificarSeUsuarioExiste(int Id)
        {
            return true;
        }

        
        [HttpPost]
        public ActionResult<int> AdicionaUsuario(Usuario novoUsuario)
        {
            Usuario user1 = new Usuario()
            {
                Checked = novoUsuario.Checked,
                Nome = novoUsuario.Nome,
                Email = novoUsuario.Email,
                DataNascimento = novoUsuario.DataNascimento,
              
            };

            _Contexto.Usuario.Add(user1);

            _Contexto.SaveChanges();


            return user1.Id;
        }

        public ActionResult<List<Usuario>> BuscaUsuarios()
        {
            List<Usuario> UsuariosDb = new List<Usuario>();
            UsuariosDb = _Contexto.Usuario.Where(u => u.Id != null).ToList();

            return UsuariosDb;
        } 

        [HttpPost]
        public ActionResult<bool> ExcluiUsuario(Usuario user)
        {

            Console.WriteLine("Controller recebeu o ID: {0} para ser excluido!", user.Id);
            int _id = user.Id;
            if(_id > 0)
            {
                Console.WriteLine("Mensagem de dentro do controller, excluir usuario de Id: {0}", _id);
                Usuario ParaRemover = _Contexto.Usuario.FirstOrDefault(u => u.Id == _id);
                _Contexto.Usuario.Remove(ParaRemover);
                _Contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
