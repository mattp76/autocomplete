using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace autocomplete.Models
{
    public class RootObject
    {
        public List<Prediction> predictions { get; set; }
        public string status { get; set; }
    }
}