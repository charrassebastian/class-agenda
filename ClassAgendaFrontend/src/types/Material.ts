import Annotation from "./Annotation";
import Course from "./Course";
import Photo from "./Photo";
import Student from "./Student";

type NewType = Course;

export default interface Material {
    type: string,
    name: string,
    due: Date,
    course?: NewType,
    student?: Student,
    teacher: string,
    annotations?: Annotation[],
    photos?: Photo[]
}