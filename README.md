## PQMF

> Goal

This project is for making microsoft excel power query m language a little bit more 
functional and for making a transpiler from such code to normal m language, written in F Sharp using FsLexYacc.

Being "a little bit more functional" above includes the followings, all of which normal m-language doesn't have such feature.

1. f# style function invocation, so as to curry functions straightforwardly.

1. pipeline operator and function composing operator. To be able to define any custom infix operator would be nicer.

1. pattern matching expression

1. off side rules especially for let syntax.

> Status

Now it is just in experimental stage.

> Usage

1. Write code in the file named "test.pqmf".

1. "dotnet run" at the path PQMF on the command line


