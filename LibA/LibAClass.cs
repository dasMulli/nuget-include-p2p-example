using System;
using LibB;
using PrivateLib;

namespace LibA
{
    public class LibAClass
    {
        public static readonly string Name = $"{nameof(LibAClass)} - using {LibBClass.Name} and {PrivateLibClass.Name}";
    }
}
