// Signature file for parser generated by fsyacc
module Parser
type token = 
  | SHARP_SHARED of (string)
  | SHARP_TABLE of (string)
  | SHARP_TIME of (string)
  | SHARP_DURATION of (string)
  | SHARP_INFINITY of (string)
  | SHARP_NAN of (string)
  | SHARP_SECTION of (string)
  | SHARP_BINARY of (string)
  | SHARP_DATE of (string)
  | SHARP_DATETIME of (string)
  | SHARP_DATETIMEZONE of (string)
  | NULL of (string)
  | OR of (string)
  | OTHERWISE of (string)
  | SECTION of (string)
  | SHARED of (string)
  | THEN of (string)
  | TRUE of (string)
  | TRY of (string)
  | TYPE of (string)
  | AND of (string)
  | EACH of (string)
  | ELSE of (string)
  | ERROR of (string)
  | AS of (string)
  | FALSE of (string)
  | IF of (string)
  | IN of (string)
  | IS of (string)
  | LET of (string)
  | META of (string)
  | NOT of (string)
  | CLOSING_PARANTHESIS_FOLLOWED_BY_FUNCTION_OPERATOR of (string)
  | FUNCTION_OPERATOR of (string)
  | DOTDOT of (string)
  | OPENING_PARENTHESIS of (string)
  | CLOSING_PARENTHESIS of (string)
  | OPENING_BRACE of (string)
  | CLOSING_BRACE of (string)
  | COMMA of (string)
  | FORWARD_PIPELINE_OPERATOR of (string)
  | ADDITIVE_OPERATOR of (string)
  | MULTIPLICATIVE_OPERATOR of (string)
  | EOF
  | LPAREN
  | RPAREN
  | IDENTIFIER_WITH_PRIME of (string)
  | IDENTIFIER of (string)
  | APPLICATION of (string)
  | WHITESPACE of (string)
  | OP of (string)
  | LITERAL of (string)
type tokenId = 
    | TOKEN_SHARP_SHARED
    | TOKEN_SHARP_TABLE
    | TOKEN_SHARP_TIME
    | TOKEN_SHARP_DURATION
    | TOKEN_SHARP_INFINITY
    | TOKEN_SHARP_NAN
    | TOKEN_SHARP_SECTION
    | TOKEN_SHARP_BINARY
    | TOKEN_SHARP_DATE
    | TOKEN_SHARP_DATETIME
    | TOKEN_SHARP_DATETIMEZONE
    | TOKEN_NULL
    | TOKEN_OR
    | TOKEN_OTHERWISE
    | TOKEN_SECTION
    | TOKEN_SHARED
    | TOKEN_THEN
    | TOKEN_TRUE
    | TOKEN_TRY
    | TOKEN_TYPE
    | TOKEN_AND
    | TOKEN_EACH
    | TOKEN_ELSE
    | TOKEN_ERROR
    | TOKEN_AS
    | TOKEN_FALSE
    | TOKEN_IF
    | TOKEN_IN
    | TOKEN_IS
    | TOKEN_LET
    | TOKEN_META
    | TOKEN_NOT
    | TOKEN_CLOSING_PARANTHESIS_FOLLOWED_BY_FUNCTION_OPERATOR
    | TOKEN_FUNCTION_OPERATOR
    | TOKEN_DOTDOT
    | TOKEN_OPENING_PARENTHESIS
    | TOKEN_CLOSING_PARENTHESIS
    | TOKEN_OPENING_BRACE
    | TOKEN_CLOSING_BRACE
    | TOKEN_COMMA
    | TOKEN_FORWARD_PIPELINE_OPERATOR
    | TOKEN_ADDITIVE_OPERATOR
    | TOKEN_MULTIPLICATIVE_OPERATOR
    | TOKEN_EOF
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_IDENTIFIER_WITH_PRIME
    | TOKEN_IDENTIFIER
    | TOKEN_APPLICATION
    | TOKEN_WHITESPACE
    | TOKEN_OP
    | TOKEN_LITERAL
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startparse
    | NONTERM_parse
    | NONTERM_expression
    | NONTERM_arithmetic_expression
    | NONTERM_additive_expression
    | NONTERM_multiplicative_expression
    | NONTERM_primary_expression
    | NONTERM_literal_expression
    | NONTERM_identifier_expression
    | NONTERM_invoke_expression
    | NONTERM_forward_pipeline_expression
    | NONTERM_parenthesized_expression
    | NONTERM_list_expression
    | NONTERM_item_list
    | NONTERM_item_list_opt
    | NONTERM_item
    | NONTERM_function_expression
    | NONTERM_function_body
    | NONTERM_parameter_list
    | NONTERM_parameter_list_opt
    | NONTERM_parameter
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val parse : (FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> FSharp.Text.Lexing.LexBuffer<'cty> -> (string) 
