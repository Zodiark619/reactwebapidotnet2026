import axios from "axios";

const api = axios.create({
  baseURL: "http://herrywijayareact2026.runasp.net/api",
  // baseURL: "/api",
});

export default api;
