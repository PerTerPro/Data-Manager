using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Crl.ProducProperties.Core.Entity
{
    public class Product
    {
        [Description("DetailUrl")]

        public string DetailUrl { get; set; }

        [Description("Id")]
        public long Id { get; set; }

        [Description("ClassificationId")]
        public long ClassificationId { get; set; }


        [Description("Classification")]
        public string Classification { get; set; }
    }


}
