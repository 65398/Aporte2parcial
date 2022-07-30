using System;
public class dispositivo2:OrdenBase
    {
    public override string reparacion(){
        var repa = "En repación el dispositivo 2";
        return repa;
    }
   public override string software(){
        var repa = "Se agregó un hardware adicional a este dispositivo";
        return repa;
    }
}