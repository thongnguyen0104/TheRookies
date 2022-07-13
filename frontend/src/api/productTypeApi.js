import API from "./API";
import { END_POINT } from "./endPoint";

const productTypeApi = {
    getAllAsync: async () => {
        try {
            const result = await API.get(`${END_POINT.PRODUCTTYPES}`);
            return result;
        } catch (error) {
            console.error(error);
        }
    },
    getByIdAsync: async (id) => {
        try {
            const result = await API.get(`${END_POINT.PRODUCTTYPES}/${id}`);
            return result;
        } catch (error) {
            console.error(error);
        }
    },
    addAsync: async (content) => {
        try {
            const result = await API.post(`${END_POINT.PRODUCTTYPES}`, content);
            return result;
        } catch (error) {
            console.error(error);
        }
    },
    deleteAsync: async (id) => {
        try {
            const result = await API.delete(`${END_POINT.PRODUCTTYPES}/${id}`);
            return result;
        } catch (error) {
            console.error(error);
        }
    },
    updateAsync: async (content) => {
        try {
            const result = await API.put(`${END_POINT.PRODUCTTYPES}`, content);
            return result;
        } catch (error) {
            console.log(error)
        }
    }
}

export default productTypeApi;