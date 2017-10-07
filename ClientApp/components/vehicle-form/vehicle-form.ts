import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import { MakeService } from '../../services/make/make-service';
import { MakeModel } from '../../models/make.model';
import { VehicleModelModel } from '../../models/vehicle-model.model';

@Component
export default class VehicleFormComponent extends Vue {
  public make: number;
  public makes: Array<MakeModel>;
  public models: Array<VehicleModelModel>;

  constructor() {
    super();
    this.make = 0;
    this.makes = [];
    this.models = [];
    this.getMakes();
  }

  getMakes(): void {
    MakeService.getMakes().then(makes => (this.makes = makes));
  }

  public onMakeChange(): void {
    let selectedMake: MakeModel | undefined = this.makes.find(
      i => i.id === this.make
    );

    if(selectedMake){
      this.models = selectedMake.models;
    }
  }
}
