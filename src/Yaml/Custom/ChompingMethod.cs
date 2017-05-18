using System;
using System.Collections.Generic;
using System.Text;

namespace QingStor_SDK_NET.Yaml
{
    /// <summary>
    /// How line breaks after last non empty line in block scalar are handled.
    /// </summary>
    public enum ChompingMethod
    {
        /// <summary>
        /// Keep one
        /// </summary>
        Clip,

        /// <summary>
        /// Keep none
        /// </summary>
        Strip,

        /// <summary>
        /// Keep all
        /// </summary>
        Keep
    }
}
