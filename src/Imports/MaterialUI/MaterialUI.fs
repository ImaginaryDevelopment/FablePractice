// ts2fable 0.7.1
module rec Imports.MaterialUI
open System
open Fable.Core
open Fable.Core.JS



type [<AllowNullLiteral>] ConsistentWith<'DecorationTargetProps, 'InjectedProps> =
    interface end

type PropInjector<'AdditionalProps> =
    PropInjector<obj, 'AdditionalProps>

type [<AllowNullLiteral>] PropInjector<'InjectedProps, 'AdditionalProps> =
    [<Emit "$0($1...)">] abstract Invoke: ``component``: 'C -> React.ComponentType<obj>

type Omit<'T, 'K> =
    obj

type OverridableStringUnion<'U> =
    OverridableStringUnion<obj, 'U>

type OverridableStringUnion<'T, 'U> =
    GenerateStringUnion<Overwrite<'T, 'U>>

type [<AllowNullLiteral>] Overwrite<'T, 'U> =
    interface end

type GenerateStringUnion<'T> =
    Extract<obj, string>
