import React, { useState, useEffect } from 'react';
import { Container } from 'react-bootstrap';
import Button from 'react-bootstrap/Button';
import Col from 'react-bootstrap/Col';
import Form from 'react-bootstrap/Form';
import Row from 'react-bootstrap/Row';
import Sidebar from '../../components/sidebar/Sidebar';
import productTypeApi from '../../api/productTypeApi';
import { useNavigate, useParams } from "react-router-dom";
import { useForm } from 'react-hook-form';

function EditProductType() {

  var { id } = useParams();
  const navigate = useNavigate();

  const [productType, setProductType] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    const productType = await productTypeApi.getByIdAsync(id)
    setProductType(productType);
  }

  const {
    register,
    handleSubmit,
    formState: { errors }
  } = useForm();

  const onSubmit = async (content) => {
    content.id = id
    var result = await productTypeApi.updateAsync(content);
    console.log(result);
    if(result !== 0) {
      alert("Da update loai san pham thanh cong!");
      navigate(-1);
    }
  }

  return (
    <>
      <div style={{ padding: '0px 0px 0px 370px' }}>
        <Sidebar />
      </div>
      <div style={{ padding: '50px 50px 0px 0px' }}>
      <Container>
        <Form onSubmit={handleSubmit(onSubmit)}>
          <Row className="mb-3">
            <Form.Group as={Col} md="4" controlId="validationCustom01">
              <Form.Label>Product name</Form.Label>
              <Form.Control
                type="text"
                // placeholder={product.name}
                defaultValue={productType.name}
                {...register('name')}
              />
              <Form.Control.Feedback>Looks good!</Form.Control.Feedback>
            </Form.Group>
            <Form.Group as={Col} md="4" controlId="validationCustom02">
              <Form.Label>Description</Form.Label>
              <Form.Control
                type="text"
                defaultValue={productType.description}
                {...register('description')}
              />
              <Form.Control.Feedback>Looks good!</Form.Control.Feedback>
            </Form.Group>
          </Row>
          <Button type="submit">Submit form</Button>
        </Form>
      </Container>
      </div>
    </>
  );
}

export default EditProductType