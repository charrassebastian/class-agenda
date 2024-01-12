<script setup lang="ts">
import type Material from '../types/Material'
import type { PropType } from 'vue'
defineProps({
  material: {
    type: Object as PropType<Material>,
    required: true
  }
})
</script>
<template>
  <div class="material">
    <p>Material</p>
    <p>Fecha de entrega: {{ material.due }}</p>
    <p>Docente: {{ material.teacher }}</p>
    <p>Tipo: {{ material.type }}</p>
    <p>Asignatura: {{ material.course }}</p>
    <button>Ver fotos</button>
  </div>
</template>
<style scoped>
.material {
  margin: 2em;
}
</style>
