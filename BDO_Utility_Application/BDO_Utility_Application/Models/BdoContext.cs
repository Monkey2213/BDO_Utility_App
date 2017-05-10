using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BDO_Utility_Application.Models
{
    public partial class BdoContext : DbContext
    {
        public BdoContext()
            : base("BdoConnection")
        {

        }

        public virtual DbSet<Node> Nodes { get; set; }

        public virtual DbSet<NodeType> NodeTypes { get; set; }

        public virtual DbSet<Occupation> Occupations { get; set; }

        public virtual DbSet<Person> Persons { get; set; }

        public virtual DbSet<ProcessType> ProcessTypes { get; set; }

        public virtual DbSet<RawMaterial> RawMaterials { get; set; }

        public virtual DbSet<Territory> Territories { get; set; }

        public virtual DbSet<Tool> Tools { get; set; }

    }
}