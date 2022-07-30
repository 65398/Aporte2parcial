using System;
public class dispositivo1:OrdenBase
    {
    public override string reparacion(){
    var repa = "En repación el dispositivo 1";
    return repa;
    }
   public override string software(){
    var repa = "Se agregó un hardware adicional a este dispositivo";
    return repa;
    }
}