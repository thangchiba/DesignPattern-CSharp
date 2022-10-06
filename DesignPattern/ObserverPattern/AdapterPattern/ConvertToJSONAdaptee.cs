﻿namespace AdapterPattern
{
    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    class ConvertToJSONAdaptee
    {
        public string Convert()
        {
            return "This is JSON";
        }
    }
}