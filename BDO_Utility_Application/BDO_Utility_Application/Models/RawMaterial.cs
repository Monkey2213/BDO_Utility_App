using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDO_Utility_Application.Models
{
    public class RawMaterial
    {

        public RawMaterial()
        {

        }

        public RawMaterial(string name)
        {
            this.Name = name;
        }

        public virtual int RawMaterialID { get; set; }

        public virtual string Name { get; set; }

        public virtual float Cost { get; set; }

        public virtual float Weight { get; set; }

        public virtual bool Specialty { get; set; }

        public virtual ProcessType Type { get; set; }
    }
}