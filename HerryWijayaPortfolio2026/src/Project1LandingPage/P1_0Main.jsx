import { useEffect, useState } from "react";
import Project1LandingPage from "../api/Project1LandingPage";
import P1_1Navbar from "./P1_1Navbar.jsx";
import P1_2Header from "./P1_2Header.jsx";
import P1_3About from "./P1_3About.jsx";
import P1_8Footer from "./P1_8Footer.jsx";
import P1_7Contact from "./P1_7Contact.jsx";
import P1_6Portfolio from "./P1_6Portfolio.jsx";
import P1_4Service from "./P1_4Service.jsx";
import P1_5Resume from "./P1_5Resume.jsx";
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
      <P1_1Navbar data={data} />
      <P1_2Header data={data} />
      <P1_3About data={data} />

      <P1_4Service data={data} />
      <P1_5Resume data={data} />
      <P1_6Portfolio data={data} />
      <P1_7Contact data={data} />
      <P1_8Footer data={data} />
    </div>
  );
}
export default P1_0Main;
