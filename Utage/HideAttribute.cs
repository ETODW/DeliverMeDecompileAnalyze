﻿namespace Utage
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine;

    public class HideAttribute : PropertyAttribute
    {
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string <Function>k__BackingField;

        public HideAttribute(string function = "")
        {
            this.Function = function;
        }

        public string Function { get; set; }
    }
}

