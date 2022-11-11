#load "Lexer.fs"

open System
open System.IO
open FSharp.Text.Lexing
open Lexer

let reader = 
    let source_path = __SOURCE_DIRECTORY__ + "\\test.pqmf"  
    new StreamReader(source_path)

let input = reader.ReadToEnd()
reader.Close()

let lexbuf =

printf "%s" input
