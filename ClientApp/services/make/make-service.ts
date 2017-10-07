import { MakeModel } from '../../models/make.model';

export class MakeService {
  public static async getMakes(): Promise<Array<MakeModel>> {
    let response = await fetch('api/makes');
    let result = await response.json();

    return await result;
  }
}
