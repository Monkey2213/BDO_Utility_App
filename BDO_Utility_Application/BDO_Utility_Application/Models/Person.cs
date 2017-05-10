using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDO_Utility_Application.Models
{
    public class Person
    {
        public Person()
        {

        }


        public Person(string name)
        {
            this.Name = name;
        }

        public virtual int PersonID { get; set; }

        public virtual string Name { get; set; }

        public virtual Occupation Job { get; set; }

        public virtual Node Location { get; set; }
    }
}