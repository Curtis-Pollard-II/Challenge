<template>
{{PersonInfo.Name}}
</template>

<script>
import { onMounted } from '@vue/runtime-core';
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { personInfoService } from '../services/PersonInfoService';

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
      GetAll();
    });
    return {}
  }
}
</script>



<style scoped lang="scss">


</style>
