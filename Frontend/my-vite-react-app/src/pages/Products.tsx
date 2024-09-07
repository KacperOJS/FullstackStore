import React from 'react';
import { useCart } from '../context/CartContext';
import { useNavigate } from 'react-router-dom'; // Import useNavigate for redirection
import '../styles/Products.css'; // Import your CSS file for styling

const Products: React.FC = () => {
  const { cartItems } = useCart();
  const navigate = useNavigate(); // Initialize useNavigate

  // Calculate total price
  const totalPrice = cartItems.reduce((total, item) => total + item.price * item.quantity, 0);

  const handlePayment = () => {
    navigate('/payments'); // Redirect to payments page
  };

  return (
    <div className="cart-container">
      <h1>Cart Items</h1>
      {cartItems.length === 0 ? (
        <p>No items in the cart.</p>
      ) : (
        <ul className="cart-item-list">
          {cartItems.map(item => (
            <li key={item.id} className="cart-item">
              <span className="cart-item-name">{item.name}</span>
              <span className="cart-item-price">{item.price} PLN</span>
              <span className="cart-item-quantity">x {item.quantity}</span>
            </li>
          ))}
        </ul>
      )}
      {cartItems.length > 0 && (
        <div className="cart-summary">
          <h2>Total Price: {totalPrice} PLN</h2>
          <button onClick={handlePayment} className="pay-button">Pay</button>
        </div>
      )}
    </div>
  );
};

export default Products;