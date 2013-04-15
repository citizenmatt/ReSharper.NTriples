//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
namespace JetBrains.ReSharper.Psi.Secret.Impl.Tree {
  public abstract class ElementType {
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ERROR_ELEMENT = JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ErrorElement.NODE_TYPE;
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType _SECRET_FILE = _SECRET_FILE_INTERNAL.INSTANCE;
    private class _SECRET_FILE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly _SECRET_FILE_INTERNAL INSTANCE = new _SECRET_FILE_INTERNAL ();
      _SECRET_FILE_INTERNAL() : base("_SECRET_FILE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new SecretFile();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ANONYMOUS_IDENTIFIER = ANONYMOUS_IDENTIFIER_INTERNAL.INSTANCE;
    private class ANONYMOUS_IDENTIFIER_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly ANONYMOUS_IDENTIFIER_INTERNAL INSTANCE = new ANONYMOUS_IDENTIFIER_INTERNAL ();
      ANONYMOUS_IDENTIFIER_INTERNAL() : base("ANONYMOUS_IDENTIFIER") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new AnonymousIdentifier();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType AXIS_DIRECTIVE = AXIS_DIRECTIVE_INTERNAL.INSTANCE;
    private class AXIS_DIRECTIVE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly AXIS_DIRECTIVE_INTERNAL INSTANCE = new AXIS_DIRECTIVE_INTERNAL ();
      AXIS_DIRECTIVE_INTERNAL() : base("AXIS_DIRECTIVE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new AxisDirective();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CUT_STATEMENT = CUT_STATEMENT_INTERNAL.INSTANCE;
    private class CUT_STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly CUT_STATEMENT_INTERNAL INSTANCE = new CUT_STATEMENT_INTERNAL ();
      CUT_STATEMENT_INTERNAL() : base("CUT_STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new CutStatement();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DATA_LITERAL = DATA_LITERAL_INTERNAL.INSTANCE;
    private class DATA_LITERAL_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly DATA_LITERAL_INTERNAL INSTANCE = new DATA_LITERAL_INTERNAL ();
      DATA_LITERAL_INTERNAL() : base("DATA_LITERAL") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new DataLiteral();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DIRECTIVE = DIRECTIVE_INTERNAL.INSTANCE;
    private class DIRECTIVE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly DIRECTIVE_INTERNAL INSTANCE = new DIRECTIVE_INTERNAL ();
      DIRECTIVE_INTERNAL() : base("DIRECTIVE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Directive();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType EXPRESSION = EXPRESSION_INTERNAL.INSTANCE;
    private class EXPRESSION_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly EXPRESSION_INTERNAL INSTANCE = new EXPRESSION_INTERNAL ();
      EXPRESSION_INTERNAL() : base("EXPRESSION") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Expression();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType EXTENSION_DIRECTIVE = EXTENSION_DIRECTIVE_INTERNAL.INSTANCE;
    private class EXTENSION_DIRECTIVE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly EXTENSION_DIRECTIVE_INTERNAL INSTANCE = new EXTENSION_DIRECTIVE_INTERNAL ();
      EXTENSION_DIRECTIVE_INTERNAL() : base("EXTENSION_DIRECTIVE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new ExtensionDirective();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FACT = FACT_INTERNAL.INSTANCE;
    private class FACT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FACT_INTERNAL INSTANCE = new FACT_INTERNAL ();
      FACT_INTERNAL() : base("FACT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Fact();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FACTS = FACTS_INTERNAL.INSTANCE;
    private class FACTS_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FACTS_INTERNAL INSTANCE = new FACTS_INTERNAL ();
      FACTS_INTERNAL() : base("FACTS") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Facts();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOR_ALL_DIRECTIVE = FOR_ALL_DIRECTIVE_INTERNAL.INSTANCE;
    private class FOR_ALL_DIRECTIVE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FOR_ALL_DIRECTIVE_INTERNAL INSTANCE = new FOR_ALL_DIRECTIVE_INTERNAL ();
      FOR_ALL_DIRECTIVE_INTERNAL() : base("FOR_ALL_DIRECTIVE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new ForAllDirective();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOR_SOME_DIRECTIVE = FOR_SOME_DIRECTIVE_INTERNAL.INSTANCE;
    private class FOR_SOME_DIRECTIVE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FOR_SOME_DIRECTIVE_INTERNAL INSTANCE = new FOR_SOME_DIRECTIVE_INTERNAL ();
      FOR_SOME_DIRECTIVE_INTERNAL() : base("FOR_SOME_DIRECTIVE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new ForSomeDirective();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FORMULA = FORMULA_INTERNAL.INSTANCE;
    private class FORMULA_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FORMULA_INTERNAL INSTANCE = new FORMULA_INTERNAL ();
      FORMULA_INTERNAL() : base("FORMULA") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Formula();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FROM_STATEMENT = FROM_STATEMENT_INTERNAL.INSTANCE;
    private class FROM_STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FROM_STATEMENT_INTERNAL INSTANCE = new FROM_STATEMENT_INTERNAL ();
      FROM_STATEMENT_INTERNAL() : base("FROM_STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new FromStatement();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FUNCTOR_STATEMENT = FUNCTOR_STATEMENT_INTERNAL.INSTANCE;
    private class FUNCTOR_STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FUNCTOR_STATEMENT_INTERNAL INSTANCE = new FUNCTOR_STATEMENT_INTERNAL ();
      FUNCTOR_STATEMENT_INTERNAL() : base("FUNCTOR_STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new FunctorStatement();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType HAS_EXPRESSION = HAS_EXPRESSION_INTERNAL.INSTANCE;
    private class HAS_EXPRESSION_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly HAS_EXPRESSION_INTERNAL INSTANCE = new HAS_EXPRESSION_INTERNAL ();
      HAS_EXPRESSION_INTERNAL() : base("HAS_EXPRESSION") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new HasExpression();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IDENTIFIER = IDENTIFIER_INTERNAL.INSTANCE;
    private class IDENTIFIER_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly IDENTIFIER_INTERNAL INSTANCE = new IDENTIFIER_INTERNAL ();
      IDENTIFIER_INTERNAL() : base("IDENTIFIER") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Identifier();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IF_STATEMENT = IF_STATEMENT_INTERNAL.INSTANCE;
    private class IF_STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly IF_STATEMENT_INTERNAL INSTANCE = new IF_STATEMENT_INTERNAL ();
      IF_STATEMENT_INTERNAL() : base("IF_STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new IfStatement();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IS_OF_EXPRESSION = IS_OF_EXPRESSION_INTERNAL.INSTANCE;
    private class IS_OF_EXPRESSION_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly IS_OF_EXPRESSION_INTERNAL INSTANCE = new IS_OF_EXPRESSION_INTERNAL ();
      IS_OF_EXPRESSION_INTERNAL() : base("IS_OF_EXPRESSION") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new IsOfExpression();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType KEYWORD_STATEMENT = KEYWORD_STATEMENT_INTERNAL.INSTANCE;
    private class KEYWORD_STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly KEYWORD_STATEMENT_INTERNAL INSTANCE = new KEYWORD_STATEMENT_INTERNAL ();
      KEYWORD_STATEMENT_INTERNAL() : base("KEYWORD_STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new KeywordStatement();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType LIST = LIST_INTERNAL.INSTANCE;
    private class LIST_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly LIST_INTERNAL INSTANCE = new LIST_INTERNAL ();
      LIST_INTERNAL() : base("LIST") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new List();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType META = META_INTERNAL.INSTANCE;
    private class META_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly META_INTERNAL INSTANCE = new META_INTERNAL ();
      META_INTERNAL() : base("META") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Meta();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType NAMESPACE_PREFIX = NAMESPACE_PREFIX_INTERNAL.INSTANCE;
    private class NAMESPACE_PREFIX_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly NAMESPACE_PREFIX_INTERNAL INSTANCE = new NAMESPACE_PREFIX_INTERNAL ();
      NAMESPACE_PREFIX_INTERNAL() : base("NAMESPACE_PREFIX") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new NamespacePrefix();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType NOT_STATEMENT = NOT_STATEMENT_INTERNAL.INSTANCE;
    private class NOT_STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly NOT_STATEMENT_INTERNAL INSTANCE = new NOT_STATEMENT_INTERNAL ();
      NOT_STATEMENT_INTERNAL() : base("NOT_STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new NotStatement();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECTS = OBJECTS_INTERNAL.INSTANCE;
    private class OBJECTS_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly OBJECTS_INTERNAL INSTANCE = new OBJECTS_INTERNAL ();
      OBJECTS_INTERNAL() : base("OBJECTS") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Objects();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OR_STATEMENT = OR_STATEMENT_INTERNAL.INSTANCE;
    private class OR_STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly OR_STATEMENT_INTERNAL INSTANCE = new OR_STATEMENT_INTERNAL ();
      OR_STATEMENT_INTERNAL() : base("OR_STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new OrStatement();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PREDICATE = PREDICATE_INTERNAL.INSTANCE;
    private class PREDICATE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly PREDICATE_INTERNAL INSTANCE = new PREDICATE_INTERNAL ();
      PREDICATE_INTERNAL() : base("PREDICATE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Predicate();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PREFIX_DIRECTIVE = PREFIX_DIRECTIVE_INTERNAL.INSTANCE;
    private class PREFIX_DIRECTIVE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly PREFIX_DIRECTIVE_INTERNAL INSTANCE = new PREFIX_DIRECTIVE_INTERNAL ();
      PREFIX_DIRECTIVE_INTERNAL() : base("PREFIX_DIRECTIVE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new PrefixDirective();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType SENTENCE = SENTENCE_INTERNAL.INSTANCE;
    private class SENTENCE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly SENTENCE_INTERNAL INSTANCE = new SENTENCE_INTERNAL ();
      SENTENCE_INTERNAL() : base("SENTENCE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Sentence();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType SENTENCES = SENTENCES_INTERNAL.INSTANCE;
    private class SENTENCES_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly SENTENCES_INTERNAL INSTANCE = new SENTENCES_INTERNAL ();
      SENTENCES_INTERNAL() : base("SENTENCES") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Sentences();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType SMART_VAR = SMART_VAR_INTERNAL.INSTANCE;
    private class SMART_VAR_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly SMART_VAR_INTERNAL INSTANCE = new SMART_VAR_INTERNAL ();
      SMART_VAR_INTERNAL() : base("SMART_VAR") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new SmartVar();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType STATEMENT = STATEMENT_INTERNAL.INSTANCE;
    private class STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly STATEMENT_INTERNAL INSTANCE = new STATEMENT_INTERNAL ();
      STATEMENT_INTERNAL() : base("STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Statement();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType SUBJECT = SUBJECT_INTERNAL.INSTANCE;
    private class SUBJECT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly SUBJECT_INTERNAL INSTANCE = new SUBJECT_INTERNAL ();
      SUBJECT_INTERNAL() : base("SUBJECT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Subject();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType URI_IDENTIFIER = URI_IDENTIFIER_INTERNAL.INSTANCE;
    private class URI_IDENTIFIER_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly URI_IDENTIFIER_INTERNAL INSTANCE = new URI_IDENTIFIER_INTERNAL ();
      URI_IDENTIFIER_INTERNAL() : base("URI_IDENTIFIER") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new UriIdentifier();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType URI_IDENTIFIERS = URI_IDENTIFIERS_INTERNAL.INSTANCE;
    private class URI_IDENTIFIERS_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly URI_IDENTIFIERS_INTERNAL INSTANCE = new URI_IDENTIFIERS_INTERNAL ();
      URI_IDENTIFIERS_INTERNAL() : base("URI_IDENTIFIERS") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new UriIdentifiers();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType USE_EXTERNAL_DIRECTIVE = USE_EXTERNAL_DIRECTIVE_INTERNAL.INSTANCE;
    private class USE_EXTERNAL_DIRECTIVE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly USE_EXTERNAL_DIRECTIVE_INTERNAL INSTANCE = new USE_EXTERNAL_DIRECTIVE_INTERNAL ();
      USE_EXTERNAL_DIRECTIVE_INTERNAL() : base("USE_EXTERNAL_DIRECTIVE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new UseExternalDirective();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType VARIABLE_IDENTIFIER = VARIABLE_IDENTIFIER_INTERNAL.INSTANCE;
    private class VARIABLE_IDENTIFIER_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly VARIABLE_IDENTIFIER_INTERNAL INSTANCE = new VARIABLE_IDENTIFIER_INTERNAL ();
      VARIABLE_IDENTIFIER_INTERNAL() : base("VARIABLE_IDENTIFIER") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new VariableIdentifier();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType VARIABLES = VARIABLES_INTERNAL.INSTANCE;
    private class VARIABLES_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly VARIABLES_INTERNAL INSTANCE = new VARIABLES_INTERNAL ();
      VARIABLES_INTERNAL() : base("VARIABLES") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Variables();
      }
    }
  }
}
