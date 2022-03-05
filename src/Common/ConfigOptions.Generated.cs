﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

using System.Collections.Generic;

namespace Roslynator
{
    public static partial class ConfigOptions
    {
        public static readonly ConfigOptionDescriptor AccessibilityModifiers = new(
            key:                     ConfigOptionKeys.AccessibilityModifiers, 
            defaultValue:            null, 
            defaultValuePlaceholder: "explicit|implicit", 
            description:             "Prefer explicit/implicit accessibility modifiers");

        public static readonly ConfigOptionDescriptor AccessorBracesStyle = new(
            key:                     ConfigOptionKeys.AccessorBracesStyle, 
            defaultValue:            "multi_line", 
            defaultValuePlaceholder: "multi_line|single_line_when_expression_is_on_single_line", 
            description:             "Format accessor's braces on single line or multiple lines");

        public static readonly ConfigOptionDescriptor ArrayCreationTypeStyle = new(
            key:                     ConfigOptionKeys.ArrayCreationTypeStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "explicit|implicit|implicit_when_type_is_obvious", 
            description:             "Prefer explicitly/implicitly typed array");

        public static readonly ConfigOptionDescriptor ArrowTokenNewLine = new(
            key:                     ConfigOptionKeys.ArrowTokenNewLine, 
            defaultValue:            null, 
            defaultValuePlaceholder: "after|before", 
            description:             "Place new line after/before arrow token");

        public static readonly ConfigOptionDescriptor BinaryOperatorNewLine = new(
            key:                     ConfigOptionKeys.BinaryOperatorNewLine, 
            defaultValue:            null, 
            defaultValuePlaceholder: "after|before", 
            description:             "Place new line after/before binary operator");

