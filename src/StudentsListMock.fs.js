import { Record } from "./.fable/fable-library.3.1.1/Types.js";
import { record_type, string_type } from "./.fable/fable-library.3.1.1/Reflection.js";
import { ofArray } from "./.fable/fable-library.3.1.1/List.js";

export class Student extends Record {
    constructor(id, firstName, lastName) {
        super();
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
    }
}

export function Student$reflection() {
    return record_type("FablePractice.StudentsList.Student", [], Student, () => [["id", string_type], ["firstName", string_type], ["lastName", string_type]]);
}

export const studentsList = ofArray([new Student("id1", "John", "Doe"), new Student("id2", "Johnny", "May"), new Student("id3", "Chuck", "Norris")]);

