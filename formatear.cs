using System;
public class formatear: decorador{

    public formatear(OrdenBase ordenBase):base(ordenBase){ }
    public override string reparacion(){
        var repacion = "El formateo de tu celular se ha completado";
          return repacion;
    }
}