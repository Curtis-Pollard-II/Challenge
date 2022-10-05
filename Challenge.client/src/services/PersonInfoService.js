import { AppState } from "../AppState"
import { api } from "./AxiosService"

class PersonInfoService {
    async GetAll() {
        const res = await api.get('/api/PersonInfo')
        console.log(res.data)
        AppState.personInfo = res.data
    }

}

export const personInfoService = new PersonInfoService()