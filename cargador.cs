using System;
public class cargador: decorador{
    
    public cargador(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string software(){
        var teclado = "Has agregado un cargador adicional";
      return teclado;
    }
}