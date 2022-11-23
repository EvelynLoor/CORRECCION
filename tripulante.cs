abstract class tripulante{
    public string nombre{get;set;}
    public string telefono{get;set;}
    public string cedula{get;set;}
    public int edad{get;set;}
    public int tiempoenEmpresa{get;set;}
    public string sexo{get;set;}
    public string barco{get;set;}


    public tripulante(string nombre,string telefono,string cedula, int edad, int tiempoenEmpresa, string sexo, string barco){
        this.nombre=nombre;
        this.telefono=telefono;
        this.cedula=cedula;
        this.edad=edad;
        this.tiempoenEmpresa=tiempoenEmpresa;
        this.sexo=sexo;
        this.barco=barco;
    }

    public abstract double Sueldo();

    public abstract void Imprimir();

}