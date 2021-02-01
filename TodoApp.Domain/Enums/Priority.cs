using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Domain.Enums
{
    public enum Priority
    {
        /// <summary>
        /// The lowest possible priority (0).
        /// </summary>
        
        Lowest,
        /// <summary>
        /// The Below normal priority (1).
        /// </summary>
        
        BelowNormal,

        /// <summary>
        /// The normal priority (2).
        /// </summary>
        Normal,

        /// <summary>
        /// Its above normal priority (3).
        /// </summary>
        AboveNormal,

        /// <summary>
        /// It is the higest priority possible (4).
        /// </summary>
        Highest,



    }
}
