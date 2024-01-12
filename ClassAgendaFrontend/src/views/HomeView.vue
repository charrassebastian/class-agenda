<script setup lang="ts">
import StudentDashboard from './StudentDashboard.vue'
import student from '../exampleStudent'
</script>
<template>
  <StudentDashboard :student="student" />
</template>
<style scoped></style>
