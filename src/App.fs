module App

open Browser.Dom

// Mutable variable to count the number of times we clicked the button
let mutable count = 0
type BaseListItem =
    abstract member BaseListItem: string

// type BaseListItem = {
//   id: string
// }
type GristListProps<'gridListItemType when 'gridListItemType :> BaseListItem> = {
    items: 'gridListItemType list
    renderItem: 'gridListItemType -> ReactNode
}
// Get a reference to our button and cast the Element to an HTMLButtonElement
let myButton = document.querySelector(".my-button") :?> Browser.Types.HTMLButtonElement

// Register our listener
myButton.onclick <- fun _ ->
    count <- count + 1
    myButton.innerText <- sprintf "You clicked: %i time(s)" count
