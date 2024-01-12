import type Student from './types/Student'

const student: Student = {
  name: 'Sebastian',
  phone: '+54 9 11 1234-5678',
  preferredPlatform: 'Zoom',
  other: '',
  courses: [
    {
      topic: 'Estructuras de Datos',
      year: new Date('1/1/2024'),
      level: 'Educacion Superior',
      school: 'UTN',
      evaluationType: 'Anual'
    },
    {
      topic: 'Algoritmia',
      year: new Date('1/1/2024'),
      level: 'Grado',
      school: 'UBA',
      evaluationType: 'Cuatrimestral'
    }
  ],
  classes: [
    {
      start: new Date('1/1/2024'),
      end: new Date('1/1/2024')
    },
    {
      start: new Date('2/1/2024'),
      end: new Date('2/1/2024')
    }
  ],
  materials: [
    {
      type: 'Libro',
      name: 'Estructuras de Datos',
      due: new Date('1/1/2024'),
      teacher: 'Raul Ramos'
    },
    {
      type: 'Examen Final',
      name: 'Algoritmia 1',
      due: new Date('2/1/2024'),
      teacher: 'Bruno Valdez'
    }
  ]
}

export default student
