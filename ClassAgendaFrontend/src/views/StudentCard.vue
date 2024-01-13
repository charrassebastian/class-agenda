<script setup lang="ts">
import type Student from '../types/Student'
import type { PropType } from 'vue'
import { VCard } from 'vuetify/components'
defineProps({
  student: {
    type: Object as PropType<Student>,
    required: true
  }
})
</script>
<template>
  <div class="m-5">
    <v-card>
      <v-card-title>Datos</v-card-title>
      <v-card-text>
        <p>Telefono: {{ student.phone }}</p>
        <p>Plataforma preferida: {{ student.preferredPlatform }}</p>
        <p>Otro: {{ student.other }}</p>
      </v-card-text>
    </v-card>
  </div>
</template>
<style scoped></style>
