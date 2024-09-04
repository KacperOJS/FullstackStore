import React from 'react'
import '../styles/Footer.css'

const Footer = () => {
  return (
    <footer className="footer">
      <div className="container">
        <p>&copy; 2024 Mój Sklep. Wszelkie prawa zastrzeżone.</p>
        <div className="links">
          <a href="#" className="footer-link">Polityka prywatności</a>
          <a href="#" className="footer-link">Regulamin</a>
        </div>
      </div>
    </footer>
  )
}

export default Footer