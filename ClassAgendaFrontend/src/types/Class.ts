import type Course from "./Course";
import type Student from "./Student";

export default interface Class {
    course?: Course,
    student?: Student,
    start: Date,
    end: Date
}