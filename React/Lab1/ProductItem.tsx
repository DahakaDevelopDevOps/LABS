import React from 'react';
import { Product } from './types';
import styles from './ProductItem.module.css';

type Props = {
product: Product;
};

const ProductItem: React.FC<Props> = ({ product }) => {
return (
<li className={styles.productItem}>
<span className={styles.productName}>{product.name}</span>
<span className={styles.productPrice}>{product.price}</span>
</li>
);
};

export default ProductItem;