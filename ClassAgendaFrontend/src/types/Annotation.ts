import type Material from "./Material";

export default interface Annotation {
    content: string,
    material?: Material
}