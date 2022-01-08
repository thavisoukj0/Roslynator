﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

using System;
using Microsoft.CodeAnalysis;

namespace Roslynator.Formatting.CSharp
{
    public static partial class DiagnosticRules
    {
        /// <summary>RCS0001</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineAfterEmbeddedStatement = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineAfterEmbeddedStatement, 
            title:              "Add empty line after embedded statement.", 
            messageFormat:      "Add empty line after embedded statement.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineAfterEmbeddedStatement, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0002</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineAfterRegionDirective = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineAfterRegionDirective, 
            title:              "Add empty line after #region.", 
            messageFormat:      "Add empty after #region.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineAfterRegionDirective, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0003</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineAfterUsingDirectiveList = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineAfterUsingDirectiveList, 
            title:              "Add empty line after using directive list.", 
            messageFormat:      "Add empty line after using directive list.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineAfterUsingDirectiveList, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0005</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBeforeEndRegionDirective = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBeforeEndRegionDirective, 
            title:              "Add empty line before #endregion.", 
            messageFormat:      "Add empty line before #endregion.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBeforeEndRegionDirective, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0006</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBeforeUsingDirectiveList = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBeforeUsingDirectiveList, 
            title:              "Add empty line before using directive list.", 
            messageFormat:      "Add empty line before using directive list.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBeforeUsingDirectiveList, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0007</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenAccessors = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenAccessors, 
            title:              "Add empty line between accessors.", 
            messageFormat:      "Add empty line between accessors.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBetweenAccessors, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0008</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenBlockAndStatement = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenBlockAndStatement, 
            title:              "Add empty line between block and statement.", 
            messageFormat:      "Add empty line between block and statement.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBetweenBlockAndStatement, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0009</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenDeclarationAndDocumentationComment = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenDeclarationAndDocumentationComment, 
            title:              "Add empty line between declaration and documentation comment.", 
            messageFormat:      "Add empty line between declaration and documentation comment.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBetweenDeclarationAndDocumentationComment, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0010</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenDeclarations = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenDeclarations, 
            title:              "Add empty line between declarations.", 
            messageFormat:      "Add empty line between declarations.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBetweenDeclarations, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0011</summary>
        public static readonly DiagnosticDescriptor BlankLineBetweenSingleLineAccessors = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.BlankLineBetweenSingleLineAccessors, 
            title:              "Add/remove blank line between single-line accessors.", 
            messageFormat:      "{0} blank line between single-line accessors.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.BlankLineBetweenSingleLineAccessors, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0012</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenSingleLineDeclarations = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenSingleLineDeclarations, 
            title:              "Add empty line between single-line declarations.", 
            messageFormat:      "Add empty line between single-line declarations.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBetweenSingleLineDeclarations, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0013</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenSingleLineDeclarationsOfDifferentKind = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenSingleLineDeclarationsOfDifferentKind, 
            title:              "Add empty line between single-line declarations of different kind.", 
            messageFormat:      "Add empty line between single-line declarations of different kind.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBetweenSingleLineDeclarationsOfDifferentKind, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0014</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBetweenSwitchSections = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBetweenSwitchSections, 
            title:              "Add empty line between switch sections.", 
            messageFormat:      "Add empty line between switch sections.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBetweenSwitchSections, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0015</summary>
        public static readonly DiagnosticDescriptor BlankLineBetweenUsingDirectiveGroups = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.BlankLineBetweenUsingDirectiveGroups, 
            title:              "Add/remove empty line between using directive groups.", 
            messageFormat:      "{0} empty line between using directive groups.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.BlankLineBetweenUsingDirectiveGroups, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0016</summary>
        public static readonly DiagnosticDescriptor PutAttributeListOnItsOwnLine = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PutAttributeListOnItsOwnLine, 
            title:              "Put attribute list on its own line.", 
            messageFormat:      "Put attribute list on its own line.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PutAttributeListOnItsOwnLine, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0020</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterOpeningBraceOfAccessor = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineAfterOpeningBraceOfAccessor, 
            title:              "Add new line after opening brace of accessor.", 
            messageFormat:      "Add new line after opening brace of accessor.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineAfterOpeningBraceOfAccessor, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0021</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterOpeningBraceOfBlock = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineAfterOpeningBraceOfBlock, 
            title:              "Add new line after opening brace of block.", 
            messageFormat:      "Add new line after opening brace of block.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineAfterOpeningBraceOfBlock, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0022</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterOpeningBraceOfEmptyBlock = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineAfterOpeningBraceOfEmptyBlock, 
            title:              "Add new line after opening brace of empty block.", 
            messageFormat:      "Add new line after opening brace of empty block.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineAfterOpeningBraceOfEmptyBlock, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0023</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterOpeningBraceOfTypeDeclaration = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineAfterOpeningBraceOfTypeDeclaration, 
            title:              "Add new line after opening brace of type declaration.", 
            messageFormat:      "Add new line after opening brace of type declaration.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineAfterOpeningBraceOfTypeDeclaration, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0024</summary>
        public static readonly DiagnosticDescriptor AddNewLineAfterSwitchLabel = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineAfterSwitchLabel, 
            title:              "Add new line after switch label.", 
            messageFormat:      "Add new line after switch label.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineAfterSwitchLabel, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0025</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeAccessorOfFullProperty = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeAccessorOfFullProperty, 
            title:              "Add new line before accessor of full property.", 
            messageFormat:      "Add new line before accessor of full property.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineBeforeAccessorOfFullProperty, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0027</summary>
        public static readonly DiagnosticDescriptor PlaceNewLineAfterOrBeforeBinaryOperator = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PlaceNewLineAfterOrBeforeBinaryOperator, 
            title:              "Place new line after/before binary operator.", 
            messageFormat:      "Place new line {0} binary operator.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PlaceNewLineAfterOrBeforeBinaryOperator, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0028</summary>
        public static readonly DiagnosticDescriptor PlaceNewLineAfterOrBeforeConditionalOperator = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PlaceNewLineAfterOrBeforeConditionalOperator, 
            title:              "Place new line after/before '?:' operator.", 
            messageFormat:      "Place new line {0} operator.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PlaceNewLineAfterOrBeforeConditionalOperator, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0029</summary>
        public static readonly DiagnosticDescriptor PutConstructorInitializerOnItsOwnLine = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PutConstructorInitializerOnItsOwnLine, 
            title:              "Put constructor initializer on its own line.", 
            messageFormat:      "Put constructor initializer on its own line.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PutConstructorInitializerOnItsOwnLine, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0030</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeEmbeddedStatement = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeEmbeddedStatement, 
            title:              "Add new line before embedded statement.", 
            messageFormat:      "Add new line before embedded statement.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineBeforeEmbeddedStatement, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0031</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeEnumMember = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeEnumMember, 
            title:              "Add new line before enum member.", 
            messageFormat:      "Add new line before enum member.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineBeforeEnumMember, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0032</summary>
        public static readonly DiagnosticDescriptor PlaceNewLineAfterOrBeforeArrowToken = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PlaceNewLineAfterOrBeforeArrowToken, 
            title:              "Place new line after/before arrow token.", 
            messageFormat:      "Place new line {0} arrow token.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PlaceNewLineAfterOrBeforeArrowToken, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0033</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeStatement = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeStatement, 
            title:              "Add new line before statement.", 
            messageFormat:      "Add new line before statement.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineBeforeStatement, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0034</summary>
        public static readonly DiagnosticDescriptor AddNewLineBeforeTypeParameterConstraint = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddNewLineBeforeTypeParameterConstraint, 
            title:              "Add new line before type parameter constraint.", 
            messageFormat:      "Add new line before type parameter constraint.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddNewLineBeforeTypeParameterConstraint, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0036</summary>
        public static readonly DiagnosticDescriptor RemoveEmptyLineBetweenSingleLineDeclarationsOfSameKind = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.RemoveEmptyLineBetweenSingleLineDeclarationsOfSameKind, 
            title:              "Remove empty line between single-line declarations of same kind.", 
            messageFormat:      "Remove empty line between single-line declarations of same kind.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.RemoveEmptyLineBetweenSingleLineDeclarationsOfSameKind, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0038</summary>
        public static readonly DiagnosticDescriptor RemoveEmptyLineBetweenUsingDirectivesWithSameRootNamespace = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.RemoveEmptyLineBetweenUsingDirectivesWithSameRootNamespace, 
            title:              "Remove empty line between using directives with same root namespace.", 
            messageFormat:      "Remove empty line between using directives.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.RemoveEmptyLineBetweenUsingDirectivesWithSameRootNamespace, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0039</summary>
        public static readonly DiagnosticDescriptor RemoveNewLineBeforeBaseList = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.RemoveNewLineBeforeBaseList, 
            title:              "Remove new line before base list.", 
            messageFormat:      "Remove new line before base list.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.RemoveNewLineBeforeBaseList, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0041</summary>
        public static readonly DiagnosticDescriptor RemoveNewLineBetweenIfKeywordAndElseKeyword = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.RemoveNewLineBetweenIfKeywordAndElseKeyword, 
            title:              "Remove new line between 'if' keyword and 'else' keyword.", 
            messageFormat:      "Remove new line between 'if' keyword and 'else' keyword.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.RemoveNewLineBetweenIfKeywordAndElseKeyword, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0042</summary>
        public static readonly DiagnosticDescriptor PutAutoAccessorsOnSingleLine = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PutAutoAccessorsOnSingleLine, 
            title:              "Put auto-accessors on a single line.", 
            messageFormat:      "Put auto-accessors on a single line.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PutAutoAccessorsOnSingleLine, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0043</summary>
        public static readonly DiagnosticDescriptor PutAccessorOnSingleLine = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PutAccessorOnSingleLine, 
            title:              "Put accessor on a single line.", 
            messageFormat:      "Put accessor on a single line.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PutAccessorOnSingleLine, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0044</summary>
        public static readonly DiagnosticDescriptor UseCarriageReturnAndLinefeedAsNewLine = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.UseCarriageReturnAndLinefeedAsNewLine, 
            title:              "Use carriage return + linefeed as new line.", 
            messageFormat:      "Use carriage return + linefeed as new line.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.UseCarriageReturnAndLinefeedAsNewLine, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0045</summary>
        public static readonly DiagnosticDescriptor UseLinefeedAsNewLine = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.UseLinefeedAsNewLine, 
            title:              "Use linefeed as new line.", 
            messageFormat:      "Use linefeed as new line.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.UseLinefeedAsNewLine, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0046</summary>
        public static readonly DiagnosticDescriptor UseSpacesInsteadOfTab = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.UseSpacesInsteadOfTab, 
            title:              "Use spaces instead of tab.", 
            messageFormat:      "Use spaces instead of tab.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.UseSpacesInsteadOfTab, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0047</summary>
        public static readonly DiagnosticDescriptor WrapAndIndentEachNodeInList = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.WrapAndIndentEachNodeInList, 
            title:              "[deprecated] Wrap and indent each node in list.", 
            messageFormat:      "[deprecated] Use analyzer RCS0053 instead.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.WrapAndIndentEachNodeInList, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0048</summary>
        public static readonly DiagnosticDescriptor PutInitializerOnSingleLine = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PutInitializerOnSingleLine, 
            title:              "Put initializer on a single line.", 
            messageFormat:      "Put initializer on a single line.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PutInitializerOnSingleLine, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0049</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineAfterTopComment = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineAfterTopComment, 
            title:              "Add empty line after top comment.", 
            messageFormat:      "Add empty line after top comment.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineAfterTopComment, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0050</summary>
        public static readonly DiagnosticDescriptor AddEmptyLineBeforeTopDeclaration = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddEmptyLineBeforeTopDeclaration, 
            title:              "Add empty line before top declaration.", 
            messageFormat:      "Add empty line before top declaration.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddEmptyLineBeforeTopDeclaration, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0051</summary>
        public static readonly DiagnosticDescriptor AddOrRemoveNewLineBeforeWhileInDoStatement = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.AddOrRemoveNewLineBeforeWhileInDoStatement, 
            title:              "Add/remove new line before 'while' in 'do' statement.", 
            messageFormat:      "{0} new line before 'while' in 'do' statement.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddOrRemoveNewLineBeforeWhileInDoStatement, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0052</summary>
        public static readonly DiagnosticDescriptor PlaceNewLineAfterOrBeforeEqualsToken = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.PlaceNewLineAfterOrBeforeEqualsToken, 
            title:              "Place new line after/before equals token.", 
            messageFormat:      "Place new line {0} equals token.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.PlaceNewLineAfterOrBeforeEqualsToken, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0053</summary>
        public static readonly DiagnosticDescriptor FixFormattingOfList = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.FixFormattingOfList, 
            title:              "Fix formatting of a list.", 
            messageFormat:      "Fix formatting of {0}.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.FixFormattingOfList, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0054</summary>
        public static readonly DiagnosticDescriptor FixFormattingOfCallChain = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.FixFormattingOfCallChain, 
            title:              "Fix formatting of a call chain.", 
            messageFormat:      "Fix formatting of a call chain.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.FixFormattingOfCallChain, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0055</summary>
        public static readonly DiagnosticDescriptor FixFormattingOfBinaryExpressionChain = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.FixFormattingOfBinaryExpressionChain, 
            title:              "Fix formatting of a binary expression chain.", 
            messageFormat:      "Fix formatting of a binary expression chain.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.FixFormattingOfBinaryExpressionChain, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0056</summary>
        public static readonly DiagnosticDescriptor LineIsTooLong = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.LineIsTooLong, 
            title:              "A line is too long.", 
            messageFormat:      "A line is too long ({0} characters).", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.LineIsTooLong, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0057</summary>
        public static readonly DiagnosticDescriptor NormalizeWhitespaceAtBeginningOfFile = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.NormalizeWhitespaceAtBeginningOfFile, 
            title:              "Normalize whitespace at the beginning of a file.", 
            messageFormat:      "Normalize whitespace at the beginning of a file.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.NormalizeWhitespaceAtBeginningOfFile, 
            customTags:         Array.Empty<string>());

        /// <summary>RCS0058</summary>
        public static readonly DiagnosticDescriptor NormalizeWhitespaceAtEndOfFile = DiagnosticDescriptorFactory.Create(
            id:                 DiagnosticIdentifiers.NormalizeWhitespaceAtEndOfFile, 
            title:              "Normalize whitespace at the end of a file.", 
            messageFormat:      "Normalize whitespace at the end of a file.", 
            category:           DiagnosticCategories.Roslynator, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.NormalizeWhitespaceAtEndOfFile, 
            customTags:         Array.Empty<string>());

    }
}