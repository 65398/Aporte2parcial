using System;
public class agua: decorador{

    public agua(OrdenBase ordenBase):base(ordenBase){ }
    public override string reparacion(){
        var repacion = "la reparacion de tu telefono que se le metio agua se completo..";
          return repacion;
    }
}