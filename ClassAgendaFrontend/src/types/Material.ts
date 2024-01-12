import type Annotation from './Annotation'
import type Course from './Course'
import type Photo from './Photo'
import type Student from './Student'

export default interface Material {
  type: string
  name: string
  due: Date
  course?: Course
  student?: Student
  teacher: string
  annotations?: Annotation[]
  photos?: Photo[]
}
