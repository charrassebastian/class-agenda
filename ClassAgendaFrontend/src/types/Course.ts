import Class from "./Class";
import Material from "./Material";
import Student from "./Student";

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