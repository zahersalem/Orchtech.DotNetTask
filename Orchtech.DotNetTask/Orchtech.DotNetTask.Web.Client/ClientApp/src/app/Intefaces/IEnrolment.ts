import { IClasse } from "./IClasse";
import { IStudent } from "./IStudent";

export class IEnrolment{
    Id:string;
    Classe:IClasse;
    Students:IStudent[]
}