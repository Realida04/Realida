import React from "react";
import "./Project.css";
import ProjectCard from "../../Components/ProjectCard/ProjectCard";
function Project() {
  return (
    <div className="project-container">
      <div className="project-title">
        My Projects
        <hr className="line" />
      </div>

      <div className="project-list">
        <ProjectCard
        className="project-card"
          title="CRUD Application"
          description="A simple CRUD application for managing data where the user can read, add, edit, and delete records. I have used React.js for the frontend and .NET for the backend."
          githubUrl="https://github.com/Realida04/Practice.git"
          techStack ="React.js, .NET"
        />

        <ProjectCard
        className="project-card"
          title="Chatbot"
          description="A simple chatbot application built with Python and Natural Language Processing where the user can interact with the bot and get the desired information."
          githubUrl="https://github.com/Realida04/College_chatbot.git"
          techStack ="Python, NLP"
        />

        <ProjectCard
        className="project-card"
          title="Portfolio Website"
          description="A personal portfolio website built with React.js to showcase my skills and projects."
          githubUrl="https://github.com/Realida04/Realida.git"
          techStack ="React.js, CSS, HTML, .NET"
        />

        <ProjectCard
        className="project-card"
          title="Recipe"
          description="A simple recipe app where the user can view the recipe of their favourite food and search for new recipes."
          githubUrl="https://github.com/Realida04/recipe_react.git"
          techStack ="React.js, CSS, HTML"
        />
      </div>
    </div>
  );
}
export default Project;
