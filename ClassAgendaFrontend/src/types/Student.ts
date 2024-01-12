import { Class } from "estree";
import Course from "./Course";
import Material from "./Material";

export default interface Student {
  name: string,
  phone: string,
  preferredPlatform: string,
  other: string,
  courses?: Course[],
  classes?: Class[],
  materials?: Material[]
}
