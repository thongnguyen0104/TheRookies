import React, { useEffect, useState } from 'react';
import userApi from '../../api/userApi';

import { Table } from 'react-bootstrap';

// import { Button } from 'bootstrap';

const Users = () => {

    const [users, setUsers] = useState([]);

    useEffect(() => {
        fetchData();
    }, []);

    const fetchData = async () => {
        setUsers(await userApi.getAllAsync());
        // const data = getProducts();
        console.log(users);
    }

    return (
        <>
            <div style={{ padding: '20px 50px 0px 0px' }}>
                <h1>USERS</h1>
                <Table striped bordered hover>
                    <thead >
                        <tr>
                            <th>#</th>
                            <th>Name</th>
                            <th>Address</th>
                            <th>Email</th>
                            <th>UserName</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            users.map((item, key) => (
                                <tr key={key}>
                                    <td>{key + 1}</td>
                                    <td>{item.name}</td>
                                    <td>{item.address}</td>
                                    <td>{item.email}</td>
                                    <td>{item.userName}</td>
                                </tr>
                            ))
                        }
                    </tbody>
                </Table>
            </div>
        </>
    )
}

export default Users;