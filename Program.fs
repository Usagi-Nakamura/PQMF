open System
open System.IO
open FSharp.Text.Lexing
open Lexer
open Parser

let evaluate (input:string) =
  let lexbuf = LexBuffer<char>.FromString input
  let output = Parser.parse Lexer.tokenize lexbuf
  string output

let tokenList (input : string) =
  let lexbuf: LexBuffer<char> = LexBuffer<char>.FromString input
  seq {
    while not lexbuf.IsPastEndOfStream do
      let tkn = tokenize lexbuf
      match tkn with
      | WHITESPACE contents ->yield (WHITESPACE " ")
      | _ -> yield (tkn)
  }

[<EntryPoint>]
let main argv =

    let reader = 
      let source_path = __SOURCE_DIRECTORY__ + "\\test.pqmf"  
      new StreamReader(source_path)

    let source_text = reader.ReadToEnd()
    reader.Close()

    let input = " " + source_text
    
    printfn "%A" ((tokenList input) |> List.ofSeq)

    let result = evaluate input

    let writer = 
      let distination_path = __SOURCE_DIRECTORY__ + "\\test.pq"
      new StreamWriter(distination_path, false, Text.UTF8Encoding())

    writer.Write(result)
    writer.Close()
    
    0 // return an integer exit code