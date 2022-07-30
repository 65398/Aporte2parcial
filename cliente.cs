using System;
public class cliente{

  public int imei {get; set;}
  public string marca {get; set;}
  public string modelo {get; set;}
  public string SistOper{get; set;}

  public cliente(int imei, string marca, string modelo, string SistOper){
   this.imei=imei;
   this.marca=marca;
   this.modelo=modelo;
   this.SistOper=SistOper;
  }
}