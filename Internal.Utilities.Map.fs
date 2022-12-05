module Internal.Utilities.Map
open System
open FSharp.Text.Lexing
open Parser

let operators =

    [

        "+", ADDITIVE_OPERATOR;
        "-", ADDITIVE_OPERATOR;
        "&", ADDITIVE_OPERATOR;
        "*", MULTIPLICATIVE_OPERATOR;
        "/", MULTIPLICATIVE_OPERATOR;
        " ", WHITESPACE;
        "\t", WHITESPACE;
        "\n", WHITESPACE;
        "\r", WHITESPACE;
        "|>", FORWARD_PIPELINE_OPERATOR;
        "(", OPENING_PARENTHESIS;
        ")", CLOSING_PARENTHESIS;
        ",", COMMA;
        "{", OPENING_BRACE;
        "}", CLOSING_BRACE;
        "[", OPENING_SQUARE_BRACKET;
        "]", CLOSING_SQUARE_BRACKET;
        "..", DOTDOT;
        "=>", FUNCTION_OPERATOR;
        "=", EQ;
        "<>", NE;
        ">", RELATIONAL_OPERATOR;
        "<", RELATIONAL_OPERATOR;
        ">=", RELATIONAL_OPERATOR;
        "<=", RELATIONAL_OPERATOR;
        "?", QUESTION_MARK

    ] |> Map.ofList

let keywords =

    [
                 
        "and", AND;
        "each", EACH;
        "else", ELSE;
        "error", ERROR;
        "as", AS;
        "false", FALSE;
        "if", IF;
        "in", IN;
        "is", IS;
        "let", LET;
        "meta", META;
        "not", NOT;
        "null", NULL;
        "nullable", NULLABLE;
        "optional", OPTIONAL;
        "or", OR;
        "otherwise", OTHERWISE;
        "section", SECTION;
        "shared", SHARED;
        "then", THEN;
        "true", TRUE;
        "try", TRY;
        "type", TYPE;
        "#binary", HASH_BINARY;
        "#date", HASH_DATE;
        "#datetime", HASH_DATETIME;
        "#datetimezone", HASH_DATETIMEZONE;
        "#duration", HASH_DURATION;
        "#infinity", HASH_INFINITY;
        "#nan", HASH_NAN;
        "#sections", HASH_SECTION;
        "#shared", HASH_SHARED;
        "#table", HASH_TABLE;
        "#time", HASH_TIME;

    ] |> Map.ofList



