import react,{ Component } from "react";
import open from './open.jpg'
import close from './close.png'


export default class Sample extends Component{
    
    constructor(props) {
        super(props)
        this.state = {
            msg: "Close the door",
            imgname: open
        }
    }
    
    ButtonChange = () =>
    {
        this.setState (
            {
                msg:"Thankyou....",
                imgname:close
            }
        )
    }


    render(){
        return (
           <>
            <h3>{this.state.msg}</h3>
            <img src={this.state.imgname} alt="lightimg"></img>
            <button onClick={this.ButtonChange}>Click Here</button>
           </>
        )
    }
}