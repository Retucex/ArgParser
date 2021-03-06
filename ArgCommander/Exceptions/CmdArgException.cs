﻿using System;
using System.Runtime.Serialization;

namespace ArgCommander.Exceptions
{
    [Serializable]
    public class CmdArgException : Exception
    {
        const string DefaultMessage = "Failed to parse argument";

        public string Argument { get; set; }

        public CmdArgException(string argument) : base($"{DefaultMessage} '{argument}'.") => Argument = argument;
        public CmdArgException(string argument, string message) : base(message) => Argument = argument;
        public CmdArgException(string argument, string message, Exception innerException) : base(message, innerException) => Argument = argument;
        protected CmdArgException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
