﻿using System;
using System.Xml.Serialization;

namespace Rnet.Service.Objects
{

    public class ObjectRef
    {

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlIgnore]
        public Uri Href { get; set; }

        [XmlAttribute("Href")]
        public string _Href
        {
            get { return Href.ToString(); }
            set { Href = new Uri(value); }
        }

        [XmlAttribute("Name")]
        public string Name { get; set; }

    }

}
