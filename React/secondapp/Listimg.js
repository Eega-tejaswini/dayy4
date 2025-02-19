import { useState } from "react"

import Img1 from './images/drawing.jpg';
import Img2 from './images/green.jpg';
import Img3 from './images/play.jpg';
import Img4 from './images/running.jpg';


export default function Listimg(){
    const [showlist,setImgs] = useState (false)
    
    const images = [Img1,Img2,Img3,Img4]

    return (
        <div>
            <button onClick={()=> setImgs(!showlist)}>
                {showlist? 'Images are displayed ' : ' No images in the list'}
                </button>
                {showlist && (
                    <ul>
                        {images.map(item =>
                            <li><img src = {item} ></img></li>
                        )}
                    </ul>
                )}
        </div>
    )

}