#include <iostream>

using namespace std;

int main()
{
    int a,b;

    cout<<"Digite os dois valores separados por espaço: ";
    cin>>a>>b;
    if(a%b==0 || b%a==0){
        cout<<"São multiplos"<<endl;

    }else{
        cout<<"Não são multiplos"<<endl;
    }


}