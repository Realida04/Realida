import React, { useEffect } from "react";
import { useState } from "react";
import "./Hero.css";
import bipana from "../../Images/bipana.png";
function Hero() {
  const [data, setData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      const response = await fetch("https://localhost:7207/api/User");
      const result = await response.json();
      setData(result);
    };
    fetchData();
  }, []);
  return (
    <section className="hero">
        <div className="hero-text">
          {data.map((item) => (
            <div>
                <h3>Hello! 👋</h3>

              <h3>I'm {item.fullname} (Realida)</h3>
              <p>Full Stack {item.title}</p>
            </div>
          ))}
          <button type="submit" className="btn" download>
            Download CV
          </button>
        </div>
 <img src={bipana} alt="Profile" className="hero-image"/>
    </section>
  );
}
export default Hero;
