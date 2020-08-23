using System.Web.Http;

namespace TheCodeCamp.Controllers
{
    public class CampsController : ApiController
    {
        //Handleing Errors this way does not work! as well !! 
        public object Get()
        {
            return new {Name = "Shawn", Occupation = "Teacher "};
        }
    }
}