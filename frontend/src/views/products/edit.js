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
import { yupResolver } from '@hookform/resolvers/yup';
import * as Yup from "yup";
import productApi from '../../api/productApi';
import { END_POINT } from '../../api/endPoint';
import UploadImg from './upload';

function EditProductType() {
  var { id } = useParams();
  const navigate = useNavigate();

  const [productTypes, setProductTypes] = useState([]);

  const [product, setProduct] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    const productTypes = await productTypeApi.getAllAsync()
    setProductTypes(productTypes);
    const product = await productApi.getByIdAsync(id)
    setProduct(product);
  }

  const {
    register,
    handleSubmit,
    formState: { errors }
  } = useForm();

  const onSubmit = async (content) => {
    var result = await productApi.updateAsync(content);
    if (result !== 0) {
      alert("Da update san pham thanh cong");
      navigate(-1);
    }

  }

  return (
    <>
      <div style={{ padding: '50px 50px 0px 0px' }}>
        <h1>Update Product</h1>
        <Container>
          <Form onSubmit={handleSubmit(onSubmit)}>
            <Row className="mb-3">
              <Form.Group as={Col} md="4" controlId="validationCustom01">
                <Form.Label>Product name</Form.Label>
                <Form.Control
                  type="text"
                  placeholder={product.name}
                  defaultValue={product.name}
                  {...register('name')}
                />
                <Form.Control.Feedback>Looks good!</Form.Control.Feedback>
              </Form.Group>
              <Form.Group as={Col} md="4" controlId="validationCustom02">
                <Form.Label>Description</Form.Label>
                <Form.Control
                  type="text"
                  placeholder={product.description}
                  defaultValue={product.description}
                  {...register('description')}
                />
                <Form.Control.Feedback>Looks good!</Form.Control.Feedback>
              </Form.Group>
            </Row>
            <Row className="mb-3">
              <Form.Group as={Col} md="4" controlId="validationCustom03">
                <Form.Label>Price</Form.Label>
                <Form.Control
                  type="number"
                  placeholder={product.price}
                  defaultValue={product.price}
                  {...register('price')}
                />
                <Form.Control.Feedback type="invalid">
                  Please provide a valid city.
                </Form.Control.Feedback>
              </Form.Group>
              <Form.Group as={Col} md="4" controlId="validationCustom04">
                <Form.Label>ProductTypes</Form.Label>
                <select
                  className="form-control-alternative form-control"
                  id="input-category"
                  type="select"
                  {...register("productTypeId")}
                  defaultValue=""
                >
                  <option value="" disabled>
                    {product.productTypeName}
                  </option>
                  {productTypes.map((productType, key) => (
                    <option key={key} value={productType.id}>
                      {productType.name}
                    </option>
                  ))}
                </select>
              </Form.Group>
            </Row>
            <Button type="submit">Update</Button>
          </Form>
          {product.productImages && (
            <UploadImg
              productId= {id}
              productImages={product.productImages} />
          )}
        </Container>
      </div>
    </>
  );
}

export default EditProductType