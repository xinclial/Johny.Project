using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Johny.Project.Models
{
    public class Menu
    {
        public Menu()
        {
            Nodes = new List<ChildNode>();
        }

        public int ID { set; get; }

        public string Href { set; get; }

        public string Name { set; get; }
         
        public List<ChildNode> Nodes { set; get; }
    }

    public class ChildNode
    {
        public int ID { set; get; }

        public string ChildHref { set; get; }

        public string ChildName { set; get; }
    }
}