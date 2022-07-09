import API from "./API.js";

const basrApiUrl = "/products";

const productApi = {
    getAllAsync: async (params) => {
        try {
            var result = await API.get(url, { params: params });
        }
    }
}