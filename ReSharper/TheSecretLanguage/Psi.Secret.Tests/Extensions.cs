﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   Extensions.cs
// </summary>
// ***********************************************************************

using System.IO;
using System.Linq;
using JetBrains.Application.Test;

namespace JetBrains.ReSharper.Psi.Secret.Tests
{
    public static class Extensions
    {
        public static string[] GetFilesToTest(this BaseTestNoShell testClass)
        {
            return testClass.TestDataPath2.GetDirectoryEntries("*" + SecretProjectFileType.SecretExtension, true)
                            .Select(f => Path.GetFileNameWithoutExtension(f.FullPath))
                            .ToArray();
        }
    }
}
