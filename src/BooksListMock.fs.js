import { Record } from "./.fable/fable-library.3.1.1/Types.js";
import { record_type, int32_type, string_type } from "./.fable/fable-library.3.1.1/Reflection.js";
import { ofArray } from "./.fable/fable-library.3.1.1/List.js";

export class Book extends Record {
    constructor(id, title, author, releaseYear, pagesCount) {
        super();
        this.id = id;
        this.title = title;
        this.author = author;
        this.releaseYear = (releaseYear | 0);
        this.pagesCount = (pagesCount | 0);
    }
}

export function Book$reflection() {
    return record_type("FablePractice.BooksList.Book", [], Book, () => [["id", string_type], ["title", string_type], ["author", string_type], ["releaseYear", int32_type], ["pagesCount", int32_type]]);
}

export const booksList = ofArray([new Book("book1", "Clean Code", "Robert C. Martin", 2009, 424), new Book("book2", "Python for newbies", "Tommy Snake", 2021, 50), new Book("book3", "Why React?", "John Reactive", 2020, 999)]);

