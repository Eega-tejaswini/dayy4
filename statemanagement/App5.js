import useToggle from "./UseToggle"

export default function App5() {
const [value, toggleValue] = useToggle(false)

  return (
    <div>
      <div>{value.toString()}</div>
      <button onClick={toggleValue}>Toggle</button>
      <br></br>
     <button onClick={() => toggleValue(true)}>Make True</button>
       <button onClick={() => toggleValue(false)}>Make False</button>
   </div>
 ) }