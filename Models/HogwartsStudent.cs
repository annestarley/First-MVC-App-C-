using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml.Linq;

namespace FirstMVC.Models
    {
        public class HogwartsStudent
        {
            public string Name { get; set; }
            public string House { get; set; }
            public int CurrentYear { get; set; }
        }

    }