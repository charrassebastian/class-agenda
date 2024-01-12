<script setup lang="ts">
import type Class from '../types/Class'
import type { PropType } from 'vue'
import { VCard } from 'vuetify/components'
defineProps({
  data: {
    type: Object as PropType<Class>,
    required: true
  }
})
</script>
<template>
  <div class="class">
    <v-card>
      <v-card-title>Clase</v-card-title>
      <v-card-text>
        <p>Asignatura: {{ data.course }}</p>
        <p>Inicio: {{ data.start }}</p>
        <p>Fin: {{ data.end }}</p>
      </v-card-text>
    </v-card>
  </div>
</template>
<style scoped>
.class {
  margin: 2em;
}
</style>
