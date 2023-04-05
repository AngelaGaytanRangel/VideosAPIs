using Microsoft.AspNetCore.Mvc;
using NetCoreVideo.Models;

namespace NetCoreVideo.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            //Todo el codigo
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    Id = "1",
                    correo = "google.gmail.com",
                    edad = "19",
                    nombre = "Bernardo Peña"
                },
                new Cliente
                {
                    Id = "2",
                    correo = "miguelgoogle.gmail.com",
                    edad = "23",
                    nombre = "Miguel Mantilla"
                }
            };
            return clientes;

        }[HttpGet]
        [Route("listarClientesxid")]
        public dynamic listarClientesxid(string _id)
        {
            //Todo el codigo
            return new Cliente
                {
                    Id = "2",
                    correo = "miguelgoogle.gmail.com",
                    edad = "23",
                    nombre = "Miguel Mantilla"
            };

        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente)
        {
            cliente.Id = "3";
            return new
            {
                success = true,
                message = "Cliente Regsitrado",
                result = cliente
            };
        }
        
        [HttpPost]
        [Route("eliminar")]
        public dynamic eliminarCliente(Cliente cliente)
        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
            
            return new
            {
                success = true,
                message = "Cliente Eliminado",
                result = cliente
            };
        }



    }
}
