﻿using System;
using System.ComponentModel.Composition;

namespace Nancy.Bootstrapper.Mef
{

    /// <summary>
    /// Derived attribute version for exporting Nancy types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    [MetadataAttribute]
    public class NancyGeneratedPartAttribute : Attribute, INancyGeneratedPartMetadata
    {

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public NancyGeneratedPartAttribute()
            : base()
        {

        }

        public bool AutoGenerated
        {
            get { return true; }
        }

    }

}