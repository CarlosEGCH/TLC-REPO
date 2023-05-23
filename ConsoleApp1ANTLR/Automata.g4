grammar Automata;

// Syntax Rules

specification : 'automata' IDENTIFIER states
              ;

states        : state
              | state states
              ;

state         : 'state' NUMBER
              ;
              
// Lexer Rules

fragment DIGIT       : [0-9]
                     ;

LETTER      : [a-zA-Z]
            ;

IDENTIFIER : LETTER (LETTER|DIGIT)*
           ;

NUMBER      : DIGIT+
            ;

WHITESPACES : [\t\r\n]+ -> skip
            ;