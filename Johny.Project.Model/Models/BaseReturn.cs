using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johny.Project.Model.Models
{
    public class BaseReturn
    {
        public int total { get; set; }
        public object rows { get; set; }
        public foot[] footer { get; set; }
    }

    public class foot
    {
        public string SendYear { set; get; }
        public string SendBatch { set; get; }
        public string PesticidesSpecifications { get; set; }
        public string PesticidesPrice { get; set; }
        public string TotalMoney { get; set; }
        public string PesticidesCount { get; set; }
        public string ShareMoney { get; set; }
        public string PesticidesName { get; set; }
    }
}
