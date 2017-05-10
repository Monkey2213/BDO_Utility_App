using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDO_Utility_Application.Models
{
    public class Tool
    {
        public Tool()
        {

        }

        public Tool(string name)
        {
            this.Name = name;
        }

        public virtual int ToolID { get; set; }

        public virtual string Name { get; set; }

        public virtual int Durability { get; set; }

        public virtual float Cost { get; set; }

        public virtual string Description { get; set; }

        public virtual ProcessType ItemEffectName { get; set; }

        public virtual int ItemEffectValue { get; set; }
    }
}