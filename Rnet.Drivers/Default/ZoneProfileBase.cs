﻿namespace Rnet.Drivers.Default
{

    /// <summary>
    /// Serves as a simple profile implementation base for a zone.
    /// </summary>
    public abstract class ZoneProfileBase : ProfileBase
    {

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="zone"></param>
        protected ZoneProfileBase(RnetZone zone)
            : base(zone)
        {

        }

        protected new RnetZone Target
        {
            get { return (RnetZone)base.Target; }
        }

        protected RnetZone Zone
        {
            get { return Target; }
        }

    }

}