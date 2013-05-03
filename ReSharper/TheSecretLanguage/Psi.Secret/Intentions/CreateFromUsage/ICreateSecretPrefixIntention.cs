// ***********************************************************************
// <author>Stephan Burguchev</author>
// <copyright company="Stephan Burguchev">
//   Copyright (c) Stephan Burguchev 2012-2013. All rights reserved.
// </copyright>
// <summary>
//   ICreateSecretPrefixIntention.cs
// </summary>
// ***********************************************************************

namespace JetBrains.ReSharper.Psi.Secret.Intentions.CreateFromUsage
{
    public interface ICreateSecretPrefixIntention
    {
        SecretIntentionResult ExecuteEx(CreateSecretPrefixContext context);
    }
}
