﻿using System;

namespace Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ValidateRequestAttribute : Attribute
    {
    }
}