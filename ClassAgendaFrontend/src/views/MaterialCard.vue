<script setup lang="ts">
import type Material from '../types/Material'
import type { PropType } from 'vue'
import { VBtn, VCard } from 'vuetify/components'
defineProps({
  material: {
    type: Object as PropType<Material>,
    required: true
  }
})
</script>
<template>
  <v-card class="m-3">
    <v-card-title>Material</v-card-title>
    <v-card-text>
      <p>Fecha de entrega: {{ material.due }}</p>
      <p>Docente: {{ material.teacher }}</p>
      <p>Tipo: {{ material.type }}</p>
      <p>Asignatura: {{ material.course }}</p>
    </v-card-text>
    <v-card-actions>
      <v-btn>Ver fotos</v-btn>
    </v-card-actions>
  </v-card>
</template>
<style scoped></style>
