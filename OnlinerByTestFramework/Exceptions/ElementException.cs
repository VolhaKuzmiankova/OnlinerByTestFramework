﻿#nullable enable
using System;

namespace OnlinerByTestFramework.Exceptions
{
    public class ElementException : Exception
    {
        public ElementException()
        {
        }

        public ElementException(string? message) : base(message)
        {
        }

        public ElementException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}