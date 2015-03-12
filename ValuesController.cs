using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapicrud.Controllers
{
    public class UserController : ApiController
    {
        
        [Route("api/login/")]
        public IEnumerable<string> Get(string username,string password)
        {
           // return new string[] { "value1", "value2" };
            UserHandler userHandler = new UserHandler();
            return ConvertDictionaryToList(userHandler.Login(username,password));
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        //[Route("api/register")]
        public string Put([FromBody]UserDto userDto)
        {
            return userDto.username;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        private List<string> ConvertDictionaryToList(Dictionary<string, string> values)
        {
            List<string> returnMessage = new List<string>();
            foreach (KeyValuePair<string, string> kp in values)
            {
                string s = kp.Key + ":" + kp.Value;
                returnMessage.Add(s);
            }
            return returnMessage;
        }
    }
}
