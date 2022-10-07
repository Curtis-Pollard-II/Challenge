<template>
  <div class="row p-4">
      <button @click="isShow = !isShow" class="col-3 btn btn-rounded btn-pill btn-primary p-3">All Records</button>
  </div>

    <div v-show="isShow" class="row bg-info">
      <div class="col-md-3" v-for="p in persons" :key="p.id">
        <PersonCard :persons="p" />
      </div>
    </div>

    <div>
      
    </div>
</template>

<script>
import { computed, onMounted } from '@vue/runtime-core';
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { personInfoService } from '../services/PersonInfoService';
import { AppState } from '../AppState';
import PersonCard from '../components/PersonCard.vue';

export default {
  name: "ToggleDiv",
  data: function () {
    return {
      isShow: true,
    };
  },
    setup() {
        async function getPersonInfo() {
            try {
                await personInfoService.GetAll();
            }
            catch (error) {
                logger.error(error);
                Pop.toast(error.message, "error");
            }
        }
        onMounted(() => {
            getPersonInfo();
        });
        return {
           persons: computed(()=> AppState.personInfo)
        };
    },
    components: { PersonCard }
}
</script>



<style scoped lang="scss">


</style>
