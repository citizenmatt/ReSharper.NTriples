// ***********************************************************************
// <author>Stephan B</author>
// <copyright company="Comindware">
//   Copyright (c) Comindware 2010-2013. All rights reserved.
// </copyright>
// <summary>
//   NewLine.cs
// </summary>
// ***********************************************************************

using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Secret.Parsing;

namespace JetBrains.ReSharper.Psi.Secret.Tree
{
    internal class NewLine : WhitespaceBase
    {
        public NewLine(string text)
            : base(text)
        {
        }

        public override bool IsNewLine
        {
            get
            {
                return true;
            }
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
                return SecretTokenType.NEW_LINE;
            }
        }
    }
}
