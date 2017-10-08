import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import { MakeModel } from '../../models/make.model';
import { VehicleModelModel } from '../../models/vehicle-model.model';
import { VehicleInteropService } from './../../services/vehicle-interop/vehicle-interop-service';
import { FeatureModel } from '../../models/feature.model';

/**
 * Vehicle form page component
 */
@Component
export default class VehicleFormComponent extends Vue {
  public make: number;
  public makes: Array<MakeModel>;
  public models: Array<VehicleModelModel>;
  public features: Array<FeatureModel>;

  constructor() {
    super();
    this.make = 0;
    this.makes = [];
    this.models = [];
    this.features = [];
    this.getMakes();
    this.getFeatures();
  }

  /**
   * get makes from server
   */
  public getMakes(): void {
    VehicleInteropService.getMakes().then(makes => (this.makes = makes));
  }

  /**
   * get features from server
   */
  public getFeatures(): void {
    VehicleInteropService.getFeatures().then(
      features => (this.features = features)
    );
  }

  /**
   * set models on makes change
   */
  public onMakeChange(): void {
    let selectedMake: MakeModel | undefined = this.makes.find(
      i => i.id === this.make
    );

    if (!selectedMake) {
      this.models = [];
      return;
    }

    this.models = selectedMake.models;
  }
}
