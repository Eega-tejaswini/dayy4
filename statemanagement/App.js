import logo from './logo.svg';
import './App.css';
import App1 from './App1';
import App2 from './App2';
import App3 from './App3';
import TaskList from './Tasklist';
import App4 from './App4';
import WOCustomHook from './WOcustomHook';
import WCustomHook from './WcustomHook';
import useToggle from './UseToggle';
import App5 from './App5';
function App() {
  return (
    <div className="App">
      <App1/>
      <App2/><br></br>
    <App3/>
      <TaskList />
      <br>
      </br>
      <App4/>
    < WOCustomHook/>
      <WCustomHook />
      <useToggle/>
      <App5/>

    </div>
  );
}

export default App;
