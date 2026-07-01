import React, { useEffect } from 'react'
import { useState } from 'react'
import "./Hero.css"
import bipana from "../../Images/bipana.png"
function Hero(){
    const [data, setData] = useState([])

    useEffect(()=>{
        const fetchData = async()=>{
            const response = await fetch("https://localhost:7207/api/User")
            const result = await response.json()
            setData(result)
        }
fetchData()
    },[])
    return (
        <section>
           <div className='hero'>
            <div>
                {data.map((item)=>(
                    <div>
                    <h3>{item.fullname}</h3>
                    <p>{item.title}</p>
                    
                    </div>
                ))}
                </div>
           </div>
           <div className='hero-img'>
            <img src={bipana} alt="logo"/>

           </div>
        </section>
    )
}
export default Hero;