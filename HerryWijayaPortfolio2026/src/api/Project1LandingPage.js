import api from "./api";

const Project1LandingPage = async () => {
  const response = await api.get("/");
  return response.data;
};
export default Project1LandingPage;
