import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Header from './Components/Header';
import Footer from './Components/Foooter';
import Home from './pages/Home';
import Products from './pages/Products';
import ProductDetails from './pages/ProductPaymentDetails';
import CartPage from './pages/CartPage';
import CheckoutPage from './pages/CheckoutPage';
import { CartProvider } from './context/CartContext';
import './styles/global.css';
import Register from './pages/Register';
import Login from './pages/Login';
import Dashboard from './pages/Dashboard';
import ProtectedRoute from './pages/ProtectedRoute';
import PaymentSuccess from './pages/payment-success';
import { loadStripe } from '@stripe/stripe-js';
import { Elements } from '@stripe/react-stripe-js';
import Paymentcancel from './pages/payment-cancel';
import AdminPage from './pages/AdminPage';
import { useState } from 'react';
import Contact from './pages/Contact';
import About from './pages/AboutPage';


const stripePromise = loadStripe('pk_test_51PfPjHRp6D9QDtZzHJa3oQEsr9HQA8f6XMiGqe3NxRBkPz3xaXrqsu9BlNnPefMeVxYuk55GKDMJsEXD9kK0gNlA007x6gK31v');

function App() {
	const [searchQuery, setSearchQuery] = useState('');
  return (
    <Elements stripe={stripePromise}>
      <CartProvider>
        <Router>
          <div className="app">
            <Header setSearchQuery={setSearchQuery} />
            <main style={{ minHeight: 'calc(100vh - 150px)' }}> {/* Adjust height based on header and footer sizes */}
              <Routes>
                <Route path="/" element={<Home searchQuery={searchQuery} />} />
                <Route path="/kontakt" element={<Contact />} />
                <Route path="/products" element={<Products />} />
                <Route path="/about" element={<About />} />
                <Route path="/products/PaymentDetails" element={<ProductDetails />} />
                <Route path="/cart" element={<CartPage />} />
                <Route path="/checkout" element={<CheckoutPage />} />
                <Route path="/register" element={<Register />} />
                <Route path="/login" element={<Login />} />
                <Route path="/payment-success" element={<PaymentSuccess />} />
                <Route path="/payment-cancel" element={<Paymentcancel />} />
                <Route element={<ProtectedRoute />}>
                  <Route path="/dashboard" element={<Dashboard />} />
                  <Route path="/adminPanel" element={<AdminPage />} />
                  {/* Add more protected routes here */}
                </Route>
              </Routes>
            </main>
            <Footer />
          </div>
        </Router>
      </CartProvider>
    </Elements>
  );
}

export default App;
