using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDO_Utility_Application.Models
{
    public class ProcessType
    {

        public ProcessType()
        {

        }
        public ProcessType(string name)
        {
            this.Name = name;
        }

        public virtual int ProcessTypeID { get; set; }

        public virtual string Name { get; set; }

        public virtual bool Worker { get; set; }
    }
}