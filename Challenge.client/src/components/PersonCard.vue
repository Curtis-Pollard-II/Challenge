<template>
    <div class="container-fluid p-3">
        <div class=" bg-light border p-1 elevation-2 rounded" >
            <div>
                <h5 class="text-dark">{{persons.name}} -----   id:{{persons.id}}</h5>
                <p class="text-info">{{persons.email}}</p>
                <p class="text-dark">Address: {{persons.address}}  {{persons.city}}  {{persons.region}}  {{persons.postalZip}}</p>
                <p class="text-success">Value: {{persons.value}}</p>
                <p class="text-dark">Active: {{persons.active}}</p>
                <p class="text-dark">Event Date: {{persons.eventDate}}</p>
                <p class="text-danger">SKU#: {{persons.skU_Number}}</p>
                <p class="text-danger">Tracking COde: {{persons.trackCode}}</p>
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