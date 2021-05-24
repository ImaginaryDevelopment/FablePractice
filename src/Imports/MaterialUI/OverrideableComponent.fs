// ts2fable 0.7.1
module rec Imports.MaterialUI.OverrideableComponent
open System
open Fable.Core
open Fable.Core.JS

// type Omit = @material_ui_types.Omit
// type StyledComponentProps = __styles.StyledComponentProps

/// A component whose root component can be controlled via a `component` prop.
///
/// Adjusts valid props based on the type of `component`.
type [<AllowNullLiteral>] OverridableComponent<'M> =
    [<Emit "$0($1...)">] abstract Invoke: props: obj -> JSX.Element
    [<Emit "$0($1...)">] abstract Invoke: props: DefaultComponentProps<'M> -> JSX.Element

type [<AllowNullLiteral>] OverrideProps<'M, 'C> =
    interface end

type [<AllowNullLiteral>] DefaultComponentProps<'M> =
    interface end

type [<AllowNullLiteral>] BaseProps<'M> =
    interface end

/// Props that are valid for material-ui components.
type [<AllowNullLiteral>] CommonProps<'M> =
    inherit StyledComponentProps<'M>
    abstract className: string option with get, set
    abstract style: React.CSSProperties option with get, set

type [<AllowNullLiteral>] OverridableTypeMap =
    abstract props: OverridableTypeMapProps with get, set
    abstract defaultComponent: React.ElementType with get, set
    abstract classKey: string with get, set

type Simplify<'T> =
    obj

type SimplifiedPropsOf<'C> =
    Simplify<React.ComponentProps<'C>>

type [<AllowNullLiteral>] OverridableTypeMapProps =
    interface end
