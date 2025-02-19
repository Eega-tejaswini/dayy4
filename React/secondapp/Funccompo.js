import { useState } from "react"


const FuncCounter  = () => {
  
    const [count,setcount]=useState(0);
    
    const Increment =() =>{
        setcount(prcount =>prcount+1);
     
    }
    return (
        <div>
            <h1>CountValue: {count}</h1>
            <button onClick={Increment}>Add</button>
        </div>
    )
}

export default FuncCounter;

