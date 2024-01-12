<script setup lang="ts">
import type Class from '../types/Class'
import type { PropType } from 'vue'
defineProps({
  data: {
    type: Object as PropType<Class>,
    required: true
  }
})
</script>
<template>
    <div class="class">
      <p>Clase</p>
      <p>Asignatura: {{  data.course }}</p>
      <p>Inicio: {{ data.start }}</p>
      <p>Fin: {{ data.end }}</p>
    </div>
</template>
<style scoped>
.class {
    margin: 2em;
}
</style>