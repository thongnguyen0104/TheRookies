import API from "./API";
import { END_POINT } from "./endPoint";

const userApi = {
    getAllAsync: async () => {
        try {
            const result = await API.get(`${END_POINT.USERS}`);
            console.log(result);
            return result;
        } catch (error) {
            console.error(error);
        }
    }
}

export default userApi;