import React from 'react';
import "./Footer.css"
function Footer(){
    return(
        <footer>
            <div className='footer'>
            <p>&copy; {new Date().getFullYear()}</p>
            <p>Made by Realida </p>
            </div>
        </footer>
    )
}
export default Footer;