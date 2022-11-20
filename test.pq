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
    a = 2,
    b = Usagi_Nakamura.Curry(List.Transform)((x)=>x * 2)({a..(2 * 5)}) 
in 
    b