# Lexical grammar
## lexical-unit:
      lexical-elementsopt
## lexical-elements:
      lexical-element lexical-elementsopt
## lexical-element:
      whitespace
      token comment

White space
whitespace:
      Any character with Unicode class Zs
      Horizontal tab character (U+0009)
      Vertical tab character (U+000B)
      Form feed character (U+000C)
      Carriage return character (U+000D) followed by line feed character (U+000A)       new-line-character
new-line-character:
      Carriage return character (U+000D)
      Line feed character (U+000A)
      Next line character (U+0085)
      Line separator character (U+2028)
      Paragraph separator character (U+2029)

Comment
comment:
      single-line-comment
      delimited-comment
single-line-comment:
      // single-line-comment-charactersopt
single-line-comment-characters:
      single-line-comment-character single-line-comment-charactersopt
single-line-comment-character:
      Any Unicode character except a new-line-character
delimited-comment:
      /* delimited-comment-textopt asterisks /
delimited-comment-text:
      delimited-comment-section delimited-comment-textopt
delimited-comment-section:
      /
      asterisksopt not-slash-or-asterisk
asterisks:
      * asterisksopt
not-slash-or-asterisk:
      Any Unicode character except * or /

Tokens
token:
      identifier
      keyword
      literal
      operator-or-punctuator

Character escape sequences
character-escape-sequence:
      #( escape-sequence-list )
escape-sequence-list:
      single-escape-sequence
      escape-sequence-list , single-escape-sequence
single-escape-sequence:
      long-unicode-escape-sequence
      short-unicode-escape-sequence
      control-character-escape-sequence
      escape-escape
long-unicode-escape-sequence:
      hex-digit hex-digit hex-digit hex-digit hex-digit hex-digit hex-digit hex-digit
short-unicode-escape-sequence:
      hex-digit hex-digit hex-digit hex-digit
control-character-escape-sequence:
      control-character
control-character:
      cr
      lf
      tab
escape-escape:
      #

Literals
literal:
      logical-literal
      number-literal
      text-literal
      null-literal
      verbatim-literal
logical-literal:
      true
      false
number-literal:
      decimal-number-literal
      hexadecimal-number-literal
decimal-digits:
      decimal-digit decimal-digitsopt
decimal-digit: one of
      0 1 2 3 4 5 6 7 8 9
hexadecimal-number-literal:
      0x hex-digits
      0X hex-digits
hex-digits:
      hex-digit hex-digitsopt
hex-digit: one of
      0 1 2 3 4 5 6 7 8 9 A B C D E F a b c d e f
decimal-number-literal:
      decimal-digits . decimal-digits exponent-partopt
      . decimal-digits exponent-partopt
      decimal-digits exponent-partopt
exponent-part:
      e signopt decimal-digits
      E signopt decimal-digits
sign: one of
      + -
text-literal:
      " text-literal-charactersopt "
text-literal-characters:
      text-literal-character text-literal-charactersopt
text-literal-character:
      single-text-character
      character-escape-sequence
      double-quote-escape-sequence
single-text-character:
      Any character except " (U+0022) or # (U+0023) followed by ( (U+0028)
double-quote-escape-sequence:
      "" (U+0022, U+0022)
null-literal:
      null
verbatim-literal:
      #!" text-literal-charactersopt "

Identifiers
identifier:
      regular-identifier
      quoted-identifier
regular-identifier:
      available-identifier
      available-identifier dot-character regular-identifier
available-identifier:
      A keyword-or-identifier that is not a keyword
keyword-or-identifier:
      letter-character
      underscore-character
      identifier-start-character identifier-part-characters
identifier-start-character:
      letter-character
      underscore-character
identifier-part-characters:
      identifier-part-character identifier-part-charactersopt
identifier-part-character:
      letter-character
      decimal-digit-character
      underscore-character
      connecting-character
      combining-character
      formatting-character
generalized-identifier:
      generalized-identifier-part
      generalized-identifier separated only by blanks (U+0020) generalized-identifier-part
generalized-identifier-part:
      generalized-identifier-segment
      decimal-digit-character generalized-identifier-segment
generalized-identifier-segment:
      keyword-or-identifier
      keyword-or-identifier dot-character keyword-or-identifier
dot-character:
      . (U+002E)
underscore-character:
      _ (U+005F)
letter-character:_
      A Unicode character of classes Lu, Ll, Lt, Lm, Lo, or Nl
combining-character:
      A Unicode character of classes Mn or Mc
decimal-digit-character:
      A Unicode character of the class Nd
connecting-character:
      A Unicode character of the class Pc
formatting-character:
      A Unicode character of the class Cf
quoted-identifier:
      #" text-literal-charactersopt "

Keywords and predefined identifiers
Predefined identifiers and keywords cannot be redefined. A quoted identifier can be used to handle identifiers that would otherwise collide with predefined identifiers or keywords.

keyword: one of
      and as each else error false if in is let meta not null or otherwise
      section shared then true try type #binary #date #datetime
      #datetimezone #duration #infinity #nan #sections #shared #table #time

Operators and punctuators
operator-or-punctuator: one of
      , ; = < <= > >= <> + - * / & ( ) [ ] { } @ ? ?? => .. ...

Syntactic grammar
Documents
document:
      section-document
      expression-document

Section Documents
section-document:
      section
section:
      literal-attributesopt section section-name ; section-membersopt
section-name:
      identifier
section-members:
      section-member section-membersopt
section-member:
      literal-attributesopt sharedopt section-member-name = expression ;
section-member-name:
      identifier

Expression Documents
Expressions
expression-document:
      expression
expression:
      logical-or-expression
      each-expression
      function-expression
      let-expression
      if-expression
      error-raising-expression
      error-handling-expression

Logical expressions
logical-or-expression:
      logical-and-expression
      logical-and-expression or logical-or-expression
logical-and-expression:
      is-expression
      logical-and-expression and is-expression

Is expression
is-expression:
      as-expression
      is-expression is nullable-primitive-type
nullable-primitive-type:
      nullableopt primitive-type

As expression
as-expression:
      equality-expression
      as-expression as nullable-primitive-type

Equality expression
equality-expression:
      relational-expression
      relational-expression = equality-expression
      relational-expression <> equality-expression

Relational expression
relational-expression:
      additive-expression
      additive-expression < relational-expression
      additive-expression > relational-expression
      additive-expression <= relational-expression
      additive-expression >= relational-expression

Arithmetic expressions
additive-expression:
      multiplicative-expression
      multiplicative-expression + additive-expression
      multiplicative-expression - additive-expression
      multiplicative-expression & _additive-expression
multiplicative-expression:
      metadata-expression
      metadata-expression * multiplicative-expression
      metadata-expression / multiplicative-expression

Metadata expression
metadata-expression:
      unary-expression
      unary-expression meta unary-expression

Unary expression
unary-expression:
      type-expression
      + unary-expression
      - unary-expression
      not unary-expression

Primary expression
primary-expression:
      literal-expression
      list-expression
      record-expression
      identifier-expression
      section-access-expression
      parenthesized-expression
      field-access-expression
      item-access-expression
      invoke-expression
      not-implemented-expression

Literal expression
literal-expression:
      literal

Identifier expression
identifier-expression:
      identifier-reference
identifier-reference:
      exclusive-identifier-reference
      inclusive-identifier-reference
exclusive-identifier-reference:
      identifier
inclusive-identifier-reference:
      @ identifier

Section-access expression
section-access-expression:
      identifier ! identifier

Parenthesized expression
parenthesized-expression:
      ( expression )

Not-implemented expression
not-implemented-expression:
      ...

Invoke expression
invoke-expression:
      primary-expression ( argument-listopt )
argument-list:
      expression
      expression , argument-list

List expression
list-expression:
      { item-listopt }
item-list:
      item
      item , item-list
item:
      expression
      expression .. expression

Record expression
record-expression:
      [ field-listopt ]
field-list:
      field
      field , field-list
field:
      field-name = expression
field-name:
      generalized-identifier
      quoted-identifier

Item access expression
item-access-expression:
      item-selection
      optional-item-selection
item-selection:
      primary-expression { item-selector }
optional-item-selection:
      primary-expression { item-selector } ?
item-selector:
      expression

Field access expressions
field-access-expression:
      field-selection
      implicit-target-field-selection
      projection
      implicit-target-projection
field-selection:
      primary-expression field-selector
field-selector:
      required-field-selector
      optional-field-selector
required-field-selector:
      [ field-name ]
optional-field-selector:
      [ field-name ] ?
field-name:
      generalized-identifier
      quoted-identifier
implicit-target-field-selection:
      field-selector
projection:
      primary-expression required-projection
      primary-expression optional-projection
required-projection:
      [ required-selector-list ]
optional-projection:
      [ required-selector-list ] ?
required-selector-list:
      required-field-selector
      required-field-selector , required-selector-list
implicit-target-projection:
      required-projection
      optional-projection

Function expression
function-expression:
      ( parameter-listopt ) return-typeopt => function-body
function-body:
      expression
parameter-list:
      fixed-parameter-list
      fixed-parameter-list , optional-parameter-list
      optional-parameter-list
fixed-parameter-list:
      parameter
      parameter , fixed-parameter-list
parameter:
      parameter-name parameter-typeopt
parameter-name:
      identifier
parameter-type:
      assertion
return-type:
      assertion
assertion:
      as nullable-primitive-type
optional-parameter-list:
      optional-parameter
      optional-parameter , optional-parameter-list
optional-parameter:
      optional parameter

Each expression
each-expression:
      each each-expression-body
each-expression-body:
      function-body

Let expression
let-expression:
      let variable-list in expression
variable-list:
      variable
      variable , variable-list
variable:
      variable-name = expression
variable-name:
      identifier

If expression
if-expression:
      if if-condition then true-expression else false-expression
if-condition:
      expression
true-expression:
      expression
false-expression:
      expression

Type expression
type-expression:
      primary-expression
      type primary-type
type:
      parenthesized-expression
      primary-type
primary-type:
      primitive-type
      record-type
      list-type
      function-type
      table-type
      nullable-type
primitive-type: one of
      any anynonnull binary date datetime datetimezone duration function
      list logical none null number record table text time type
record-type:
      [ open-record-marker ]
      [ field-specification-listopt ]
      [ field-specification-list , open-record-marker ]
field-specification-list:
      field-specification
      field-specification , field-specification-list
field-specification:
      optionalopt field-name field-type-specificationopt
field-type-specification:
      = field-type
field-type:
      type
open-record-marker:
      ...
list-type:
      { item-type }
item-type:
      type
function-type:
      function ( parameter-specification-listopt ) return-type
parameter-specification-list:
      required-parameter-specification-list
      required-parameter-specification-list , optional-parameter-specification-list
      optional-parameter-specification-list
required-parameter-specification-list:
      required-parameter-specification
      required-parameter-specification , required-parameter-specification-list
required-parameter-specification:
      parameter-specification
optional-parameter-specification-list:
      optional-parameter-specification
      optional-parameter-specification , optional-parameter-specification-list
optional-parameter-specification:
      optional parameter-specification
parameter-specification:
      parameter-name parameter-type
table-type:
      table row-type
row-type:
      [ field-specification-listopt ]
nullable-type:
      nullable type

Error raising expression
error-raising-expression:
      error expression_

Error handling expression
error-handling-expression:
      try protected-expression otherwise-clauseopt
protected-expression:
      expression
otherwise-clause:
      otherwise default-expression
default-expression:
      expression

Literal Attributes
literal-attributes:
      record-literal
record-literal:
      [ literal-field-listopt ]
literal-field-list:
      literal-field
      literal-field , literal-field-list
literal-field:
      field-name = any-literal
list-literal:
      { literal-item-listopt }
literal-item-list:
      any-literal
      any-literal , literal-item-list
any-literal:
      record-literal
      list-literal
      logical-literal
      number-literal
      text-literal
      null-literal

