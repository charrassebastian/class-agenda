<script setup lang="ts">
import StudentDashboard from './StudentDashboard.vue'
import student from '../exampleStudent'
</script>
<template>
  <div class="home-view">
    <StudentDashboard :student="student" />
  </div>
</template>
<style scoped>
.home-view {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 100vw;
  margin: 0;
}
</style>
