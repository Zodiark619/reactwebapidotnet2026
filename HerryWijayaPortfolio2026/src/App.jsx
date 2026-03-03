import { useEffect, useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";
import Project1LandingPage from "./api/Project1LandingPage";
function App() {
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
      <h1>{data.name}</h1>
      <p>{data.email}</p>
      <p>{data.github}</p>
    </div>
  );
}

export default App;
