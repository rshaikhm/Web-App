using ExternalFTPInjestion.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Models;
using Test2.Models.Domain;
using Test2.Models.DTO;
using Test2.Models.Repository;

namespace Test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalFTPController : ControllerBase
    {
        private readonly IDataRepository<TblInboundSourceSetup, TblInboundSourceSetupDTO> _tblInboundSourceSetupRepository;
        private static pcssqldbconfigpayroll360devContext _configContext;

        public ExternalFTPController(IDataRepository<TblInboundSourceSetup, TblInboundSourceSetupDTO> tblInboundSourceSetupRepository)
        {
            _tblInboundSourceSetupRepository = tblInboundSourceSetupRepository;
        }

        
        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult Get(int id = 1)
        {
            var result = _tblInboundSourceSetupRepository.GetDto(id);
            if (result == null)
            {
                return NotFound("Author not found.");
            }

            return Ok(result);
        }
        
    }
}
