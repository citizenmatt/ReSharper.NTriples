﻿// ***********************************************************************
// <author>Stephan B</author>
// <copyright company="Comindware">
//   Copyright (c) Comindware 2010-2013. All rights reserved.
// </copyright>
// <summary>
//   SecretSearcherFactory.cs
// </summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI;
using JetBrains.ReSharper.Psi.Search;
using JetBrains.ReSharper.Psi.Secret.Impl.Tree;
using JetBrains.Util;
using JetBrains.Util.DataStructures;

namespace JetBrains.ReSharper.Psi.Secret.Feature.Services.FindUsages
{
    [PsiSharedComponent]
    internal class SecretSearcherFactory : IDomainSpecificSearcherFactory
    {
        private readonly SearchDomainFactory mySearchDomainFactory;

        public SecretSearcherFactory(SearchDomainFactory searchDomainFactory)
        {
            this.mySearchDomainFactory = searchDomainFactory;
        }

        public IDomainSpecificSearcher CreateAnonymousTypeSearcher(
            IList<AnonymousTypeDescriptor> typeDescription, bool caseSensitive)
        {
            return null;
        }

        public IDomainSpecificSearcher CreateConstantExpressionSearcher(ConstantValue constantValue, bool onlyLiteralExpression)
        {
            return new ConstantExpressionDomainSpecificSearcher<SecretLanguage>(constantValue, onlyLiteralExpression);
        }

        public IDomainSpecificSearcher CreateConstructorSpecialReferenceSearcher(ICollection<IConstructor> constructors)
        {
            return null;
        }

        public IDomainSpecificSearcher CreateLateBoundReferenceSearcher(ICollection<IDeclaredElement> elements)
        {
            return new SecretReferenceSearcher(this, elements, true);
        }

        public IDomainSpecificSearcher CreateMethodsReferencedByDelegateSearcher(IDelegate @delegate)
        {
            return null;
        }

        public IDomainSpecificSearcher CreateReferenceSearcher(ICollection<IDeclaredElement> elements, bool findCandidates)
        {
            return new SecretReferenceSearcher(this, elements, false);
        }

        public IDomainSpecificSearcher CreateTextOccurenceSearcher(ICollection<IDeclaredElement> elements)
        {
            return null;
        }

        public IDomainSpecificSearcher CreateTextOccurenceSearcher(string subject)
        {
            return null;
        }

        public IEnumerable<string> GetAllPossibleWordsInFile(IDeclaredElement element)
        {
            var names = new JetHashSet<string>
                {
                    element.ShortName
                };

            return names;
        }

        public ISearchDomain GetDeclaredElementSearchDomain(IDeclaredElement declaredElement)
        {
            HybridCollection<IPsiSourceFile> files = declaredElement.GetSourceFiles();
            if (!(declaredElement is PrefixDeclaration))
            {
                if (files.Count > 0)
                {
                    return this.mySearchDomainFactory.CreateSearchDomain(files[0]);
                }
            }
            return this.mySearchDomainFactory.CreateSearchDomain(declaredElement.GetSolution(), false);
        }

        public JetTuple<ICollection<IDeclaredElement>, Predicate<IFindResultReference>, bool> GetDerivedFindRequest(
            IFindResultReference result)
        {
            //todo
            return null;
        }

        public JetTuple<ICollection<IDeclaredElement>, bool> GetNavigateToTargets(IDeclaredElement element)
        {
            return null;
        }

        public IEnumerable<Pair<IDeclaredElement, Predicate<FindResult>>> GetRelatedDeclaredElements(IDeclaredElement element)
        {
            //todo
            yield return new Pair<IDeclaredElement, Predicate<FindResult>>(element, JetPredicate<FindResult>.True);
        }

        public bool IsCompatibleWithLanguage(PsiLanguageType languageType)
        {
            return languageType.Is<SecretLanguage>();
        }

        public ICollection<FindResult> TransformNavigationTargets(ICollection<FindResult> targets)
        {
            return targets;
        }
    }
}