﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cogito.Nancy.Razor
{

    /// <summary>
    /// An html string that is not encoded.
    /// </summary>
    public class NonEncodedHtmlString : IHtmlString
    {

        public static implicit operator NonEncodedHtmlString(string value)
        {
            return new NonEncodedHtmlString(value);
        }

        /// <summary>
        /// Represents the empty <see cref="NonEncodedHtmlString"/>. This field is readonly.
        /// </summary>
        public static readonly NonEncodedHtmlString Empty = new NonEncodedHtmlString(string.Empty);

        readonly string value;

        /// <summary>
        /// Initializes a new instance of the <see cref="NonEncodedHtmlString"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public NonEncodedHtmlString(string value)
        {
            this.value = value;
        }

        /// <summary>
        /// Returns an HTML-encoded string.
        /// </summary>
        /// <returns>An HTML-encoded string.</returns>
        public string ToHtmlString()
        {
            return value;
        }

    }

}
