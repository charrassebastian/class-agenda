<script setup lang="ts">
import type Course from '../types/Course'
import type { PropType } from 'vue'
import { VCard } from 'vuetify/components'
defineProps({
  course: {
    type: Object as PropType<Course>,
    required: true
  }
})
</script>
<template>
  <div class="course">
    <v-card>
      <v-card-title>Asignatura</v-card-title>
      <v-card-text>
        <p>Tipo de evaluacion: {{ course.evaluationType }}</p>
        <p>Nivel: {{ course.level }}</p>
        <p>Institucion: {{ course.school }}</p>
        <p>Nombre: {{ course.topic }}</p>
        <p>Año: {{ course.year }}</p>
        <p>Estudiantes: {{ course.students }}</p>
      </v-card-text>
    </v-card>
  </div>
</template>
<style scoped>
.course {
  margin: 2em;
}
</style>
