using System.Web.Http;
using QuizData;
using System.Linq;
using QuizApi.Extensions;

namespace QuizApi.Controllers
{
    public class UserController : BaseController
    {
        [HttpGet]
        public UserData[] Get(string query = null, string sort = null)
        {
            using (UserContext context = new UserContext())
            {
                var results = context.User.AsQueryable();

                if (query != null)
                {
                    results = results
                              .Where(u => (u.FirstName + " " + u.LastName).Contains(query) || u.Email.Contains(query));
                }

                if (sort != null)
                {
                    results = results
                              .sortUser(sort);
                }

                return results.ToArray();
            }
        }
    }
}
