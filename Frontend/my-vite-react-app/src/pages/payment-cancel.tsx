import React from 'react';
import { useNavigate } from 'react-router-dom'; // Import useNavigate for navigation
import '../styles/PaymentCancel.css'; // Import any necessary CSS

const PaymentCancel: React.FC = () => {
  const navigate = useNavigate();

  const handleReturn = () => {
    navigate('/', { replace: true } ); // Change this to the route you want to navigate to
  };

  return (
    <div className="payment-cancel-container">
      <h1 className="cancel-title">Payment Cancelled</h1>
      <p className="cancel-message">
        Your payment was not completed. If you have any questions, please contact support.
      </p>
      <button className="btn-return" onClick={handleReturn}>
        Go to Dashboard
      </button>
    </div>
  );
};

export default PaymentCancel;
