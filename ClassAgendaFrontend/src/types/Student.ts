import type Class from './Class'
import type Course from './Course'
import type Material from './Material'

export default interface Student {
  name: string
  phone: string
  preferredPlatform: string
  other: string
  courses?: Course[]
  classes?: Class[]
  materials?: Material[]
}
