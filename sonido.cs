using System;
public class sonido: decorador{

    public sonido(OrdenBase ordenBase):base(ordenBase){ }

    public override string software(){
        var teclado = "Has agregado el parlante adicional";
      return teclado;
    }
}