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

Now only 33% of grammatical rules of m language have been taken care of.  
See Progress.xlsx

> Usage

1. Write code something like below in the file named "test.pqmf". 

   ![](https://github.com/Usagi-Nakamura/PQMF/blob/main/images/2022-11-20_17h51_51.png?raw=true)

1. "dotnet run" at the path PQMF on the command line, Returning to prompt with no error message,
   test.pq has been created successfully.  

   ![](https://github.com/Usagi-Nakamura/PQMF/blob/main/images/2022-11-20_17h53_37.png?raw=true)

1. Open Blank.xlsx and **Refresh All** .  

   ![](https://github.com/Usagi-Nakamura/PQMF/blob/main/images/2022-11-20_22h20_01.png?raw=true)


1. Then that Excel book reads test.pq and you can see result of the query on the sheet.  

   ![](https://github.com/Usagi-Nakamura/PQMF/blob/main/images/2022-11-20_22h26_12.png?raw=true)