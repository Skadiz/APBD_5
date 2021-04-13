﻿using System;
using System.Runtime.Serialization;

namespace CW5.Exceptions
{
    [Serializable]
    internal class NoResultException : Exception
    {
        public NoResultException()
        {
        }

        public NoResultException(string message) : base(message)
        {
        }

        public NoResultException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoResultException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}