        public static readonly ConfigOptionDescriptor BlankLineBetweenClosingBraceAndSwitchSection = new(
            key:                     ConfigOptionKeys.BlankLineBetweenClosingBraceAndSwitchSection, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Add/remove blank line between closing brace and switch section");

        public static readonly ConfigOptionDescriptor BlankLineBetweenSingleLineAccessors = new(
            key:                     ConfigOptionKeys.BlankLineBetweenSingleLineAccessors, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Add/remove blank line between single-line accessors");

        public static readonly ConfigOptionDescriptor BlankLineBetweenUsingDirectives = new(
            key:                     ConfigOptionKeys.BlankLineBetweenUsingDirectives, 
            defaultValue:            null, 
            defaultValuePlaceholder: "never|separate_groups", 
            description:             "Add/remove blank line between using directives");

        public static readonly ConfigOptionDescriptor BlockBracesStyle = new(
            key:                     ConfigOptionKeys.BlockBracesStyle, 
            defaultValue:            "multi_line", 
            defaultValuePlaceholder: "multi_line|single_line_when_empty", 
            description:             "Format block's braces on single line or multiple lines");

        public static readonly ConfigOptionDescriptor BodyStyle = new(
            key:                     ConfigOptionKeys.BodyStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "block|expression", 
            description:             "Prefer block body or expression body");

        public static readonly ConfigOptionDescriptor ConditionalOperatorConditionParenthesesStyle = new(
            key:                     ConfigOptionKeys.ConditionalOperatorConditionParenthesesStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "include|omit|omit_when_condition_is_single_token", 
            description:             "Add/remove parentheses to/from condition in conditional operator");

        public static readonly ConfigOptionDescriptor ConditionalOperatorNewLine = new(
            key:                     ConfigOptionKeys.ConditionalOperatorNewLine, 
            defaultValue:            null, 
            defaultValuePlaceholder: "after|before", 
            description:             "Place new line after/before '?:' operator");

        public static readonly ConfigOptionDescriptor ConfigureAwait = new(
            key:                     ConfigOptionKeys.ConfigureAwait, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Add/remove 'ConfigureAwait(false)' call");

        public static readonly ConfigOptionDescriptor DocCommentSummaryStyle = new(
            key:                     ConfigOptionKeys.DocCommentSummaryStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "multi_line|single_line", 
            description:             "Format documentation comment summary on single line or multiple lines");

        public static readonly ConfigOptionDescriptor EmptyStringStyle = new(
            key:                     ConfigOptionKeys.EmptyStringStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "field|literal", 
            description:             "Prefer 'string.Empty' or empty string literal");

        public static readonly ConfigOptionDescriptor EnumHasFlagStyle = new(
            key:                     ConfigOptionKeys.EnumHasFlagStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "method|operator", 
            description:             "Use 'HasFlag' method or bitwise operator");

        public static readonly ConfigOptionDescriptor EqualsTokenNewLine = new(
            key:                     ConfigOptionKeys.EqualsTokenNewLine, 
            defaultValue:            null, 
            defaultValuePlaceholder: "after|before", 
            description:             "Place new line after/before equals sign");

        public static readonly ConfigOptionDescriptor InfiniteLoopStyle = new(
            key:                     ConfigOptionKeys.InfiniteLoopStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "for|while", 
            description:             "Use 'for'/'while' statement as an infinite loop");

        public static readonly ConfigOptionDescriptor MaxLineLength = new(
            key:                     ConfigOptionKeys.MaxLineLength, 
            defaultValue:            "140", 
            defaultValuePlaceholder: "<NUM>", 
            description:             "Max line length");

        public static readonly ConfigOptionDescriptor NewLineAtEndOfFile = new(
            key:                     ConfigOptionKeys.NewLineAtEndOfFile, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Include/omit new line at the end of a file");

        public static readonly ConfigOptionDescriptor NewLineBeforeWhileInDoStatement = new(
            key:                     ConfigOptionKeys.NewLineBeforeWhileInDoStatement, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Include/omit new line before 'while' in 'do' statement");

        public static readonly ConfigOptionDescriptor NullConditionalOperatorNewLine = new(
            key:                     ConfigOptionKeys.NullConditionalOperatorNewLine, 
            defaultValue:            null, 
            defaultValuePlaceholder: "after|before", 
            description:             "Place new line after/before null-conditional operator");

        public static readonly ConfigOptionDescriptor NullCheckStyle = new(
            key:                     ConfigOptionKeys.NullCheckStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "equality_operator|pattern_matching", 
            description:             "Use equality operator or pattern matchding as a null check");

        public static readonly ConfigOptionDescriptor ObjectCreationParenthesesStyle = new(
            key:                     ConfigOptionKeys.ObjectCreationParenthesesStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "include|omit", 
            description:             "Include/omit parentheses when creating new object");

        public static readonly ConfigOptionDescriptor ObjectCreationTypeStyle = new(
            key:                     ConfigOptionKeys.ObjectCreationTypeStyle, 
            defaultValue:            null, 
            defaultValuePlaceholder: "explicit|implicit|implicit_when_type_is_obvious", 
            description:             "Prefer explicit/implicit object creation");

        public static readonly ConfigOptionDescriptor PrefixFieldIdentifierWithUnderscore = new(
            key:                     ConfigOptionKeys.PrefixFieldIdentifierWithUnderscore, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Prefix field identifier with underscore");

        public static readonly ConfigOptionDescriptor SuppressUnityScriptMethods = new(
            key:                     ConfigOptionKeys.SuppressUnityScriptMethods, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Suppress Unity script methods");

        public static readonly ConfigOptionDescriptor UseAnonymousFunctionOrMethodGroup = new(
            key:                     ConfigOptionKeys.UseAnonymousFunctionOrMethodGroup, 
            defaultValue:            null, 
            defaultValuePlaceholder: "anonymous_function|method_group", 
            description:             "Use anonymous function or method group");

        public static readonly ConfigOptionDescriptor UseBlockBodyWhenDeclarationSpansOverMultipleLines = new(
            key:                     ConfigOptionKeys.UseBlockBodyWhenDeclarationSpansOverMultipleLines, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Use block body when declaration spans over multiple lines");

        public static readonly ConfigOptionDescriptor UseBlockBodyWhenExpressionSpansOverMultipleLines = new(
            key:                     ConfigOptionKeys.UseBlockBodyWhenExpressionSpansOverMultipleLines, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Use block body when expression spans over multiple lines");

        public static readonly ConfigOptionDescriptor UseVarInsteadOfImplicitObjectCreation = new(
            key:                     ConfigOptionKeys.UseVarInsteadOfImplicitObjectCreation, 
            defaultValue:            null, 
            defaultValuePlaceholder: "true|false", 
            description:             "Use 'var' instead of implicit object creation");

        private static IEnumerable<KeyValuePair<string, string>> GetRequiredOptions()
        {
            yield return new KeyValuePair<string, string>("RCS0011", JoinOptionKeys(ConfigOptionKeys.BlankLineBetweenSingleLineAccessors));
            yield return new KeyValuePair<string, string>("RCS0015", JoinOptionKeys(ConfigOptionKeys.BlankLineBetweenUsingDirectives));
            yield return new KeyValuePair<string, string>("RCS0027", JoinOptionKeys(ConfigOptionKeys.BinaryOperatorNewLine));
            yield return new KeyValuePair<string, string>("RCS0028", JoinOptionKeys(ConfigOptionKeys.ConditionalOperatorNewLine));
            yield return new KeyValuePair<string, string>("RCS0032", JoinOptionKeys(ConfigOptionKeys.ArrowTokenNewLine));
            yield return new KeyValuePair<string, string>("RCS0051", JoinOptionKeys(ConfigOptionKeys.NewLineBeforeWhileInDoStatement));
            yield return new KeyValuePair<string, string>("RCS0052", JoinOptionKeys(ConfigOptionKeys.EqualsTokenNewLine));
            yield return new KeyValuePair<string, string>("RCS0058", JoinOptionKeys(ConfigOptionKeys.NewLineAtEndOfFile));
            yield return new KeyValuePair<string, string>("RCS0059", JoinOptionKeys(ConfigOptionKeys.NullConditionalOperatorNewLine));
            yield return new KeyValuePair<string, string>("RCS1014", JoinOptionKeys(ConfigOptionKeys.ArrayCreationTypeStyle));
            yield return new KeyValuePair<string, string>("RCS1016", JoinOptionKeys(ConfigOptionKeys.BodyStyle, ConfigOptionKeys.UseBlockBodyWhenDeclarationSpansOverMultipleLines, ConfigOptionKeys.UseBlockBodyWhenExpressionSpansOverMultipleLines));
            yield return new KeyValuePair<string, string>("RCS1018", JoinOptionKeys(ConfigOptionKeys.AccessibilityModifiers));
            yield return new KeyValuePair<string, string>("RCS1050", JoinOptionKeys(ConfigOptionKeys.ObjectCreationParenthesesStyle));
            yield return new KeyValuePair<string, string>("RCS1051", JoinOptionKeys(ConfigOptionKeys.ConditionalOperatorConditionParenthesesStyle));
            yield return new KeyValuePair<string, string>("RCS1078", JoinOptionKeys(ConfigOptionKeys.EmptyStringStyle));
            yield return new KeyValuePair<string, string>("RCS1090", JoinOptionKeys(ConfigOptionKeys.ConfigureAwait));
            yield return new KeyValuePair<string, string>("RCS1096", JoinOptionKeys(ConfigOptionKeys.EnumHasFlagStyle));
            yield return new KeyValuePair<string, string>("RCS1207", JoinOptionKeys(ConfigOptionKeys.UseAnonymousFunctionOrMethodGroup));
            yield return new KeyValuePair<string, string>("RCS1248", JoinOptionKeys(ConfigOptionKeys.NullCheckStyle));
            yield return new KeyValuePair<string, string>("RCS1250", JoinOptionKeys(ConfigOptionKeys.ObjectCreationTypeStyle));
            yield return new KeyValuePair<string, string>("RCS1252", JoinOptionKeys(ConfigOptionKeys.InfiniteLoopStyle));
            yield return new KeyValuePair<string, string>("RCS1253", JoinOptionKeys(ConfigOptionKeys.DocCommentSummaryStyle));
        }
    }
}