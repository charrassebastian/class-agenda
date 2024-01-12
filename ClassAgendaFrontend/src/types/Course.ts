import type Class from "./Class";
import type Material from "./Material";
import type Student from "./Student";

export default interface Course {
    topic: string,
    year: Date,
    level: string,
    school: string,
    evaluationType: string,
    students?: Student[],
    classes?: Class[],
    materials?: Material[]
}