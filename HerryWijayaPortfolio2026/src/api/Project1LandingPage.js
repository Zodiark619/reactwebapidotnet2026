import api from "./api";

const Project1LandingPage = async () => {
  const response = await api.get("/project1landingpage");
  return response.data;
};
export default Project1LandingPage;
