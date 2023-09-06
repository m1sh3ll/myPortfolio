import React from  "react";

class Counter extends React.Component {
  constructor(props){
    super(props);
    this.state = {
      count:0
    }
  }  

  render() {
    return(
      <>
      <hr/>
        <p>You clicked the button {this.state.count} times</p>
        <button onClick={() => this.setState({count: this.state.count + 1})}>Click Me!</button>
      </>
    )
  }

}




export default Counter;