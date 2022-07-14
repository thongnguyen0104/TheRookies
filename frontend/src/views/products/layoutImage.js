import React from "react";
import Employee from "./uploadImage";
import productImgApi from '../../api/productImgApi'

export default function EmployeeList() {

    const addOrEdit = (formData, onSuccess) => {
        console.log(formData)
        const result = productImgApi.addAsync(formData);
        alert("ban da den day")
        console.log(result);
    }

    return (
        <>
            <div className="Row">
                <div className="col-md-12">
                    <div className="jumbotron jubotron-fluid py-4">
                        <div className="container text-center">
                            <h1 className="display-4">Employee Register</h1>
                        </div>
                    </div>
                </div>
                <div className="col-md-4">
                    <Employee
                        addOrEdit={addOrEdit}
                    />
                </div>
                <div className="col-md-8">
                    <div>List of employee records</div>
                </div>
            </div>
        </>
    );
}