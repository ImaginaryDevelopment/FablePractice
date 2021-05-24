// ts2fable 0.7.1
module rec Imports.MaterialUI.Grid
open System
open Fable.Core
open Fable.Core.JS
open Imports.MaterialUI.OverrideableComponent

// type Breakpoint = ___styles_createBreakpoints.Breakpoint

let [<Import("Grid","@material-ui/core/Grid/Grid")>] Grid: OverridableComponent<GridTypeMap> = jsNative

type [<StringEnum>] [<RequireQualifiedAccess>] GridItemsAlignment =
    | [<CompiledName "flex-start">] FlexStart
    | Center
    | [<CompiledName "flex-end">] FlexEnd
    | Stretch
    | Baseline

type [<StringEnum>] [<RequireQualifiedAccess>] GridContentAlignment =
    | Stretch
    | Center
    | [<CompiledName "flex-start">] FlexStart
    | [<CompiledName "flex-end">] FlexEnd
    | [<CompiledName "space-between">] SpaceBetween
    | [<CompiledName "space-around">] SpaceAround

type [<StringEnum>] [<RequireQualifiedAccess>] GridDirection =
    | Row
    | [<CompiledName "row-reverse">] RowReverse
    | Column
    | [<CompiledName "column-reverse">] ColumnReverse

type [<RequireQualifiedAccess>] GridSpacing =
    | N0 = 0
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4
    | N5 = 5
    | N6 = 6
    | N7 = 7
    | N8 = 8
    | N9 = 9
    | N10 = 10

type [<StringEnum>] [<RequireQualifiedAccess>] GridJustification =
    | [<CompiledName "flex-start">] FlexStart
    | Center
    | [<CompiledName "flex-end">] FlexEnd
    | [<CompiledName "space-between">] SpaceBetween
    | [<CompiledName "space-around">] SpaceAround
    | [<CompiledName "space-evenly">] SpaceEvenly

type [<StringEnum>] [<RequireQualifiedAccess>] GridWrap =
    | Nowrap
    | Wrap
    | [<CompiledName "wrap-reverse">] WrapReverse

type GridSize =
    U2<string, float>

type [<StringEnum>] [<RequireQualifiedAccess>] GridClassKey =
    | Root
    | Container
    | Item
    | ZeroMinWidth
    | [<CompiledName "direction-xs-column">] DirectionXsColumn
    | [<CompiledName "direction-xs-column-reverse">] DirectionXsColumnReverse
    | [<CompiledName "direction-xs-row-reverse">] DirectionXsRowReverse
    | [<CompiledName "wrap-xs-nowrap">] WrapXsNowrap
    | [<CompiledName "wrap-xs-wrap-reverse">] WrapXsWrapReverse
    | [<CompiledName "align-items-xs-center">] AlignItemsXsCenter
    | [<CompiledName "align-items-xs-flex-start">] AlignItemsXsFlexStart
    | [<CompiledName "align-items-xs-flex-end">] AlignItemsXsFlexEnd
    | [<CompiledName "align-items-xs-baseline">] AlignItemsXsBaseline
    | [<CompiledName "align-content-xs-center">] AlignContentXsCenter
    | [<CompiledName "align-content-xs-flex-start">] AlignContentXsFlexStart
    | [<CompiledName "align-content-xs-flex-end">] AlignContentXsFlexEnd
    | [<CompiledName "align-content-xs-space-between">] AlignContentXsSpaceBetween
    | [<CompiledName "align-content-xs-space-around">] AlignContentXsSpaceAround
    | [<CompiledName "justify-xs-center">] JustifyXsCenter
    | [<CompiledName "justify-xs-flex-end">] JustifyXsFlexEnd
    | [<CompiledName "justify-xs-space-between">] JustifyXsSpaceBetween
    | [<CompiledName "justify-xs-space-around">] JustifyXsSpaceAround
    | [<CompiledName "justify-xs-space-evenly">] JustifyXsSpaceEvenly
    | [<CompiledName "spacing-xs-1">] SpacingXs1
    | [<CompiledName "spacing-xs-2">] SpacingXs2
    | [<CompiledName "spacing-xs-3">] SpacingXs3
    | [<CompiledName "spacing-xs-4">] SpacingXs4
    | [<CompiledName "spacing-xs-5">] SpacingXs5
    | [<CompiledName "spacing-xs-6">] SpacingXs6
    | [<CompiledName "spacing-xs-7">] SpacingXs7
    | [<CompiledName "spacing-xs-8">] SpacingXs8
    | [<CompiledName "spacing-xs-9">] SpacingXs9
    | [<CompiledName "spacing-xs-10">] SpacingXs10
    | [<CompiledName "grid-xs-auto">] GridXsAuto
    | [<CompiledName "grid-xs-true">] GridXsTrue
    | [<CompiledName "grid-xs-1">] GridXs1
    | [<CompiledName "grid-xs-2">] GridXs2
    | [<CompiledName "grid-xs-3">] GridXs3
    | [<CompiledName "grid-xs-4">] GridXs4
    | [<CompiledName "grid-xs-5">] GridXs5
    | [<CompiledName "grid-xs-6">] GridXs6
    | [<CompiledName "grid-xs-7">] GridXs7
    | [<CompiledName "grid-xs-8">] GridXs8
    | [<CompiledName "grid-xs-9">] GridXs9
    | [<CompiledName "grid-xs-10">] GridXs10
    | [<CompiledName "grid-xs-11">] GridXs11
    | [<CompiledName "grid-xs-12">] GridXs12

type GridTypeMap<'D> =
    GridTypeMap<obj, 'D>

type GridTypeMap =
    GridTypeMap<obj, obj>

type [<AllowNullLiteral>] GridTypeMap<'P, 'D> =
    abstract props: obj with get, set
    abstract defaultComponent: 'D with get, set
    abstract classKey: GridClassKey with get, set

type GridProps<'P> =
    GridProps<obj, 'P>

type GridProps =
    GridProps<obj, obj>

type GridProps<'D, 'P> =
    OverrideProps<GridTypeMap<'P, 'D>, 'D>
