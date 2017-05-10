using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDO_Utility_Application.Models
{
    public class Occupation
    {
        public Occupation()
        {

        }

        public Occupation(string name)
        {
            this.Name = name;
        }

        public virtual int OccupationID { get; set; }

        public virtual string Name { get; set; }
    }
}