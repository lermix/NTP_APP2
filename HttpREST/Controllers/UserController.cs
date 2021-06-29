using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpREST.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public string Select()
        {
            return JsonConvert.SerializeObject(DatabaseManager.UserManager.GetUsers());
        }
        [HttpPost]
        public string Insert(User user)
        {
            DatabaseManager.UserManager.InserUser(user);
            return JsonConvert.SerializeObject(new List<User> { user });
        }

        [HttpPost]
        public string Delete(User user)
        {
            DatabaseManager.UserManager.DeleteUser(user.id);
            return JsonConvert.SerializeObject(new List<User> { user });
        }

        [HttpPost]
        public string Update(User user)
        {
            DatabaseManager.UserManager.UpdateUser(user);
            return JsonConvert.SerializeObject(new List<User> { user });
        }
    }
}