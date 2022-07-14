import React, { useState, useEffect } from 'react';
import { useForm, useFieldArray } from 'react-hook-form';
import './uploadImage.scss'
import productImgApi from '../../api/productImgApi'

// import defaultImageSrc from "D:/TheRookies/Economic/Economic.Api/wwwroot/Images/11image1221329729.png";

const UploadImg = () => {


    const { register, handleSubmit } = useForm();

    const onSubmit = async (data) => {
        const formData = new FormData();
        formData.append("ImageFile", data.file[0]);
        formData.append("ProductId", 25);
        formData.append("ProductPath", "baiafui");
        console.log(data);
        // productImgApi.addAsync(formData);
    }

    return (
        <>
        <div><img src={'https://localhost:7246/Images/1635775567220443732.png'}></img></div>
            <div className='container text-center'>
                <p className='lead'>An Employee</p>
            </div>
            <form autoComplete='off' noValidate onSubmit={handleSubmit(onSubmit)}>
                <div className='card'>
                    <img className="form-control-file"></img>
                    <div className='card-body'>
                        <div className='form-group'>
                            <input
                                type='file'
                                accept='image/*'
                                className="form-control"
                                // onChange={showPreview}
                                {...register("file")}
                            />
                        </div>
                        <div className='form-group'>
                            <input
                            />
                        </div>
                        <div className='form-group'>
                            <input
                            />
                        </div>
                        <div className='form-group text-center'>
                            <button type='submit' className='btn btn-light'>Submit</button>
                        </div>
                    </div>
                </div>
            </form>
        </>
    );
}
export default UploadImg