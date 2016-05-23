using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MotoMy.Models;

namespace MotoMy.Globals
{
    public static class SessionHandler
    {
        

        public static User ActiveUser
        {
            get
            {
                return HttpContext.Current.Session["ActiveUser"] as User;
            }
            set
            {
                HttpContext.Current.Session["ActiveUser"] = value;
            }
        }


    }
}