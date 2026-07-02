import React from "react";
import "./Navbar.css";
function NavBar() {
  
  return (
    <section>
      <div className="navbar">
        <h2 className="logo">
           <span className="tag">&lt;</span>
        <span className="name">Realida</span>
        <span className="tag">/&gt;</span>
        </h2>

        <div className="nav-links">
          <ul>
            <li>
              <a href="/">Home</a>
            </li>
            <li>
              <a href="/about">About</a>
            </li>

            <li>
              <a href="/about">Project</a>
            </li>

            <li>
              <a href="/about">Experience</a>
            </li>
            <li>
              <a href="/contact">Contact</a>
            </li>
          </ul>

        </div>
      </div>
    </section>
  );
}
export default NavBar;
