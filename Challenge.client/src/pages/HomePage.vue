<template>
  <div class="row">
    <div class="col-md-2 p-1">
      <button class="btn btn-rounded btn-pill btn-primary">All Records</button>
    </div>
    <div class="col-md-2 p-1">
      <button class="btn btn-rounded btn-pill btn-primary">Get all Data</button>
    </div>
    <div class="col-md-2 p-1">
      <button class="btn btn-rounded btn-pill btn-primary">Get all Data</button>
    </div>
    <div class="col-md-2 p-1">
      <button class="btn btn-rounded btn-pill btn-primary">Get all Data</button>
    </div>
    <div class="col-md-2 p-1">
      <button class="btn btn-rounded btn-pill btn-primary">Get all Data</button>
    </div>
  </div>
   <div class="row bg-info">
      <div class="col-md-4" v-for="p in persons" :key="p.id">
        <PersonCard :persons="p" />
      </div>
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
            persons: computed(() => AppState.personInfo)
        };
    },
    components: { PersonCard }
}
</script>



<style scoped lang="scss">


</style>
