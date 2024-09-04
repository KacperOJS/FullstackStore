import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Header from './Components/Header';
import Footer from './Components/Foooter';
import Home from './pages/Home';
import Products from './pages/Products';
import ProductDetails from './pages/ProductDetails';
import CartPage from './pages/CartPage';
import CheckoutPage from './pages/CheckoutPage';
import { CartProvider } from './context/CartContext';
import './styles/global.css';
import Register from './pages/Register';
import Login from './pages/Login';

function App() {
  return (
    <CartProvider>
      <Router>
        <div className="app">
          <Header />
          <main style={{height:'92vh'}}>
            <Routes>
              <Route path="/" Component={Home} />
              <Route path="/products" Component={Products} />
              <Route path="/products/:id" Component={ProductDetails} />
              <Route path="/cart" Component={CartPage} />
              <Route path="/checkout" Component={CheckoutPage} />
              <Route path="/register" Component={Register} />
				<Route path="/login" Component={Login} />
            </Routes>
          </main>
          <Footer />
        </div>
      </Router>
    </CartProvider>
  );
}

export default App;