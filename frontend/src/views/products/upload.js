import React, { useState, useEffect } from 'react';
import { useForm, useFieldArray, useWatch } from 'react-hook-form';
import productImgApi from '../../api/productImgApi'
import { useNavigate, useParams } from "react-router-dom";
import { Button, Form } from 'react-bootstrap';

const UploadImg = (props) => {
    const [isChanged, setIsChanged] = useState(false);
    const [productImages, setProductImages] = useState([{}]);
    const goback = useNavigate();
    const { id } = useParams();
    const { register, control, handleSubmit, reset } = useForm({
        defaultValues: {
            Images: productImages?.map((image) => {
                return {
                    productId: image.productId,
                    ImageFile: "",
                }
            })
        }
    });
    const { append } = useFieldArray({
        control,
        name: "Images",
      });
    const watchImage = useWatch({
        control,
        name: "Images",
    });

    function onUpdateChange() {
        var result = false;

        if (watchImage) {
            result = watchImage.some(
                (image, index) =>
                    image?.ImageFile !== "",
            );
        }
        setIsChanged(result);
    }

    const onSubmit = async (data) => {
        var isUploadSuccess = true;
        if (data && props.productId) {
            if (data.Images?.length > 0) {

                data.Images.forEach(async (image, index) => {
                    const formData = new FormData();
                    formData.append(
                        "ImageFile",
                        image.ImageFile !== "" ? image.ImageFile[0] : null,
                    );
                    formData.append("ProductId", id);
                    formData.append("Id", productImages[index].id);
                    const result = productImgApi.updateAsync(formData);
                    console.log(productImages[index].id);
                    if (!result) {
                        isUploadSuccess = false;
                    }
                })
            }
        }
        if (isUploadSuccess) {
            alert("Update product image successfully");
            goback(-1);
        }
    }

    useEffect(() => {
        onUpdateChange(); // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [watchImage]);

    useEffect(() => {
        if (props.productImages) {
            setProductImages(props.productImages);
            reset({
                Images: productImages?.map((image) => {
                    return {
                        productId: image.productId,
                        ImageFile: "",
                    };
                }),
            });
        }
    }, [props]);

    return (
        <>
            <div className='container text-center'>
                <p className='lead'>Upload Image</p>
            </div>
            <Form autoComplete='off' noValidate onSubmit={handleSubmit(onSubmit)}>
                <div className='card'>
                    <img className="form-control-file"></img>
                    <div className='card-body'>
                        <Button variant="secondary"
                            onClick={() => append({ file: "" })}
                        >
                            AddImage
                        </Button>
                        {productImages.map((image, index) => (
                            <Form.Group className='form-group' key={index}>
                                <input
                                    type='file'
                                    accept='image/*'
                                    className="form-control"
                                    {...register(`Images.${index}.ImageFile`)}
                                />
                            </Form.Group>
                        ))}
                        <br></br>
                        <div className='form-group text-center'>
                            <Button type='submit' disabled={!isChanged}>Submit</Button>
                        </div>
                    </div>
                </div>
            </Form>
        </>
    );
}
export default UploadImg