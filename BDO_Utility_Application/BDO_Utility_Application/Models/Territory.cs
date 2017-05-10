using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDO_Utility_Application.Models
{
    public class Territory
    {
        public Territory()
        {

        }

        public Territory(string name)
        {
            this.Name = name;
        }

        public virtual int TerritoryID { get; set; }

        public virtual string Name { get; set; }
    }
}