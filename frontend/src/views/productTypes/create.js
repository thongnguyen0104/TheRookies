import React, { useState, useEffect } from 'react';
import { Container } from 'react-bootstrap';
import Button from 'react-bootstrap/Button';
import Col from 'react-bootstrap/Col';
import Form from 'react-bootstrap/Form';
import Row from 'react-bootstrap/Row';
import Sidebar from '../../components/sidebar/Sidebar';
import productTypeApi from '../../api/productTypeApi';
import { useForm } from 'react-hook-form';
import { useNavigate } from 'react-router-dom';

function CreateProuctType() {

    const navigate = useNavigate();

    const {
        register,
        handleSubmit,
        watch,
        formState: { errors }
    } = useForm();

    const onSubmit = async (content) => {
        var data = await productTypeApi.addAsync(content);
        console.log(data)
        if (data !== "") {
            alert("Da tao thanh cong!");
            navigate(-1);
        }
    }

    return (
        <>
            <div style={{ padding: '0px 0px 0px 370px' }}>
                <Sidebar />
            </div>
            <Container>
                <Form onSubmit={handleSubmit(onSubmit)}>
                    <Row className="mb-3">
                        <Form.Group as={Col} md="4" controlId="validationCustom01">
                            <Form.Label>Product name</Form.Label>
                            <Form.Control
                                type="text"
                                placeholder="Product type name"
                                defaultValue="Product name"
                                {...register('name')}
                            />
                            <Form.Control.Feedback>Looks good!</Form.Control.Feedback>
                        </Form.Group>
                        <Form.Group as={Col} md="4" controlId="validationCustom02">
                            <Form.Label>Description</Form.Label>
                            <Form.Control
                                type="text"
                                placeholder="Description"
                                defaultValue="Description"
                                {...register('description')}
                            />
                            <Form.Control.Feedback>Looks good!</Form.Control.Feedback>
                        </Form.Group>
                    </Row>
                    <Button type="submit">Submit form</Button>
                </Form>
            </Container>
        </>
    );
}

export default CreateProuctType