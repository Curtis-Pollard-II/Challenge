<template>
    <div class="container-fluid p-3">
        <div class="bg-light border p-1 elevation-2 rounded" >
            <div>
                <h1 class="text-dark">{{persons.name}}</h1>
                <p class="text-success">{{persons.email}}</p>
                <p class="text-dark">{{persons.address}}  {{persons.city}}  {{persons.region}}  {{persons.postalZip}}</p>
                <p>{{persons.skU_Number}}</p>
            </div>
        </div>
    </div>
</template>


<script>
export default {
    props:{
        persons: {type: Object, required: true },
    },
setup() {
  return {};
},
};
</script>


<style> 
</style>