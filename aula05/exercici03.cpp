#include <iostream>

using namespace std;

int main()
{
    int acumulador=0;
    for(int i=50;i<=500;i++){
        if(i%3==0&& i%2!=0){
            acumulador+=i;
        }else{}
        
    }
    cout<<acumulador;
    
}