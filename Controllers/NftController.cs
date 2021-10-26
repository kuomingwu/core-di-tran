using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using jon_crud.Service ; 
namespace jon_crud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NftController : ControllerBase
    {

        private readonly ILogger<NftController> _logger;

        private readonly IScoped _scoped;

        private readonly ISingleton _singleton;
        public NftController(ILogger<NftController> logger , IScoped scoped , ISingleton singleton)
        {
            _logger = logger;
            _scoped = scoped ; 
            _singleton = singleton ; 
        }

        [HttpGet]
        [Route("scoped")]
        public string Scoped(){

            return _scoped.Id;
        }

        [HttpGet]
        [Route("singleton")]
        public string Singleton(){

            return _singleton.Id;
        }

        [HttpGet]
        public IEnumerable<IScoped> Get()
        {
            ScopedService[] NftArray = new ScopedService[3]
            {
                new ScopedService(),
                new ScopedService(),
                new ScopedService(),
            };

            return NftArray ;

        }

    }

}