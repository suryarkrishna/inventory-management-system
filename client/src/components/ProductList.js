import React, { useEffect, useState } from 'react';
import { getProducts } from '../services/api';
import '../ProductList.css'; 

function ProductList() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    getProducts()
      .then(res => setProducts(res.data))
      .catch(err => console.error(err));
  }, []);

  return (
    <div>
      <h2>Product List</h2>
      <div className="product-grid">
        {products.map(p => (
          <div className="product-card" key={p.id}>
            <img 
              src="" 
              alt={p.name} 
              className="product-image"
            />
            <div className="product-name">{p.name}</div>
            <div className="product-price">${p.price}</div>
          </div>
        ))}
      </div>
    </div>
  );
}

export default ProductList;
