using System;
public class cel:cliente{
   public string pais {get; set;}
   public cel(string pais, int imei, string marca, string modelo, string SistOper):base(imei, marca, modelo,SistOper){
      this.pais=pais;
   }
 

}