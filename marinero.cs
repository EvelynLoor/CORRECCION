class marinero:tripulante
{
    private int pesoTotalPescado{get;set;}
    private int sueldo=900;

    private double bono,totalSueldo;

    public marinero(string nombre,string telefono,string cedula, int edad, int tiempoenEmpresa, string sexo, string barco,int pesoTotalPescado):base(nombre,telefono,cedula,edad,tiempoenEmpresa,sexo,barco){
        this.pesoTotalPescado=pesoTotalPescado;
    }
    public override double Sueldo()
    {
        if(pesoTotalPescado>=1){
            bono=0.25*pesoTotalPescado;

        }
        totalSueldo=sueldo+bono;
        return totalSueldo;
    }
    public override void Imprimir()
    {
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Telefono: "+telefono);
        Console.WriteLine("Cedula: "+cedula);
        Console.WriteLine("Edad: "+edad);
        Console.WriteLine("Tiempo en la empresa: "+tiempoenEmpresa);
        Console.WriteLine("Sexo: "+sexo);
        Console.WriteLine("Barco: "+barco);
        Console.WriteLine("Pesot total Pescado: "+pesoTotalPescado);
        Console.WriteLine("Sueldo: "+sueldo);
    }


}