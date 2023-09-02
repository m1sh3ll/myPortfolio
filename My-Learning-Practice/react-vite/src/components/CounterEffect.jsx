import { useEffect, useState } from "react";

function CounterEffect() {
  const [count, setCount] = useState(0);

  useEffect(() => {
    console.log("Component Mounted");

    const handleClick = () => setCount((c) => c + 1);
    document.addEventListener('click',handleClick);

    return () => {
      console.log('Component unmounted');
      document.removeEventListener('click',handleClick);
    }
  },[])

  return (
    <>
    <hr/>
      <h1>Count: {count}</h1>
      <button>Increment</button>
    </>
  )
}


export default CounterEffect;