<script setup lang="ts">
import StudentDashboard from './StudentDashboard.vue'
import student from '../exampleStudent'
</script>
<template>
  <div class="home-view flex justify-center align-center h-screen w-screen bg-[url('assets/background.jpg')] bg-cover bg-center bg-no-repeat">
    <StudentDashboard :student="student" />
  </div>
</template>
<style scoped>
.home-view {
  overflow-y: auto;
}
</style>
