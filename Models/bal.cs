using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myproject.Models
{
    public class Bal
    {
        Dbconnection db = new Dbconnection();
        public string Register(Register register)
        {
            return db.Register(register);
        }
    }
}