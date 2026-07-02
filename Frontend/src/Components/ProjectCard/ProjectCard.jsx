import React from "react"
import "./ProjectCard.css"
function ProjectCard(props) {
    return(
        <div className="project-card">
            <div className="project-card-content">
                <h3>{props.title}</h3>
                <p>{props.description}</p>
                <p className="tech-stack">Tech Stack: {props.techStack}</p>
                <a href={props.githubUrl} target="_blank" rel="noopener noreferrer">
                    View on GitHub
                </a>
            </div>
        </div>
    )
}
export default ProjectCard