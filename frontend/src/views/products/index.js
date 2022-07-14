import React, { useEffect, useState } from 'react';
import productApi from '../../api/productApi';
import { Link } from 'react-router-dom'
import MyModal from '../../components/myStyle/modal'
import { Table, Navbar, Container, Nav, NavDropdown, Button } from 'react-bootstrap';
import EditProduct from './edit';

// import imgPath from '../../../public/img/products';
// import { Button } from 'bootstrap';

const Products = () => {

    const [products, setProducts] = useState([]);

    useEffect(() => {
        fetchProduct();
    }, []);

    const fetchProduct = async () => {
        const result = await productApi.getAllAsync()
        setProducts(result);
        console.log(products);
    }

    const deleteProduct = async (id) => {
        const result = await productApi.deleteAsync(id)
        fetchProduct();
        console.log(result)
    }


    return (
        <>
        <div style={{ padding: '20px 50px 0px 0px' }}>
            <Link to='/products/create'>
                <Button color='red'>Add</Button>
            </Link>
            <h1>PRODUCTS</h1>
            <Table striped bordered hover>
                <thead >
                    <tr>
                        <th>#</th>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Price</th>
                        <th>Created Date</th>
                        <th>Updated Date</th>
                        <th>Image</th>
                        <th>Edit</th>
                        <th>Delete</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        products.map((item, key) => (
                            <tr key={key}>
                                <td>{key + 1}</td>
                                <td>{item.name}</td>
                                <td>{item.description}</td>
                                <td>{item.price}</td>
                                <td>{item.createdDate}</td>
                                <td>{item.updatedDate}</td>
                                <td>fguiw</td>
                                <td>
                                    <Link
                                        to={`/products/${item.id}/edit`}
                                    >
                                        <Button
                                            variant="warning"
                                        >
                                            <i className='bx bx-edit'></i></Button>
                                    </Link>
                                </td>
                                <td>
                                    <Button
                                        variant="danger"
                                        onClick={() => {
                                            let check = window.confirm("Ban co chac xoa?")
                                            // alert(check)
                                            if (check)
                                                deleteProduct(item.id)
                                        }
                                        }
                                    >
                                        <i className='bx bx-x'></i></Button>
                                </td>

                            </tr>
                        ))
                    }
                </tbody>
            </Table>
            </div>
        </>
    )
}

export default Products;