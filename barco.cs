class barco
{
    private string nombre{get;set;}
    private int capa1{get;set;}
    private int capa2{get;set;}

    public barco(string nombre, int capaS, int capa1){
        this.nombre=nombre;
        this.capa1=capa1;
        this.capa2=capa2;
    }

    public void ImprimirBarco(){
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Cual es la capacidad de pasajeros: "+capa1);
        Console.WriteLine("Cual es la capacidad de carga: "+capa2+" kg");
    }
}
