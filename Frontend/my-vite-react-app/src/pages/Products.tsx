import React from 'react';
import { useCart } from '../context/CartContext';
import '../styles/Products.css';

const Products: React.FC = () => {
	  // State for daily payment totals
	  const baseUrl = process.env.REACT_APP_BASE_URL || 'http://141.144.237.34:5250'; // Fallback to localhost if not set
  const { cartItems, removeFromCart } = useCart();
  const totalPrice = cartItems.reduce((total, item) => total + item.price * item.quantity, 0);
  const finduserbyid = localStorage.getItem('userId');

  const handlePayment = async () => {
    const lineItems = cartItems.map(item => ({
      priceData: {
        currency: 'PLN',
        productData: {
          name: item.name,
        },
        unitAmount: item.price * 100,
      },
      quantity: item.quantity,
    }));

    try {
      const response = await fetch(`${baseUrl}/api/Payments/create-checkout-session`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({
          lineItems,
          successUrl: `${window.location.origin}/payment-success/`,
          cancelUrl: `${window.location.origin}/payment-cancel/`,
          finduserbyid,
        }),
      });

      if (!response.ok) {
        const errorResponse = await response.json();
        console.error('Failed to create checkout session:', errorResponse.error);
        return;
      }

      const { url } = await response.json();
      window.location.href = url;
    } catch (error) {
      console.error('An error occurred during payment processing:', error);
    }
  };

  return (
    <div className="cart-container">
      <h2>Shopping Cart</h2>
      {cartItems.length === 0 ? (
        <p>No items in the cart.</p>
      ) : (
        <ul className="cart-item-list">
          {cartItems.map(item => (
            <li key={item.id} className="cart-item">
              <span className="cart-item-name">{item.name}</span>
              <span className="cart-item-price">{item.price} PLN</span>
              <span className="cart-item-quantity">x {item.quantity}</span>
              <button 
                className="remove-button" 
                onClick={() => removeFromCart(item.id)}
              >
                Remove
              </button>
            </li>
          ))}
        </ul>
      )}
      {cartItems.length > 0 && (
        <div className="cart-summary">
          <h2>Total Price: {totalPrice} PLN</h2>
          <button onClick={handlePayment} className="pay-button">Proceed to Payment</button>
        </div>
      )}
    </div>
  );
};

export default Products;
