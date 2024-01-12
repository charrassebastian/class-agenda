import type Material from './Material'

export default interface Photo {
  name: string
  image: Uint8Array
  material: Material
}
