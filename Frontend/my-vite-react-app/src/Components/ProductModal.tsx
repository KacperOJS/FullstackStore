
import './Modal.css'; // Add your modal styles here

const ProductModal = ({ products, onClose }:any) => {
    return (
        <div className="modal-overlay">
            <div className="modal-content">
                <button onClick={onClose}>Close</button>
                <h2>Filtered Products</h2>
                {products.length > 0 ? (
                    products.map((product:any) => (
                        <div key={product.id}>
                            <h3>{product.name}</h3>
                            <p>{product.description}</p>
                        </div>
                    ))
                ) : (
                    <p>No products found.</p>
                )}
            </div>
        </div>
    );
};

export default ProductModal;
