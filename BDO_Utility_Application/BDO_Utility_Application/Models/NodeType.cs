using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDO_Utility_Application.Models
{
    public class NodeType
    {
        public NodeType()
        {

        }

        public NodeType(string name)
        {
            this.Name = name;
        }

        public virtual int NodeTypeID { get; set; }

        public virtual string Name { get; set; }

    }
}