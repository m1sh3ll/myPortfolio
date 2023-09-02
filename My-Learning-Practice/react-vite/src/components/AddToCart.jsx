import React from "react";

class AddToCart extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      qty: 0,
    };
  }

  render() {
    return (
      <>
        <hr />
        <p>
          <img src="http://www.ftpzero.com/apps/apples.jpg" width="150" />
        </p>
        <p>Apples (3 lb bag)</p>
        <button onClick={() => this.setState({ qty: this.state.qty + 1 })}>
          Add To Cart
        </button>
        <p>QTY IN CART: {this.state.qty}</p>
      </>
    );
  }
}

export default AddToCart;
