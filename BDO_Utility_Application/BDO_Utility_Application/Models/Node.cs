using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDO_Utility_Application.Models
{
    public class Node
    {

        public Node()
        {
            
        }

        public Node(string name)
        {
            this.Name = name;
        }

        public virtual int NodeID { get; set; }

        public virtual string Name { get; set; }

        public virtual Territory Area { get; set; }

        public virtual ICollection<RawMaterial> Materials { get; set; }

        public virtual NodeType Type { get; set; }
    }
}