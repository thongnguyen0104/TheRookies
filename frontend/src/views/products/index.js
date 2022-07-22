import React, { useEffect, useState } from 'react';
import productApi from '../../api/productApi';
import { Link } from 'react-router-dom'
import MyModal from '../../components/myStyle/modal'
import { Table, Navbar, Container, Nav, NavDropdown, Button, Image } from 'react-bootstrap';
import EditProduct from './edit';
const defaultImageSrc = 'https://localhost:7246/Images/1635775567220443732.png';

const Products = () => {

    const [products, setProducts] = useState([]);

    useEffect(() => {
        fetchProduct();
    }, []);

    const fetchProduct = async () => {
        const result = await productApi.getAllAsync()
        setProducts(result);
    }

    const deleteProduct = async (id) => {
        const result = await productApi.deleteAsync(id)
        fetchProduct();
    }

    return (
        <>
            <div style={{ padding: '20px 50px 0px 0px' }}>
                <Link to='/products/create'>
                    <Button>Add</Button>
                </Link>

                <h1>PRODUCTS</h1>
                <Table striped bordered hover size="sm">
                    <thead >
                        <tr>
                            <th>#</th>
                            <th>Name</th>
                            <th>Description</th>
                            <th>Price</th>
                            <th>CreatedDate</th>
                            {/* <th>Updated Date</th> */}
                            <th>Image</th>
                            <th colSpan={2}>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            products.map((item, key) => (
                                <tr key={key}>
                                    <td>{key + 1}</td>
                                    <td style={{ maxWidth: '120px' }}>{item.name}</td>
                                    <td style={{ maxWidth: '350px' }}>{item.description}</td>
                                    <td>{item.price}</td>
                                    <td>

                                        {(new Date(Date.parse(item.createdDate)).getDate()) +
                                            "-" +
                                            (new Date(Date.parse(item.createdDate)).getMonth() +
                                                1) +
                                            "-" +
                                            new Date(
                                                Date.parse(item.createdDate),
                                            ).getFullYear()}
                                    </td>
                                    <td style={{ maxHeight: '50px', maxWidth: '40px' }}>{item.productImages?.length > 0 ? (
                                        <Link to={`/products/${item.id}/updateImage`}>
                                            <Image thumbnail roundedCircle src={item.productImages[0].productPath} />
                                        </Link>

                                    ) :
                                        <Link to={`/products/${item.id}/updateImage`}>
                                            "Don't have any image"
                                        </Link>

                                    }

                                    </td>

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