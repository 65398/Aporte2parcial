using System;
public class auriculares: decorador{
    
    public auriculares(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string software(){
        var teclado = "Has agregado un auricular adicional";
        return teclado;
    }
}