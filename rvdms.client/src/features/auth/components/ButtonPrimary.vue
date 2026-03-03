<template>
  <button :type="type" class="bg-blue-600 text-white px-4 py-2 rounded hover:bg-blue-700">
    {{ text }}
  </button>
</template>

<script setup>
import { defineProps } from "vue";

const props = defineProps({
  text: { type: String, required: true },
  type: { type: String, default: "button" },
});
</script>
