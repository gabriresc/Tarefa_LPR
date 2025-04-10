#include <iostream>
#include <iomanip>
using namespace std;

void exer1()
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
void exer3()
{
    int acumulador=0;
    for(int i=50;i<=500;i++){
        if(i%3==0&& i%2!=0){
            acumulador+=i;
        }else{}
        
    }
    cout<<acumulador;
}
void exer4()
{
    int numero,numerodobrado,soma;
    cout<<"Qual o numero"<<endl;
    cin>>numero;
    numerodobrado = numero*numero;
    while (numerodobrado != 0)
    {
    int resto = numerodobrado % 10;
    numerodobrado = (numerodobrado - resto) / 10;
    soma += resto;
    }
    cout<<soma<<endl;
}

int main(){
    cout<<"Digite o numero que quer"<<endl;
    
}