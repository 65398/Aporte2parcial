using System;
public class decorador{
    protected OrdenBase orden;

    public decorador(OrdenBase orden)
    {
        this.orden= orden;
    }
    public virtual string software(){
      return orden.software();
    }
    public virtual string reparacion(){
      return orden.reparacion();
    }
}