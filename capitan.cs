class capitan:tripulante
{
    private int horasExp{get;set;}
    private int sueldo=4500;

    private double bono,totalSueldo;

    public capitan(string nombre,string telefono,string cedula, int edad, int tiempoenEmpresa, string sexo, string barco, int horasExp):base(nombre,telefono,cedula,edad,tiempoenEmpresa,sexo,barco){
        this.horasExp=horasExp;
    }
    public override double Sueldo()
    {
        if(horasExp>=5000 && horasExp<150000){
            bono=0.2*sueldo;
            totalSueldo=totalSueldo+bono;
        }
        if(horasExp>=150000 && horasExp < 300000){
            bono=0.4*sueldo;
            totalSueldo=totalSueldo+bono;
        }
        if(horasExp>300000){
            bono=0.75*sueldo;
            totalSueldo=totalSueldo+bono;
        }
        totalSueldo=totalSueldo+sueldo;
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
        Console.WriteLine("Horas de experiencia: "+horasExp);
        Console.WriteLine("Sueldo: "+sueldo);
    }
}