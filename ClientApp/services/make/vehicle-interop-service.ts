import { MakeModel } from '../../models/make.model';
import { FeatureModel } from '../../models/feature.model';

/**
 * Service for http requests
 */
export class VehicleInteropService {
  /**
   * get makes list
   */
  public static async getMakes(): Promise<Array<MakeModel>> {
    let response = await fetch('api/makes');
    let result = await response.json();

    return result;
  }

  public static async getFeatures(): Promise<Array<FeatureModel>> {
    let response = await fetch('api/features');
    let result: Promise<Array<FeatureModel>> = await response.json();

    return result;
  }
}
