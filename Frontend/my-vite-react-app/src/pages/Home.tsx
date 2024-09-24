import { useCallback, useEffect, useMemo, useState } from 'react';
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

const Home = ({ searchQuery }: { searchQuery: string }) => {
  const [products, setProducts] = useState<Product[]>([]);
  const { addToCart } = useCart(); // Get addToCart function from context

  // Function to check if user is logged in
  const isUserLoggedIn = () => {
    const userId = localStorage.getItem("userId");
    return userId !== null; // Check if the user is logged in
  }

  useEffect(() => {
    fetchProducts();
  }, []);

  const fetchProducts = useCallback(async () => {
    try {
      const response = await fetch('http://localhost:5250/api/Products');
      const data: Product[] = await response.json();
      setProducts(data);
    } catch (error) {
      console.error('Error fetching products:', error);
    }
  }, []);

  const filteredProducts = useMemo(() => {
    return products.filter(product =>
      product.name.toLowerCase().includes(searchQuery.toLowerCase())
    );
  }, [products, searchQuery]);

  const ShowInBasket = (product: Product) => {
    if (isUserLoggedIn()) {
      addToCart({ ...product, quantity: 1 }); // Add product to cart with quantity
    } else {
      alert('You need to log in first to add items to the cart.');
    }
  };

  return (
    <main className="home-page-container">
      <h2 className="home-page-title">Witaj w naszym sklepie!</h2>
      <p className="home-page-description">Znajdź najlepsze produkty w najlepszych cenach.</p>

      <div className="product-list-container">
        {filteredProducts.map((product) => (
          <div key={product.id} className="product-card">
            <h3 className="product-name">{product.name}</h3>
            <p className="product-description">{product.description}</p>
            <p className="product-price">Cena: {product.price} PLN</p>
            <button
              onClick={() => ShowInBasket(product)}
              className="product-buy-button"
              disabled={!isUserLoggedIn()} // Disable button if the user is not logged in
            >
              {isUserLoggedIn() ? 'Kup Produkt' : 'Zaloguj się, aby kupić'} {/* Change button text if not logged in */}
            </button>
          </div>
        ))}
      </div>
    </main>
  );
};

export default Home;
