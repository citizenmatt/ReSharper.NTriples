﻿using System.Collections.Generic;
using System.Linq;
using System.Xml;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util;
using ReSharper.NTriples.Cache;
using ReSharper.NTriples.Resolve;
using ReSharper.NTriples.Tree;
using ReSharper.NTriples.Util;

namespace ReSharper.NTriples.Impl.Tree
{
    internal partial class LocalName : IUriIdentifierDeclaredElement
    {
        #region IDeclaredElement Members

        public IList<IDeclaration> GetDeclarations()
        {
            if (this.ScopeToMainFile)
            {
                return UriIdentifierDeclaredElement.GetDeclarationsIn(this.GetSourceFile(), this);
            }

            return UriIdentifierDeclaredElement.GetDeclarations(this);
        }

        public IList<IDeclaration> GetDeclarationsIn(IPsiSourceFile sourceFile)
        {
            if (this.filesScope.Contains(sourceFile) && this.GetSourceFile() != sourceFile)
            {
                return EmptyList<IDeclaration>.InstanceList;
            }

            return UriIdentifierDeclaredElement.GetDeclarationsIn(sourceFile, this);
        }

        private readonly IList<IPsiSourceFile> filesScope = new List<IPsiSourceFile>();

        public bool ScopeToMainFile { get; set; }

        public string GetNamespace()
        {
            var uriIdentifier = Parent as UriIdentifier;
            if (uriIdentifier == null)
            {
                return null;
            }

            var prefixElement = uriIdentifier.Prefix;
            if (prefixElement == null)
            {
                return uriIdentifier.GetUri();
            }

            var prefix = prefixElement.PrefixReference.GetName();
            var secretFile = (SecretFile)this.GetContainingFile();
            if (secretFile == null)
            {
                return prefix;
            }

            var declaration = secretFile.GetPrefixDeclaredElements(prefix).FirstOrDefault() as IPrefixDeclaration;
            if (declaration != null && declaration.UriString != null)
            {
                return declaration.UriString.GetText();
            }

            return prefix;
        }

        public string GetLocalName()
        {
            return this.GetText();
        }

        public string GetUri()
        {
            var ns = this.GetNamespace();
            if (ns == null)
            {
                return null;
            }

            return ns + this.GetText();
        }

        public DeclaredElementType GetElementType()
        {
            return SecretDeclaredElementType.UriIdentifier;
        }

        public XmlNode GetXMLDoc(bool inherit)
        {
            return null;
        }

        public XmlNode GetXMLDescriptionSummary(bool inherit)
        {
            return null;
        }

        public bool IsSynthetic()
        {
            return false;
        }

        public string ShortName
        {
            get
            {
                return this.GetText();
            }
        }

        public bool CaseSensistiveName
        {
            get { return true; }
        }

        public PsiLanguageType PresentationLanguage
        {
            get { return SecretLanguage.Instance; }
        }

        public IdentifierKind GetKind()
        {
            var uriIdentifier = Parent as UriIdentifier;
            if (uriIdentifier == null)
            {
                return IdentifierKind.Other;
            }

            return uriIdentifier.GetKind();
        }

        #endregion

        #region IRuleDeclaration Members

        public void SetName(string name)
        {
            PsiTreeUtil.ReplaceChild(this, this.FirstChild, name);
        }

        public TreeTextRange GetNameRange()
        {
            return this.GetTreeTextRange();
        }

        public IDeclaredElement DeclaredElement
        {
            get
            {
                return this;
            }
        }

        public string DeclaredName
        {
            get { return this.GetDeclaredName(); }
        }

        /*public IChameleonNode ReSync(CachingLexer cachingLexer, TreeTextRange changedRange, int insertedTextLen)
        {
            TreeOffset currStartOffset = GetTreeStartOffset();
            int currLength = GetTextLength();

            Logger.Assert(changedRange.StartOffset >= currStartOffset && changedRange.EndOffset <= (currStartOffset + currLength),
              "changedRange.StartOffset >= currStartOffset && changedRange.EndOffset <= (currStartOffset+currLength)");

            int newLength = currLength - changedRange.Length + insertedTextLen;

            LanguageService languageService = Language.LanguageService();
            if (languageService != null)
            {
                var parser =
                    (ISecretParser)
                    languageService.CreateParser(
                        new ProjectedLexer(cachingLexer, new TextRange(currStartOffset.Offset, currStartOffset.Offset + newLength)),
                        GetPsiModule(),
                        GetSourceFile());
                throw new NotImplementedException();
                /*TreeElement newElement = parser.ParseStatement();
                if (newElement.GetTextLength() == 0)
                {
                    return null;
                }
                if ((newElement.GetTextLength() == newLength) && (";".Equals(newElement.GetText().Substring(newElement.GetTextLength() - 1))))
                {
                    var psiFile = GetContainingNode<SecretFile>();
                    if (psiFile != null)
                    {
                        psiFile.ClearTables();
                    }
                    return newElement as IRuleDeclaration;
                }#2#
            }

            return null;
        }*/

        #endregion

        public bool IsOpened
        {
            get { return false; }
        }

        private string GetDeclaredName()
        {
            return this.GetText();
        }

        private SecretLocalNameReference myLocalNameReference;

        public SecretLocalNameReference LocalNameReference
        {
            get
            {
                lock (this)
                {
                    return this.myLocalNameReference ?? (this.myLocalNameReference = new SecretLocalNameReference(this));
                }
            }
        }

        public override ReferenceCollection GetFirstClassReferences()
        {
            return new ReferenceCollection(this.LocalNameReference);
        }

        public void SetReferenceName(string shortName)
        {
            this.LocalNameReference.SetName(shortName);
        }
    }
}