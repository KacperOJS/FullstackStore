import React from 'react';
import { useNavigate } from 'react-router-dom'; // Updated to use useNavigate instead of useHistory
import '../styles/PaymentSuccess.css'; // Import any necessary CSS

const PaymentSuccess: React.FC = () => {
  const navigate = useNavigate(); // Updated to use useNavigate

  const handleReturn = () => {
    navigate('/'); // Change this to the route you want to navigate to
  };

  return (
    <div className="payment-success-container">
      <h1 className="success-title">Payment Successful!</h1>
      <p className="success-message">
        Thank you for your purchase! Your payment has been processed successfully.
      </p>
      <button className="btn-return" onClick={handleReturn}>
        Go to Dashboard
      </button>
    </div>
  );
};

export default PaymentSuccess;
