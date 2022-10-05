<template>
  <div class="bg-info">{{persons}}</div>
</template>

<script>
import { computed, onMounted } from '@vue/runtime-core';
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { personInfoService } from '../services/PersonInfoService';
import { AppState } from '../AppState';

export default {
  setup() {
    async function getPersonInfo(){
      try {
        await personInfoService.GetAll();
      } catch (error) {
        logger.error(error)
        Pop.toast(error.message, 'error')
      }
    }

    onMounted(() => {
      getPersonInfo();
    });
    return {
      persons: computed(()=> AppState.personInfo)
    }
  }
}
</script>



<style scoped lang="scss">


</style>
