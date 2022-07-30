using System;
public class dispositivo3:OrdenBase
    {
    public override string reparacion(){
        var repa = "En repación el dispositivo 3";
        return repa;
    }
   public override string software(){
        var repa = "Se agregó un hardware adicional a este dispositivo";
        return repa;
    }
}