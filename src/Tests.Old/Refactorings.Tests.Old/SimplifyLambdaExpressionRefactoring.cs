﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;

namespace Roslynator.CSharp.Refactorings.Tests
{
    internal class SimplifyLambdaExpressionRefactoring
    {
        public void SomeMethod(string value)
        {

            IEnumerable<int> items = Enumerable.Range(0, 10);

            items = items.Select(f =>
            {
                return f + 1;
            });
        }
    }
}
