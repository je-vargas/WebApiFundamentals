using System;
using System.Threading.Tasks;
using System.Web.Http;
using TheCodeCamp.Data;

namespace TheCodeCamp.Controllers
{
    public class CampsController : ApiController
    {
        private readonly ICampRepository _repository;
        public CampsController(ICampRepository repository)
        {
            _repository = repository;
        }
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var result = await _repository.GetAllCampsAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                //TODO Add logging 
                return InternalServerError(ex);
            }
       
        }

    }
}

//IHttpActionResult -> used instead as it returns status codes