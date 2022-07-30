using System;
public class pantalla: decorador{

    public pantalla(OrdenBase ordenBase):base(ordenBase){ }
    public override string reparacion(){
        var repacion = "Tu pantalla a sido reparada.";
          return repacion;
    }
}