using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Helpers;
using WebApplication.Models;
using System.Web.Script.Serialization;

namespace WebApplication.Controllers
{
    public class CompetitorController : ApiController
    {
        IDataProvider provider = new DataProviderEF();
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        // GET: api/Competitor
        public IEnumerable<User> Get(string id)
        {
            List<User> list = provider.GetUserCompetitors(id);
            return list;
        }
    }
}
