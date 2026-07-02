import React from "react";
import "./Navbar.css";
function NavBar() {
  
  return (
    <section>
      <div className="navbar">
        <h2 className="logo">Realida</h2>

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
