import React, { useState } from 'react';
import PRODUCTS from './ProductsState';
import ProductItem from './ProductItem';
import styles from '/ProductsItem.module.css';

const ProductsList: React.FC = () => {
const [searchTerm, setSearchTerm] = useState('');
const filteredProducts = PRODUCTS.filter((product) =>
product.name.toLowerCase().includes(searchTerm.toLowerCase())
);

return (
<div>
<input
type="text"
placeholder="Search Products"
value={searchTerm}
onChange={(e) => setSearchTerm(e.target.value)}
className={styles.searchInput}
/>
<ul className={styles.productList}>
{filteredProducts.map((product) => (
<ProductItem key={product.id} product={product} />
))}
</ul>
</div>
);
};

export default ProductsList;

