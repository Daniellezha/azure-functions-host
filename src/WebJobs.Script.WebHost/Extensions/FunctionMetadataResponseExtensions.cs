// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Script.WebHost.Management;
using WebJobs.Script.Management.Models;

namespace Microsoft.Azure.WebJobs.Script.WebHost.Extensions
{
    public static class FunctionMetadataResponseExtensions
    {
        public static string GetFunctionPath(this FunctionMetadataResponse function, ScriptHostConfiguration config)
            => VirtualFileSystemBase.VfsUriToFilePath(function.ScriptRootPathHref, config);

        public static string GetFunctionTestDataFilePath(this FunctionMetadataResponse function, ScriptHostConfiguration config)
            => VirtualFileSystemBase.VfsUriToFilePath(function.TestDataHref, config);
    }
}