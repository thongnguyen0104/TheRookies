import logo from './logo.svg';
import React from 'react'

import { BrowserRouter, Routes, Route } from 'react-router-dom';
import AppLayout from './layout/AppLayout';
import Blank from './views/pages/Blank';
import Products from './views/products';
import ProductTypes from './views/productTypes/index.js';
import Users from './views/users';
import FormExample from './views/products/create'
import EditProduct from './views/products/edit';
import CreateProuctType from './views/productTypes/create'
import EditProductType from './views/productTypes/edit'
import UploadImg from './views/products/upload';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<AppLayout />}>
          <Route index element={<Blank />} />
          <Route path='/products' element={<Products />} />
          <Route path='/producttypes' element={<ProductTypes />} />
          <Route path='/producttypes/create' element={<CreateProuctType />} />
          <Route path='/producttypes/:id/edit' element={<EditProductType />} />
          <Route path='/users' element={<Users />} />
          <Route path='/products/create' element={<FormExample />} />
          <Route path='/products/:id/edit' element={<EditProduct />} />
          <Route path='/products/:id/updateImage' element={<UploadImg />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
