import { useEffect, useState } from "react";
import Project1LandingPage from "../api/Project1LandingPage";
import P1_1Navbar from "./P1_1Navbar.jsx";
function P1_0Main() {
  const [data, setData] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const res = await Project1LandingPage();
        setData(res);
      } catch (err) {
        console.error(err);
      }
    };

    fetchData();
  }, []);
  if (!data) return <p>Loading...</p>;

  return (
    <div>
      <P1_1Navbar />
    </div>
  );
}

export default P1_0Main;
