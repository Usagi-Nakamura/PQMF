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

Now only 6% of m language's grammatical rules have been taken care of.

> Usage

1. Write code something like below in the file named "test.pqmf".  
![](\image\2022-11-20_17h51.png)

1. "dotnet run" at the path PQMF on the command line, If it returns to prompt with no error message,
   test.pq has been created successfully.

1. Open Blank.xlsx and **refresh all** ,then that book reads test.pq and you can see the result on the sheet. 