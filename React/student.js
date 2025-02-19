import Department from './department';
const Student = ({stid,stname,stage})=>{
    return(
        <div>
            <h1> student details</h1>
            <h3> id : {stid}</h3>
            <h3>Name : {stname}</h3>
            <h3> age : {stage}</h3>
            <Department dept ="cse"></Department>
        </div>
    )  
}
export default Student;



