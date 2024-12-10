using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Security.Cryptography;
using System.Text;
using WebApiDesarrolloSeguro.Clases;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.Net;

namespace WebApiCerescos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CriptografiaController : ControllerBase
    {
        private IConfiguration configuration;

        private readonly ILogger<CriptografiaController> _logger;

        public CriptografiaController(ILogger<CriptografiaController> logger, IConfiguration _configuration)
        {
            _logger = logger;
            configuration = _configuration;
        }
        [HttpPost("CifrarClave")]
        [Authorize]
        public async Task<ActionResult<CifraClave>> CifraClave(CifraClave request)
        {
            CifraClave respuesta = new CifraClave();

            try
            {
                respuesta.Clave = "PruebaHola";
            }
            catch (Exception e)
            {
            }
            return Ok(respuesta);
        }


    }

}