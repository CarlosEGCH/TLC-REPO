//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\Automata.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public partial class AutomataParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, LETTER=3, IDENTIFIER=4, NUMBER=5, WHITESPACES=6;
	public const int
		RULE_specification = 0, RULE_states = 1, RULE_state = 2;
	public static readonly string[] ruleNames = {
		"specification", "states", "state"
	};

	private static readonly string[] _LiteralNames = {
		null, "'automata'", "'state'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "LETTER", "IDENTIFIER", "NUMBER", "WHITESPACES"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Automata.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static AutomataParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public AutomataParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public AutomataParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class SpecificationContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER() { return GetToken(AutomataParser.IDENTIFIER, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public StatesContext states() {
			return GetRuleContext<StatesContext>(0);
		}
		public SpecificationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_specification; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterSpecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitSpecification(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSpecification(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SpecificationContext specification() {
		SpecificationContext _localctx = new SpecificationContext(Context, State);
		EnterRule(_localctx, 0, RULE_specification);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 6;
			Match(T__0);
			State = 7;
			Match(IDENTIFIER);
			State = 8;
			states();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StateContext state() {
			return GetRuleContext<StateContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatesContext states() {
			return GetRuleContext<StatesContext>(0);
		}
		public StatesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_states; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterStates(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitStates(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStates(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatesContext states() {
		StatesContext _localctx = new StatesContext(Context, State);
		EnterRule(_localctx, 2, RULE_states);
		try {
			State = 14;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 10;
				state();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 11;
				state();
				State = 12;
				states();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StateContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBER() { return GetToken(AutomataParser.NUMBER, 0); }
		public StateContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_state; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.EnterState(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAutomataListener typedListener = listener as IAutomataListener;
			if (typedListener != null) typedListener.ExitState(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IAutomataVisitor<TResult> typedVisitor = visitor as IAutomataVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitState(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StateContext state() {
		StateContext _localctx = new StateContext(Context, State);
		EnterRule(_localctx, 4, RULE_state);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16;
			Match(T__1);
			State = 17;
			Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,6,20,2,0,7,0,2,1,7,1,2,2,7,2,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,3,1,15,
		8,1,1,2,1,2,1,2,1,2,0,0,3,0,2,4,0,0,17,0,6,1,0,0,0,2,14,1,0,0,0,4,16,1,
		0,0,0,6,7,5,1,0,0,7,8,5,4,0,0,8,9,3,2,1,0,9,1,1,0,0,0,10,15,3,4,2,0,11,
		12,3,4,2,0,12,13,3,2,1,0,13,15,1,0,0,0,14,10,1,0,0,0,14,11,1,0,0,0,15,
		3,1,0,0,0,16,17,5,2,0,0,17,18,5,5,0,0,18,5,1,0,0,0,1,14
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
