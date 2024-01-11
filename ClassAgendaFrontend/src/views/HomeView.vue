<script setup lang="ts">
import StudentDashboard from './StudentDashboard.vue'
import StudentDTO from '../types/StudentDTO'
const student: StudentDTO = {
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
</style>