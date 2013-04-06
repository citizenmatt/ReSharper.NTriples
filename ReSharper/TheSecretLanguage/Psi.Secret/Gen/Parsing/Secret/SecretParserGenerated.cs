//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI;
using JetBrains.ReSharper.Psi.Secret.Tree.Impl;
namespace JetBrains.ReSharper.Psi.Secret.Parsing {
  internal abstract class SecretParserGenerated : JetBrains.ReSharper.Psi.Parsing.GeneratedParserBase<JetBrains.ReSharper.Psi.Parsing.ILexer<int>> 
  {
    public SecretParserGenerated() {}
    protected ParsingContext myCurrentContext = ParsingContext.UNDEFINED;
    protected enum ParsingContext : short {
      UNDEFINED
    }
    protected class ParsingContextAttribute : System.Attribute {
      private ParsingContext myParsingContext;
      public ParsingContextAttribute (ParsingContext context) {
        myParsingContext = context;
      }
      public ParsingContext ParsingContext {
        get {
          return myParsingContext;
        }
      }
    }
    protected bool IsInFollow (JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) {
      switch (myCurrentContext) {
        case ParsingContext.UNDEFINED: return false;
        default:
        throw new System.InvalidOperationException("Unknown context");
        return false;
      }
    }
    protected virtual TreeElement match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) {
      if (myLexer.TokenType != tokenType) {
        var tokenRepr = tokenType.TokenRepresentation;
        if (string.IsNullOrEmpty(tokenRepr))
        throw new JetBrains.ReSharper.Psi.Parsing.UnexpectedToken (JetBrains.ReSharper.Psi.Secret.Parsing.ParserMessages.GetExpectedMessage(tokenType.ToString()));
        throw new JetBrains.ReSharper.Psi.Parsing.UnexpectedToken (JetBrains.ReSharper.Psi.Secret.Parsing.ParserMessages.GetExpectedMessage(tokenRepr));
      }
      return createToken();
    }
    protected void skip(CompositeElement parent) {
      parent.AppendNewChild (createToken());
    }
    public virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement parseSecretFile () {
      JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType;
      CompositeElement result = null;
      TreeElement tempParsingResult = null; 
      try {
        result = TreeElementFactory.CreateCompositeElement (JetBrains.ReSharper.Psi.Secret.Tree.Impl.ElementType._SECRET_FILE);
        tokenType = myLexer.TokenType;
        while(tokenType == JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.IDENTIFIER
          ||tokenType == JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.L_BRACKET
          ||tokenType == JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.URI_BEGIN) {
          tempParsingResult = parseTriplet();
          result.AppendNewChild (tempParsingResult);
          tokenType = myLexer.TokenType;
        }
        tokenType = myLexer.TokenType;
        if (tokenType != null ) {
          throw new JetBrains.ReSharper.Psi.Parsing.FollowsFailure (ErrorMessages.GetErrorMessage0());
        }
      } catch (JetBrains.ReSharper.Psi.Parsing.SyntaxError e) {
        if (e.ParsingResult != null && result != null) {
          result.AppendNewChild (e.ParsingResult);
        }
        if (result != null) {
          e.ParsingResult = result;
        }
        if (result != null) {
          handleErrorInSecretFile (result, e);
        } else {
          throw;
        }
      }
      return result;
    }
    protected virtual CompositeElement handleErrorInSecretFile (CompositeElement result, JetBrains.ReSharper.Psi.Parsing.SyntaxError error) {
      JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType;
      CompositeElement errorElement;
      if (result is JetBrains.ReSharper.Psi.Tree.IErrorElement) {
        errorElement = result;
      }
      else {
        errorElement = TreeElementFactory.CreateErrorElement(error.Message);
        result.AppendNewChild(errorElement);
      }
      tokenType = myLexer.TokenType;
      while(tokenType != null ) {
        skip(errorElement);
        tokenType = myLexer.TokenType;
      }
      return result;
    }
    public virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement parseIdentifier () {
      JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType;
      CompositeElement result = null;
      TreeElement tempParsingResult = null; 
      try {
        result = TreeElementFactory.CreateCompositeElement (JetBrains.ReSharper.Psi.Secret.Tree.Impl.ElementType.IDENTIFIER);
        tokenType = myLexer.TokenType;
        if (tokenType == JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.IDENTIFIER) {
          tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.IDENTIFIER);
          result.AppendNewChild (tempParsingResult);
          tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.NAMESPACE_SEPARATOR);
          result.AppendNewChild (tempParsingResult);
          tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.IDENTIFIER);
          result.AppendNewChild (tempParsingResult);
        } else if (tokenType == JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.URI_BEGIN) {
          tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.URI_BEGIN);
          result.AppendNewChild (tempParsingResult);
          tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.URI_STRING);
          result.AppendNewChild (tempParsingResult);
          tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.URI_END);
          result.AppendNewChild (tempParsingResult);
        } else if (tokenType == JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.L_BRACKET) {
          tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.L_BRACKET);
          result.AppendNewChild (tempParsingResult);
          tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.R_BRACKET);
          result.AppendNewChild (tempParsingResult);
        } else {
          if (result.firstChild == null) result = null;
          throw new JetBrains.ReSharper.Psi.Parsing.UnexpectedToken (ErrorMessages.GetErrorMessage1());
        }
      } catch (JetBrains.ReSharper.Psi.Parsing.SyntaxError e) {
        if (e.ParsingResult != null && result != null) {
          result.AppendNewChild (e.ParsingResult);
        }
        if (result != null) {
          e.ParsingResult = result;
        }
        throw;
      }
      return result;
    }
    public virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement parseTriplet () {
      JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType;
      CompositeElement result = null;
      TreeElement tempParsingResult = null; 
      try {
        result = TreeElementFactory.CreateCompositeElement (JetBrains.ReSharper.Psi.Secret.Tree.Impl.ElementType.TRIPLET);
        tempParsingResult = parseIdentifier();
        result.AppendNewChild (tempParsingResult);
        tempParsingResult = parseIdentifier();
        result.AppendNewChild (tempParsingResult);
        tempParsingResult = parseIdentifier();
        result.AppendNewChild (tempParsingResult);
        tempParsingResult = match(JetBrains.ReSharper.Psi.Secret.Tree.Impl.TokenType.DOT);
        result.AppendNewChild (tempParsingResult);
      } catch (JetBrains.ReSharper.Psi.Parsing.SyntaxError e) {
        if (e.ParsingResult != null && result != null) {
          result.AppendNewChild (e.ParsingResult);
        }
        if (result != null) {
          e.ParsingResult = result;
        }
        throw;
      }
      return result;
    }
  }
}
