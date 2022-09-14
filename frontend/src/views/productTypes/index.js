import React, { useEffect, useState } from 'react';
import productTypeApi from '../../api/productTypeApi';
import { Link } from 'react-router-dom'

import { Table, Button } from 'react-bootstrap';

function ProductTypes() {

    const [productTypes, setProductTypes] = useState([]);

    useEffect(() => {
        fetchData();
    }, []);

    const fetchData = async () => {
        setProductTypes(await productTypeApi.getAllAsync());
    }

    const deleteProductType = async (id) => {
        const result = await productTypeApi.deleteAsync(id)
        fetchData();
    }

    return (
        <>
            <div style={{ padding: '20px 50px 0px 0px' }}>
                <Link to='/producttypes/create'>
                    <Button color='red'>Add</Button>
                </Link>
                <h1>PRODUCT TYPE</h1>
                <Table striped bordered hover>
                    <thead >
                        <tr>
                            <th>#</th>
                            <th>Name</th>
                            <th>Description</th>
                            <th>Edit</th>
                            <th>Update</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            productTypes.map((item, key) => (
                                <tr key={key}>
                                    <td>{key + 1}</td>
                                    <td>{item.name}</td>
                                    <td>{item.description}</td>
                                    <td>
                                        <Link
                                            to={`/producttypes/${item.id}/edit`}
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
                                                if (check)
                                                    deleteProductType(item.id)
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

export default ProductTypes;