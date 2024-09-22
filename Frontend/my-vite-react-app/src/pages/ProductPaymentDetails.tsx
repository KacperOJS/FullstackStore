import { useCart } from '../context/CartContext';
import '../styles/PaymentDetails.css';

const PaymentDetails: React.FC = () => {
  const { cartItems } = useCart();
  const totalPrice = cartItems.reduce((total, item) => total + item.price * item.quantity, 0);
  const findUserById = localStorage.getItem('userId');

  const handlePayment = async (paymentMethod: string) => {
    // Map cartItems to the structure required by your payment processor
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
      const response = await fetch('http://localhost:5250/api/Payments/create-checkout-session', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({
          lineItems,
          paymentMethod,
          successUrl: `${window.location.origin}/payment-success/`,
          cancelUrl: `${window.location.origin}/payment-cancel/`,
          findUserById,
        }),
      });

      if (!response.ok) {
        const errorResponse = await response.json();
        console.error('Failed to create checkout session:', errorResponse.error);
        return;
      }

      const { url } = await response.json();
      // Redirect to the payment processor
      window.location.href = url;

    } catch (error) {
      console.error('An error occurred during payment processing:', error);
    }
  };

  return (
    <div className="payment-details-container">
      <h1>Payment Options</h1>
      <h2>Total Price: {totalPrice} PLN</h2>

      <div className="payment-methods">
        <div className="payment-method" onClick={() => handlePayment('stripe')}>
          <img src="/images/stripe-logo.png" alt="Stripe" />
          <span>Pay with Stripe</span>
        </div>
        <div className="payment-method" onClick={() => handlePayment('paypal')}>
          <img src="/images/paypal-logo.png" alt="PayPal" />
          <span>Pay with PayPal</span>
        </div>
        <div className="payment-method" onClick={() => handlePayment('bitcoin')}>
          <img src="/images/bitcoin-logo.png" alt="Bitcoin" />
          <span>Pay with Bitcoin</span>
        </div>
      </div>
    </div>
  );
};

export default PaymentDetails;
