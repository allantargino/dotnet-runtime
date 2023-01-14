// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Extensions.Logging.Generators.Tests.TestClasses
{
    internal static partial class TemplateTestExtensions
    {
#pragma warning disable SYSLIB1026
        [LoggerMessage(EventId = 3, Level = LogLevel.Error, Message = "M3 {a2} {A1}")]
        public static partial void M3(ILogger logger, int a1, int a2);
#pragma warning restore SYSLIB1026
    }
}
