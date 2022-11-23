class GPS
{
    private string coordenadasX{get;set;}
    private string coordenadasY{get;set;}
    private string fecha{get;set;}
    private int diasTripulados{get;set;}
    private string hora {get; set;}

    public GPS(string coordenadasX,  string coordenadasY, string fecha, int diasTripulados, string hora){
        this.coordenadasX=coordenadasX;
        this.coordenadasY=coordenadasY;
        this.fecha=fecha;
        this.diasTripulados=diasTripulados;
        this.hora=hora;
    }
    public void imprimir()
    {
        Console.WriteLine ("las coordenadas X son: "+coordenadasX+"\n"
        +" las coordenadas Y son: "+coordenadasY+"\n"
        +" los dias tripulados son: "+diasTripulados+"\n"
        +" la fecha de registro: "+fecha+"\n"
        +" la hora del registro es: "+hora);
    }
}