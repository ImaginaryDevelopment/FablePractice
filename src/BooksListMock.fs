module FablePractice.BooksList

type Book = {
    id: string
    title: string
    author: string
    releaseYear: int
    pagesCount: int
}
// type is implied by shape, if I wanted to specify it would be:
// let booksList:Book[] =
let booksList = [
    {
        id= "book1"
        title= "Clean Code"
        author= "Robert C. Martin"
        releaseYear= 2009
        pagesCount= 424
    }
    {
        id= "book2"
        title= "Python for newbies"
        author= "Tommy Snake"
        releaseYear= 2021
        pagesCount= 50
    }
    {
        id= "book3"
        title= "Why React?"
        author= "John Reactive"
        releaseYear= 2020
        pagesCount= 999
    }
]