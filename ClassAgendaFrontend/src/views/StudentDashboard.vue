<script setup lang="ts">
import type StudentDTO from '../types/StudentDTO'
import type { PropType } from 'vue'
    defineProps({
        student: {
            type: Object as PropType<StudentDTO>,
            required: true
        }
    })
    // TODO: add courses, classes and materials
</script>
<template>
    <h1>Nombre: {{ student.name }}</h1>
    <p>Teléfono: {{ student.phone }}</p>
    <p>Plataforma preferida: {{  student.preferredPlatform }}</p>
    <p>Otro: {{ student.other }}</p>
</template>
<style scroped>
</style>