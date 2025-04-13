#include <iostream>
#include <iomanip>
using namespace std;

float exer1(int numerototal)
{
    int contador=0,numero=0,acumulador=0,erro=0;
    
    while(contador<numerototal)
    {
        cout<<"//Digite o numero"<<endl;
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
    if(numerototal==erro)
    {
        
        return 0;
    }else{
        
        float media = static_cast<float>(acumulador) / (numerototal - erro);
        return media;
        
    }
}
int exer3()
{
    int acumulador=0;
    for(int i=50;i<=500;i++){
        if(i%3==0&& i%2!=0){
            acumulador+=i;
        }else{}
        
    }
    return acumulador;
}
int exer4(int numeroaserdobrado)
{
    int numerodobrado,soma;
    
    numerodobrado = numeroaserdobrado*numeroaserdobrado;
    while (numerodobrado != 0)
    {
    int resto = numerodobrado % 10;
    numerodobrado = (numerodobrado - resto) / 10;
    soma += resto;
    }
    return soma;
}

int main(){
    
    int escolha = 0,deseja=0;
    cout<<"/////////////////////////////////////////////////////////"<<endl;
    cout<<"//                        MENU                         //"<<endl;
    cout<<"// ->Digite funcao deseja                              //"<<endl;
    cout<<"// 1-Media de numeros pares                            //"<<endl;
    cout<<"// 2-Soma de multiplos de 3 de 50 a 500                //"<<endl;
    cout<<"// 3-Somas dos digitos de um numero ao quadrado        //"<<endl;
    cout<<"// ";
    cout<<"// ->";
    cin>>escolha;
    if (escolha>3||escolha<1){
        cout<<"// o número escolhido não é está dentro das opções     //"<<endl;
    }else{
        switch(escolha){
            case 1:
            {
                int numerodiv; 
                cout<<"//Digite a quantidade de numeros a ser digitados"<<endl;
                cin>>numerodiv;
                float mediaobtida = exer1(numerodiv);
                if(mediaobtida==0){
                    cout<<"//Os numeros digitados sao todos impares"<<endl;
                }
                else
                {
                    cout<<"A media e:"<<fixed << setprecision(1) << mediaobtida<<endl;
                    cout<<"/////////////////////////////////////////////////////////"<<endl;
                }
                break;
            }
            case 2:
            {
                int soma = exer3();
                cout<<"//A soma e "<<soma<<endl;
                cout<<"/////////////////////////////////////////////////////////"<<endl;
                break;
            }
            case 3:
            {
                int numero;
                cout<<"//Qual o numero"<<endl;
                cin>>numero;
                int somadosdigitos = exer4(numero);
                cout<<"A soma e:"<<somadosdigitos<<endl;
                cout<<"/////////////////////////////////////////////////////////"<<endl;
                break;
            }
        }
    cout<<"//Deseja continuar?\n// 0-no ||1-yes"<<endl;
    cout<<"//";
    cin>>deseja;
    if(deseja==1){
        main();
    }else{
        cout<<"//descanse meu filho"<<endl;
    }    



    }
    
}