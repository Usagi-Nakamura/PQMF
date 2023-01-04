///////////////////////////////////////////////////////////////////////////////////
// Start of Boilerplate
///////////////////////////////////////////////////////////////////////////////////
let
    Usagi_Nakamura.Curry = (f as function) =>
        let
            arity = Record.FieldCount(Type.FunctionParameters(Value.Type(f))),
            ApplyTo =
                (args as list) =>
                    if List.Count(args) >= arity then
                        Function.Invoke(f, args)
                    else
                        (x as any) =>
                        if List.Count(args) = arity - 1
                        then @ApplyTo({x} & args)
                        else @ApplyTo(args & {x})
    in
        ApplyTo({})
in
///////////////////////////////////////////////////////////////////////////////////
// End of Boilerplate
///////////////////////////////////////////////////////////////////////////////////


let 
    a = if  b = 3 then 2 else 3
in  
    a