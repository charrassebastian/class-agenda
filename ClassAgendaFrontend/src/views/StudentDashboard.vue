<script setup lang="ts">
import type Student from '../types/Student'
import type { PropType } from 'vue'
import CourseCard from './CourseCard.vue'
import ClassCard from './ClassCard.vue'
import MaterialCard from './MaterialCard.vue'
import { VCard } from 'vuetify/components'
import StudentCard from './StudentCard.vue'
defineProps({
  student: {
    type: Object as PropType<Student>,
    required: true
  }
})
</script>
<template>
  <div class="h-screen w-screen flex flex-col">
    <div class="m-5 flex justify-center">
      <v-card class="w-fit">
        <v-card-title>
          <h1 class="text-3xl">{{ student.name }}</h1>
        </v-card-title>
      </v-card>
    </div>
    <StudentCard :student="student" />
    <div>
      <v-card class="m-5 w-fit">
        <v-card-title>
          <h2 class="text-2xl">Asignaturas</h2>
        </v-card-title>
      </v-card>
      <div class="flex flex-row">
        <CourseCard
          :key="JSON.stringify(course)"
          v-for="course in student.courses"
          :course="course"
        />
      </div>
    </div>
    <div>
      <v-card class="m-5 w-fit">
        <v-card-title>
          <h2 class="text-2xl">Clases</h2>
        </v-card-title>
      </v-card>
      <div class="flex flex-row">
        <ClassCard :key="JSON.stringify(c)" v-for="c in student.classes" :data="c" />
      </div>
    </div>
    <div>
      <v-card class="m-5 w-fit">
        <v-card-title>
          <h2 class="text-2xl">Materiales</h2>
        </v-card-title>
      </v-card>
      <div class="flex flex-row">
        <MaterialCard
          :key="JSON.stringify(material)"
          v-for="material in student.materials"
          :material="material"
        />
      </div>
    </div>
  </div>
</template>
<style scoped></style>
