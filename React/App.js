
import './App.css';
import { Book , Product} from './component';
import Welcome from './Welcome';
import Student from './student';
import Products from './Products';
import Category from './category';

function App() {
  return (
    <div>
     <Welcome></Welcome>
    <Student stid ="12" stname ="vyshh" stage="21" > </Student> 
    <Book bookname ="abc" bookid ="12" > </Book>
    <Product prodname = "ab" prodid="10">
    </Product>
    <Products pname = "books" ></Products>
    <Category Cname = "items" ></Category>
    </div>
  );
}

export default App;
