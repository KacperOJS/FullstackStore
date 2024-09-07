import React from 'react';
import { useCart } from '../context/CartContext';
import { useNavigate } from 'react-router-dom';
import { CardElement, useStripe, useElements } from '@stripe/react-stripe-js';
import '../styles/Products.css';

const Products: React.FC = () => {
  const { cartItems } = useCart();
  const navigate = useNavigate();
  const stripe = useStripe();
  const elements = useElements();

  const totalPrice = cartItems.reduce((total, item) => total + item.price * item.quantity, 0);

  const handlePayment = async () => {
    if (!stripe || !elements) {
      return;
    }

    const cardElement = elements.getElement(CardElement);
    if (!cardElement) {
      console.error('CardElement not found');
      return;
    }

    // Create a payment method
    const { error: paymentMethodError, paymentMethod } = await stripe.createPaymentMethod({
      type: 'card',
      card: cardElement,
    });

    if (paymentMethodError) {
      console.error('Payment method error:', paymentMethodError);
      return;
    }

    // Send payment method ID to your server
    const response = await fetch('/api/payments/create-payment-intent', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({
        amount: totalPrice * 100, // Convert to cents for Stripe
        paymentMethodId: paymentMethod.id, // Send the payment method ID
      }),
    });

    if (!response.ok) {
      const errorResponse = await response.json();
      console.error('Failed to create payment intent:', errorResponse.error);
      return;
    }

    const { clientSecret } = await response.json();

    // Confirm the payment
    const { error } = await stripe.confirmCardPayment(clientSecret, {
      payment_method: paymentMethod.id,
    });

    if (error) {
      console.error('Payment failed:', error);
    } else {
      console.log('Payment succeeded');
      navigate('/payment-success'); // Redirect on success
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