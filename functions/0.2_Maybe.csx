// csc /target:library 0.2_Maybe.csx
// This will create 0.2_Maybe.dll
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Maybe<T>
{
    public readonly T Value;
    public readonly bool Is; 
    
    private Maybe(){}
    private Maybe(bool isSome, T value){
        Is = isSome;
        Value = value;
    }
    
    public static Maybe<T> Some(T value){
        return new Maybe<T>(true, value);
    }
    
    public static Maybe<T> None(){
        return new Maybe<T>();
    }
    
    public Maybe<T> IfIs(Action<T> action){
        if(Is){
            action(Value);
        }
        return this;
    }
    
    public Maybe<T> IfIsNot(Action action){
        if(!Is){
            action();
        }
        return this;
    }
}

public static class EnumExt
{
    public static Maybe<T> TrySingle<T>(
        this IEnumerable<T> collection, Func<T, bool> pred)
    {
        try{
            return Maybe<T>.Some(collection.Single(pred));
        }
        catch(InvalidOperationException){
            return Maybe<T>.None();
        }
    }
}