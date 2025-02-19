
import './App.css';
import { Counter } from './Counter';
import {BrowserRouter as Router ,Routes,Route,Link} from 'react-router-dom';
import Funccompo from './Funccompo';
import { Component } from 'react';
import { Employee } from './Employee';
import Sample  from './Sample';
import Listimg from './Listimg';
import {BookList} from './BookList';
import {Todo} from './Todo';

function App() {
  return (
    <>
    
    <Counter /><br></br>
    <br></br><br>
    </br>
    <Todo /><br>
    </br>
    <Sample />
    <br></br>

    <Router>
        <nav>
        <br></br>    <Link to="/">CounterusingUseStaeHook</Link> | <Link to="/Employee">Employee</Link>| <Link to ="/Listimg">List of Activities</Link> | <Link to ="BookList">List of Books</Link>
        </nav>
      <Routes>
        <Route path="/" element={<Funccompo/>}/>
        <Route path="/Employee" element={<Employee name="Tejuu"/>}/>
  
        <Route path="/Listimg" element={<Listimg/>}/>
        <Route path="/BookList" element={<BookList/>}/>
      
      </Routes>
     </Router>
    </>
  );
}

export default App;
