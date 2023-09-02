import Header from "./components/Header";
import Footer from "./components/Footer";
import Greeting from "./components/Greeting";
import Counter from "./components/Counter";
import CounterFunction from "./components/CounterFunction";
import CounterEffect from "./components/CounterEffect";
import AddToCart from "./components/AddToCart";
function App() {
  

  return (
  
      <div>
      <Header/>
      <Greeting name="Michelle"/>
      <Counter />
      <CounterFunction />
      <CounterEffect />
      <Footer />
      <AddToCart/>
      </div>     
    
  )
}

export default App
