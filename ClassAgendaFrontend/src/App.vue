<script setup lang="ts">
import StudentDashboard from './views/StudentDashboard.vue'
import type Student from './types/Student'

const student: Student = {
  name: "Sebastian",
  phone: "+54 9 11 1234-5678",
  preferredPlatform: "Zoom",
  other: ""
}
</script>
<template>
  <StudentDashboard :student="student"/>
</template>
<style scoped>
</style>./types/Student