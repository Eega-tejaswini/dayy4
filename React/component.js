
export const Book = ({bookname,bookid})=>{
    return(
        <div ClassName = 'container'>

            <h1>BookDetails</h1>
            <h4>Book Name: {bookname}</h4>
            <h4>Bookid : {bookid}</h4>
        </div>
    )
}
 export const Product =({prodname,prodid}) =>{
    return(
        <div>
            <h1>ProductDetails</h1>
            <h4>Product Name: {prodname}</h4>
            <h4>Productid : {prodid}</h4>

        </div>
    )
}