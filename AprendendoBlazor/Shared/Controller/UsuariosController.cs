
using AprendendoBlazor.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
namespace AprendendoBlazor.Shared.Controller
{
    [ApiController]
    class UsuariosController : ControllerBase
    {
        private ApplicationDbContext _Contexto;

        public UsuariosController(ApplicationDbContext Contexto)
        {
            _Contexto = Contexto;
        }

        public ActionResult<bool> AdicionaUsuario(Usuario novoUsuario)
        {
            Usuario user1 = new Usuario()
            {
                Checked = novoUsuario.Checked,
                Nome = novoUsuario.Nome,
                Email = novoUsuario.Email,
                DataNascimento = novoUsuario.DataNascimento,
                Id = novoUsuario.Id
            };

            _Contexto.Usuario.Add(user1);

            _Contexto.SaveChanges();


            return true;
        }

        public ActionResult<List<Usuario>> BuscaUsuarios()
        {
            List<Usuario> UsuariosDb = new List<Usuario>();
            UsuariosDb = (List<Usuario>)_Contexto.Usuario.Where(u => u.Id != null);

            return UsuariosDb;
        }
    }
}
}*/
