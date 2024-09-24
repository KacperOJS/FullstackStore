// import React, { useEffect, useRef } from 'react';

// // Define the expected shape of the order object returned by PayPal
// interface PayPalOrder {
//   id: string;
//   purchase_units: Array<{
//     amount: {
//       value: string;
//     };
//   }>;
//   status: string;
// }

// const PayPalButton: React.FC = () => {
//   const paypalRef = useRef<HTMLDivElement>(null); // Reference to the PayPal button container

//   useEffect(() => {
//     // Load the PayPal script
//     const loadPayPalScript = () => {
//       return new Promise<void>((resolve) => {
//         const script = document.createElement('script');
//         script.src = 'https://www.paypal.com/sdk/js?client-id=YOUR_CLIENT_ID'; // Replace with your client ID
//         script.async = true;
//         script.onload = () => resolve(); // Resolve the promise when the script loads
//         document.body.appendChild(script);
//       });
//     };

//     const renderPayPalButton = async () => {
//       await loadPayPalScript(); // Wait for the script to load

//       if (paypalRef.current && window.paypal) {
//         window.paypal.Buttons({
//           createOrder: (data: any, actions: any) => {
//             return actions.order.create({
//               purchase_units: [{
//                 amount: {
//                   value: '10.00', // Payment amount
//                 },
//               }],
//             });
//           },
//           onApprove: async (data: any, actions: any) => {
//             const order: PayPalOrder = await actions.order.capture();
//             console.log('Payment completed successfully!', order);

//             // Send order data to backend
//             const response = await fetch('http://localhost:5250/api/payments/create', {
//               method: 'POST',
//               headers: {
//                 'Content-Type': 'application/json',
//               },
//               body: JSON.stringify({
//                 orderID: order.id,
//                 amount: order.purchase_units[0].amount.value,
//                 status: order.status,
//               }),
//             });

//             if (!response.ok) {
//               console.error('Error saving payment on backend');
//             }
//           },
//           onError: (err: any) => {
//             console.error('An error occurred during the payment:', err);
//           },
//         }).render(paypalRef.current); // Render the PayPal button inside the ref
//       }
//     };

//     renderPayPalButton();
//   }, []);

//   return <div ref={paypalRef}></div>; // Attach ref to the div
// };

// export default PayPalButton;
