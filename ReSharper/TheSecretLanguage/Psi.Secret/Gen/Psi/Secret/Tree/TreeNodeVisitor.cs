//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
namespace JetBrains.ReSharper.Psi.Secret.Tree {
  public abstract partial class TreeNodeVisitor {
    public virtual void VisitNode ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.Tree.ITreeNode node)
    {
    }
    public virtual void VisitSecretFile ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.Secret.Tree.ISecretFile SecretFileParam) {
      VisitNode (SecretFileParam);
    }
    public virtual void VisitIdentifier ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.Secret.Tree.IIdentifier identifierParam) {
      VisitNode (identifierParam);
    }
    public virtual void VisitTriplet ([JetBrains.Annotations.NotNull] JetBrains.ReSharper.Psi.Secret.Tree.ITriplet tripletParam) {
      VisitNode (tripletParam);
    }
  }
}
