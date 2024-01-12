import Course from "./Course";
import Student from "./Student";

export default interface Class {
    course?: Course,
    student?: Student,
    start: Date,
    end: Date
}