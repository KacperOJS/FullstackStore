import React, { useEffect, useState } from 'react';
import '../styles/Home.css';
import { useCart } from '../context/CartContext'; // Import the useCart hook

interface Product {
  id: number;
  name: string;
  price: number;
  description: string;
  isAvailable: boolean;
  dateTime: string; // Adjust type if needed based on your API response
}

const Home = () => {
  const [products, setProducts] = useState<Product[]>([]);
  const { addToCart } = useCart(); // Get addToCart function from context

  useEffect(() => {
    fetchProducts();
  }, []);

  const fetchProducts = async () => {
    try {
      const response = await fetch('http://localhost:5250/api/Products');
      const data: Product[] = await response.json();
      setProducts(data);
    } catch (error) {
      console.error('Error fetching products:', error);
    }
  };

  const ShowInBasket = (product: Product) => {
    addToCart({ ...product, quantity: 1 }); // Add product to cart with quantity
  };

  return (
    <main className="home-page-container">
      <h2 className="home-page-title">Witaj w naszym sklepie!</h2>
      <p className="home-page-description">Znajdź najlepsze produkty w najlepszych cenach.</p>

      <div className="product-list-container">
        {products.map((product) => (
          <div key={product.id} className="product-card">
            <h3 className="product-name">{product.name}</h3>
            <p className="product-description">{product.description}</p>
            <p className="product-price">Cena: {product.price} PLN</p>
            <div className="product-availability">
              <span className={`availability-dot ${product.isAvailable ? 'available-green' : 'unavailable-red'}`}></span>
              <span>{product.isAvailable ? 'Dostępny' : 'Niedostępny'}</span>
            </div>
            <button onClick={() => ShowInBasket(product)} className="product-buy-button"  disabled={!product.isAvailable} >Kup Produkt</button>
          </div>
        ))}
      </div>
    </main>
  );
};

export default Home;