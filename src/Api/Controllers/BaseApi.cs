using System;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class BaseApi : Controller
    {
        public int CurrentUserId
        {
            get
            {
                int userId = default(int);

                if (!string.IsNullOrEmpty(User.Identity.Name))
                {
                    int.TryParse(User.Identity.Name, out userId);
                }

                return userId;
            }
        }
        protected string GetRequestGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}