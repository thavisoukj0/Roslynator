﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Roslynator.CSharp.Refactorings.Tests
{
    internal static class AddEmptyLineBetweenDeclarationsRefactoring
    {
        private class Foo
        {
            public readonly string Field;
            /// <summary>
            /// ...
            /// </summary>
            public string Property { get; }
            public void Method()
            {
            }
        }
    }
}
