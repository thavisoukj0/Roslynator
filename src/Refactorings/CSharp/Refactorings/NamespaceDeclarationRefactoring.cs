﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslynator.CSharp.Refactorings.SortMemberDeclarations;

namespace Roslynator.CSharp.Refactorings
{
    internal static class NamespaceDeclarationRefactoring
    {
        public static void ComputeRefactorings(RefactoringContext context, NamespaceDeclarationSyntax namespaceDeclaration)
        {
            if (context.IsRefactoringEnabled(RefactoringDescriptors.SortMemberDeclarations)
                && namespaceDeclaration.BracesSpan().Contains(context.Span))
            {
                SortMemberDeclarationsRefactoring.ComputeRefactoring(context, namespaceDeclaration);
            }
        }
    }
}
