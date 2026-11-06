import react from "@vitejs/plugin-react";
import { fileURLToPath } from "node:url";
import { defineConfig } from "vite";

// https://vite.dev/config/
export default defineConfig({
  plugins: [react()],
  base: "/react/",
  build: {
    outDir: fileURLToPath(new URL("../wwwroot/react", import.meta.url)),

    emptyOutDir: true,
    manifest: true,

    rollupOptions: {
      input: fileURLToPath(new URL("./src/main.tsx", import.meta.url)),
    },
  },
});
