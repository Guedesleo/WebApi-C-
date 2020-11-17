using System;
using System.Collections.Generic;
using ApiCarros.DataBase;
using ApiCarros.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCarros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcasFabricacaoController : ControllerBase
    {
        private dbAdo db;
        [HttpGet]
        public List<marcasFabricacao> Get()
        {
            db = new dbAdo();
            List<marcasFabricacao> marcasFabricacaos = db.marcasFabricacao();
            return marcasFabricacaos;

        }
    }
}
