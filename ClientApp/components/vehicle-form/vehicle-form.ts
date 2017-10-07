import Vue from 'vue';
import { Component } from 'vue-property-decorator';

@Component
export default class VehicleFormComponent extends Vue {
    public title: string;

    constructor() {
        super();
        
        this.title = "Форма авто";
    }
}
