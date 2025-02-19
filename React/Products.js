import Category from './category';
import React,{ Component } from "react";
class Products extends Component{
    render(){
        return <div>
            <h2>Product Details</h2>
            <p>
                <label>Product name : <b>{this.props.pname}</b></label>
            </p>
            <Category Cname ={this.props.Cname}></Category>
        </div>

    }
}
export default Products