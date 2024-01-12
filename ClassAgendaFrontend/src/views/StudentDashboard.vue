<script setup lang="ts">
import type Student from '../types/Student'
import type { PropType } from 'vue'
import CourseCard from './CourseCard.vue'
import ClassCard from './ClassCard.vue'
import MaterialCard from './MaterialCard.vue'
defineProps({
  student: {
    type: Object as PropType<Student>,
    required: true
  }
})
</script>
<template>
  <h1>Nombre: {{ student.name }}</h1>
  <p>Teléfono: {{ student.phone }}</p>
  <p>Plataforma preferida: {{ student.preferredPlatform }}</p>
  <p>Otro: {{ student.other }}</p>
  <div>
    <CourseCard :key="JSON.stringify(course)" v-for="course in student.courses" :course="course" />
  </div>
  <div>
    <ClassCard :key="JSON.stringify(c)" v-for="c in student.classes" :data="c" />
  </div>
  <div>
    <MaterialCard
      :key="JSON.stringify(material)"
      v-for="material in student.materials"
      :material="material"
    />
  </div>
</template>
<style scoped></style>
