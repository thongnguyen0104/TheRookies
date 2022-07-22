import { END_POINT } from "./endPoint";
import axios from "axios";

const API = axios.create({
    baseURL: process.env.REACT_APP_URL_API,
    timeout: 300000,
    headers: {
        "Content-type": "multipart/form-data",
    },
});

API.interceptors.response.use(
    (respose) => {
        return respose.data
    },
    (error) => {
        console.log(error);
    }
)

const productImgApi = {
    addAsync: async (content) => {
        try {
            const result = await API.post(`${END_POINT.IMAGES}`, content);
            return result;
        } catch (error) {
            console.error(error);
        }
    },
    updateAsync : async (content) => {
        try {
            const result = await API.put(`${END_POINT.IMAGES}`, content);
            return result;
        } catch (error) {
            console.error(error);
        }
    }
}

export default productImgApi;