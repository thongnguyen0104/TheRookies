import React, { useState, useEffect } from 'react';
import { useForm, useFieldArray } from 'react-hook-form';
import { Container } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import Button from 'react-bootstrap/Button';
import Col from 'react-bootstrap/Col';
import Form from 'react-bootstrap/Form';
import Row from 'react-bootstrap/Row';
import Sidebar from '../../components/sidebar/Sidebar';
import productImgApi from '../../api/productImgApi'

import productTypeApi from '../../api/productTypeApi';
import productApi from '../../api/productApi';

function FormExample() {
  const { id } = useParams();
  const navigate = useNavigate();
  const {
    register,
    handleSubmit,
    control,
    watch,
    formState: { errors }
  } = useForm();
  const { fields, append } = useFieldArray({
    control,
    name: "Images",
  });

  const onSubmit = async (content) => {
    var data = await productApi.addAsync(content);
    var isUploadSuccess = true;
    if (data) {
      content.Images.forEach(async (image) => {
        const id = data.id;
        const formData = new FormData();
        formData.append("ImageFile", image.ImageFile[0]);
        formData.append("ProductId", id);
        const result = productImgApi.addAsync(formData);
        console.log(result);
        console.log(typeof (result))
        if (!result) {
          var isUploadSuccess = false;
        }
      })
    }
    if (data && isUploadSuccess) {
      alert("Da tao thanh cong!");
      navigate(-1);
    }
  }

  const [productTypes, setProductTypes] = useState([]);

  useEffect(() => {
    fetchData();
  }, []);

  const fetchData = async () => {
    const result = await productTypeApi.getAllAsync();
    setProductTypes(result);
  }

  return (
    <>
      <div style={{ padding: '50px 50px 0px 0px' }}>
        <h1>Add Product</h1>
        <Container>
          <Form onSubmit={handleSubmit(onSubmit)}>
            <Row className="mb-3">
              <Form.Group as={Col} md="4" controlId="validationCustom01">
                <Form.Label>Product name</Form.Label>
                <Form.Control
                  type="text"
                  placeholder="Product name"
                  defaultValue="Product name"
                  {...register('name')}
                />
                <Form.Control.Feedback>Looks good!</Form.Control.Feedback>
              </Form.Group>
              <Form.Group as={Col} md="4" controlId="validationCustom02">
                <Form.Label>Description</Form.Label>
                <Form.Control
                  type="text"
                  placeholder="description"
                  defaultValue="description"
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
                  placeholder="City"
                  {...register('price')}
                />
                <Form.Control.Feedback type="invalid">
                  Please provide a valid city.
                </Form.Control.Feedback>
              </Form.Group>
              <Form.Group as={Col} md="4" controlId="validationCustom04">
                <Form.Label>ProductTypes</Form.Label>
                <select required custom
                  className="form-control-alternative form-control"
                  id="input-category"
                  type="select"
                  {...register("productTypeId")}
                  defaultValue=""
                >
                  <option value="" disabled>
                    Select one
                  </option>
                  {productTypes.map((productType, key) => (
                    <option key={key} value={productType.id}>
                      {productType.name}
                    </option>
                  ))}
                </select>
              </Form.Group>
            </Row>
            <Row>
              <div className='card-body'>
                <Button variant="secondary"
                  onClick={() => append({ file: "" })}
                >
                  AddImage
                </Button>
                <br></br>
                {fields.map((image, index) => (
                  <Form.Group as={Col} md="4" className='form-group' key={image.id}>
                    <Form.Control
                      type='file'
                      accept='image/*'
                      className="form-control"
                      {...register(`Images.${index}.ImageFile`)}
                    />
                  </Form.Group>
                ))}
              </div>
            </Row>
            <Button type="submit">Submit form</Button>
          </Form>
        </Container>
      </div>
    </>
  );
}

export default FormExample