import { useState } from "react";

function CounterFunction() {
  const [count, setCount] = useState(0);

  function increment() {
    setCount(count+1);
  }

  return (
    <>
    <hr/>
      <h1>Count Function {count}</h1>
      <button onClick={increment}>Increment</button>
    </>
  )
}


export default CounterFunction;