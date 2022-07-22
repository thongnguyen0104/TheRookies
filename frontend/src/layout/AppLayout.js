import { Outlet } from "react-router-dom";
import React from 'react'
import Sidebar from "../components/sidebar/Sidebar";
import Products from "../views/products";
import ProductTypes from "../views/productTypes/index.js";
import FormExample from "../views/products/create"

import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Blank from '../views/pages/Blank';
import EditProduct from '../views/products/edit';
import CreateProuctType from '../views/productTypes/create'
import Users from "../views/users/index";
import EditProductType from '../views/productTypes/edit'
import UploadImg from '../views/products/uploadImage';

const AppLayout = () => {
    return (
        <>
            <div style={{ padding: '0px 0px 0px 370px' }}>
                <Sidebar />
                <Outlet />
            </div>
            <div style={{ padding: '50px 100px 0px 370px' }}>

            </div>
        </>
    );
};

export default AppLayout;
