﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Roslynator.Formatting.CSharp
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    internal sealed class RequiredConfigOptionNotSetAnalyzer : AbstractRequiredConfigOptionNotSetAnalyzer
    {
        private static ImmutableArray<DiagnosticDescriptor> _supportedDiagnostics;

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                if (_supportedDiagnostics.IsDefault)
                {
                    Immutable.InterlockedInitialize(
                        ref _supportedDiagnostics,
                        DiagnosticRules.AddOrRemoveNewLineBeforeWhileInDoStatement,
                        DiagnosticRules.BlankLineBetweenSingleLineAccessors,
                        DiagnosticRules.BlankLineBetweenUsingDirectiveGroups,
                        DiagnosticRules.PlaceNewLineAfterOrBeforeArrowToken,
                        DiagnosticRules.PlaceNewLineAfterOrBeforeBinaryOperator,
                        DiagnosticRules.PlaceNewLineAfterOrBeforeConditionalOperator,
                        DiagnosticRules.PlaceNewLineAfterOrBeforeEqualsToken,
                        CommonDiagnosticRules.RequiredConfigOptionNotSet);
                }

                return _supportedDiagnostics;
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

            context.RegisterCompilationStartAction(compilationContext =>
            {
                var flags = Flags.None;

                CompilationOptions compilationOptions = compilationContext.Compilation.Options;

                compilationContext.RegisterSyntaxTreeAction(context =>
                {
                    if (!CommonDiagnosticRules.RequiredConfigOptionNotSet.IsEffective(context.Tree, compilationOptions, context.CancellationToken))
                        return;

                    AnalyzerConfigOptions configOptions = context.GetConfigOptions();

                    Validate(ref context, compilationOptions, configOptions, Flags.AddOrRemoveNewLineBeforeWhileInDoStatement, ref flags, DiagnosticRules.AddOrRemoveNewLineBeforeWhileInDoStatement, ConfigOptions.NewLineBeforeWhileInDoStatement);
                    Validate(ref context, compilationOptions, configOptions, Flags.BlankLineBetweenSingleLineAccessors, ref flags, DiagnosticRules.BlankLineBetweenSingleLineAccessors, ConfigOptions.BlankLineBetweenSingleLineAccessors);
                    Validate(ref context, compilationOptions, configOptions, Flags.BlankLineBetweenUsingDirectiveGroups, ref flags, DiagnosticRules.BlankLineBetweenUsingDirectiveGroups, ConfigOptions.BlankLineBetweenUsingDirectiveGroups);
                    Validate(ref context, compilationOptions, configOptions, Flags.PlaceNewLineAfterOrBeforeArrowToken, ref flags, DiagnosticRules.PlaceNewLineAfterOrBeforeArrowToken, ConfigOptions.ArrowTokenNewLine);
                    Validate(ref context, compilationOptions, configOptions, Flags.PlaceNewLineAfterOrBeforeConditionalOperator, ref flags, DiagnosticRules.PlaceNewLineAfterOrBeforeConditionalOperator, ConfigOptions.ConditionalOperatorNewLine);
                    Validate(ref context, compilationOptions, configOptions, Flags.PlaceNewLineAfterOrBeforeBinaryOperator, ref flags, DiagnosticRules.PlaceNewLineAfterOrBeforeBinaryOperator, ConfigOptions.BinaryOperatorNewLine);
                    Validate(ref context, compilationOptions, configOptions, Flags.PlaceNewLineAfterOrBeforeEqualsToken, ref flags, DiagnosticRules.PlaceNewLineAfterOrBeforeEqualsToken, ConfigOptions.EqualsTokenNewLine);
                });
            });
        }

        private static void Validate(
            ref SyntaxTreeAnalysisContext context,
            CompilationOptions compilationOptions,
            AnalyzerConfigOptions configOptions,
            Flags flag,
            ref Flags flags,
            DiagnosticDescriptor analyzer,
            ConfigOptionDescriptor option)
        {
            if (!flags.HasFlag(flag)
                && analyzer.IsEffective(context.Tree, compilationOptions, context.CancellationToken)
                && TryReportRequiredOptionNotSet(context, configOptions, analyzer, option))
            {
                flags |= flag;
            }
        }

        [Flags]
        private enum Flags
        {
            None,
            AddOrRemoveNewLineBeforeWhileInDoStatement,
            BlankLineBetweenSingleLineAccessors,
            BlankLineBetweenUsingDirectiveGroups,
            PlaceNewLineAfterOrBeforeArrowToken,
            PlaceNewLineAfterOrBeforeBinaryOperator,
            PlaceNewLineAfterOrBeforeConditionalOperator,
            PlaceNewLineAfterOrBeforeEqualsToken,
        }
    }
}
