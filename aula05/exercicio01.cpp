#include <iostream>
#include <iomanip>
using namespace std;
int main()
{
    int numerodiv,contador=0,numero=0,acumulador=0,erro=0;
    cout<<"Digite o numero de numeros"<<endl;
    cin>>numerodiv;
    while(contador<numerodiv)
    {
        cout<<"Digite o numero"<<endl;
        cin>>numero;
        if(numero%2==0)
        {
            acumulador+=numero;
            
        }else
        {
            erro++;
        }
        contador++;
    }
    if(numerodiv==erro)
    {
        cout<<"Todos os numeros digitados sao impares"<<endl;
    }else{
        
        float media = static_cast<float>(acumulador) / (numerodiv - erro);
        cout<<fixed << setprecision(1) << media<<endl;
    }
    
}