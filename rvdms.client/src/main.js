import "./assets/main.css";

import { createApp } from "vue";
import { createPinia } from "pinia";
import Toast from "vue-toastification";
// Importing the CSS
import "vue-toastification/dist/index.css";
import App from "./App.vue";
import router from "./router/Index";

const app = createApp(App);
const pinia = createPinia();
app.use(pinia);
app.use(Toast, {
  position: "top-right",
  timeout: 4000,
});
app.use(router);
app.mount("#app");
