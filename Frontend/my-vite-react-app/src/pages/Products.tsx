import React from 'react';
import { useCart } from '../context/CartContext';
import { loadStripe } from '@stripe/stripe-js';
import '../styles/Products.css';

// Initialize Stripe with your public key
const stripePromise = loadStripe('pk_test_51PfPjHRp6D9QDtZzNPBnPe1zJnxgu1fkpV7xE6l0kDJ0FAiHJNwbdT39T1CMrMVYtXov62LOADJLubZ5SbKVkhbi00KxUOuqH'); // Replace with your public key

const Products: React.FC = () => {
  const { cartItems } = useCart();
  const totalPrice = cartItems.reduce((total, item) => total + item.price * item.quantity, 0);

  const handlePayment = async () => {
    const stripe = await stripePromise;

    // Map cartItems to the structure required by Stripe
    const lineItems = cartItems.map(item => ({
      price_data: {
        currency: 'pln',
        product_data: {
          name: item.name,
        },
        unit_amount: item.price * 100, // Stripe expects the amount in cents
      },
      quantity: item.quantity,
    }));

    try {
      const response = await fetch('http://localhost:5250/api/Payments/create-checkout-session', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({
          lineItems,
          successUrl: `${window.location.origin}/payment-success`,
          cancelUrl: `${window.location.origin}/payment-cancel`,
        }),
      });

      if (!response.ok) {
        const errorResponse = await response.json();
        console.error('Failed to create checkout session:', errorResponse.error);
        return;
      }

      const { url } = await response.json();
      // Redirect to Stripe Checkout
      window.location.href = url;

    } catch (error) {
      console.error('An error occurred during payment processing:', error);
    }
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
