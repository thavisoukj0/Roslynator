﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

#pragma warning disable RCS1118

namespace Roslynator.CSharp.Analyzers.Tests
{
    public static class AvoidChainOfAssignments
    {
        private static void Foo()
        {
            string s = null;
            string s2 = null;

            string x = s = s2;

            x = s = s2;
        }
    }
}
