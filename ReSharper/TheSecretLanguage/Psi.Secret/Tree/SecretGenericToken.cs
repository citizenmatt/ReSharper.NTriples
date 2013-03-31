﻿// ***********************************************************************
// <author>Stephan B</author>
// <copyright company="Comindware">
//   Copyright (c) Comindware 2010-2013. All rights reserved.
// </copyright>
// <summary>
//   SecretGenericToken.cs
// </summary>
// ***********************************************************************

using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;

namespace JetBrains.ReSharper.Psi.Secret.Tree
{
    public class SecretGenericToken : SecretTokenBase
    {
        private readonly TokenNodeType myNodeType;
        private readonly string myText;

        public SecretGenericToken(TokenNodeType nodeType, string text)
        {
            this.myNodeType = nodeType;
            this.myText = text;
        }

        public override PsiLanguageType Language
        {
            get
            {
                return SecretLanguage.Instance;
            }
        }

        public override NodeType NodeType
        {
            get
            {
                return this.myNodeType;
            }
        }

        public override string GetText()
        {
            return this.myText;
        }

        public override int GetTextLength()
        {
            return this.myText.Length;
        }
    }
}
