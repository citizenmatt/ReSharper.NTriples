﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   SecretContextActionDataProvider.cs
// </summary>
// ***********************************************************************

using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Bulbs;
using JetBrains.ReSharper.Psi.Secret.Tree;
using JetBrains.TextControl;

namespace JetBrains.ReSharper.Psi.Secret.Feature.Services.MatchingBrace
{
    public class SecretContextActionDataProvider
        : CachedContextActionDataProviderBase<ISecretFile>, ISecretContextActionDataProvider
    {
        public SecretContextActionDataProvider(ISolution solution, ITextControl textControl, ISecretFile file)
            : base(solution, textControl, file)
        {
        }
    }
}
