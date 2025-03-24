Console.WriteLine("Qua o numero de horas por dia?");
int horasp = int.Parse(Console.ReadLine());
            
int dias = 0;
int semana = 0;
double mes = 0;
for(int i = 0; i < 1000;i+= horasp)
{
    dias++;
    if (dias >= 5)
    {
        dias = 0;
        semana++;
                    
    }
    if (semana > 4.5)
    {
    semana = 0;
    mes++;
}
 
}
           
Console.WriteLine($"Dias: {dias}, Semanas: {semana}, Meses: {mes}");