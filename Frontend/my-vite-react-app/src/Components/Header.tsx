import { Link } from 'react-router-dom'
import '../styles/Header.css'
import { useCart } from '../context/CartContext'

const Header = () => {
  const { cartItems } = useCart();
  const cartItemCount = cartItems.reduce((total, item) => total + item.quantity, 0);

  return (
    <header className="header">
      <div className="container">
        <h1 className="logo">FPS-Shop</h1>
        <nav>
          <ul className="nav-list">
            <li><Link to="/" className="nav-link">Strona główna</Link></li>
            <li><Link to="/produkty" className="nav-link">Produkty</Link></li>
            <li><Link to="/kontakt" className="nav-link">Kontakt</Link></li>
            <li><Link to="/Login" className="nav-link nav-button">Logowanie</Link></li>
            <li><Link to="/Register" className="nav-link nav-button nav-button-primary">Rejestracja</Link></li>
            <li>
              <Link to="/koszyk" className="nav-link cart-icon">
                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round">
                  <circle cx="9" cy="21" r="1"></circle>
                  <circle cx="20" cy="21" r="1"></circle>
                  <path d="M1 1h4l2.68 13.39a2 2 0 0 0 2 1.61h9.72a2 2 0 0 0 2-1.61L23 6H6"></path>
                </svg>
                {cartItemCount > 0 && <span className="cart-count">{cartItemCount}</span>}
              </Link>
            </li>
          </ul>
        </nav>
      </div>
    </header>
  )
}

export default Header