﻿// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   IUriIdentifier.cs
// </summary>
// ***********************************************************************

using JetBrains.ReSharper.Psi.Secret.Cache;
using JetBrains.ReSharper.Psi.Secret.Resolve;

namespace JetBrains.ReSharper.Psi.Secret.Tree
{
    /*public partial interface IUriIdentifier : IDeclaration//, IChameleonNode
    {
        void SetReferenceName(string shortName);
        string GetFullName(ISecretFile file);
    }*/

    public partial interface IUriIdentifier
    {
        IUriIdentifierDeclaredElement DescendantDeclaredElement { get; }
        UriIdentifierKind GetKind();
        string GetLocalName();
        string GetNamespace();
        string GetUri();
    }
}
