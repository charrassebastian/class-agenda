<script setup lang="ts">
import type Student from '../types/Student'
import type { PropType } from 'vue'
import CourseCard from './CourseCard.vue'
import ClassCard from './ClassCard.vue'
import MaterialCard from './MaterialCard.vue'
import { VCard } from 'vuetify/components'
defineProps({
  student: {
    type: Object as PropType<Student>,
    required: true
  }
})
</script>
<template>
  <div class="student-dashboard">
    <h1 class="text-5xl m-5 text-white">{{ student.name }}</h1>
    <v-card>
      <v-card-item>
        <v-card-text>
          <p>Telefono: {{ student.phone }}</p>
          <p>Plataforma preferida: {{ student.preferredPlatform }}</p>
          <p>Otro: {{ student.other }}</p>
        </v-card-text>
      </v-card-item>
    </v-card>
    <div>
      <CourseCard
        :key="JSON.stringify(course)"
        v-for="course in student.courses"
        :course="course"
      />
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
  </div>
</template>
<style scoped>
.student-dashboard {
  display: flex;
  justify-content: center;
  flex-direction: column;
  align-items: center;
  width: 100%;
}
</style>
