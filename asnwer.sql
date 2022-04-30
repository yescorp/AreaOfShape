SELECT * from product
JOIN product_category on product.product_id = product_category.product_id
JOIN category on category.category_id = product_category.category_id
