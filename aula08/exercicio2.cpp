#include <iostream>
#include <vector>
using namespace std;

struct Livros
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};



int main()
{
    cout<<"Digite as informações dos livros"<<endl;
    vector<Livros>vectorlivros(3);
    for(int i=0;i<3;i++){
        cout<<"Digite o titulo do livro "<<i+1<<":";
        cin>>vectorlivros[i].Titulo;
        cout<<"Digite o autor do livro "<<i+1<<":";
        cin>>vectorlivros[i].Autor;
        cout<<"Digite o ano de publicacao do livro "<<i+1<<":";
        cin>>vectorlivros[i].AnoPublicacao;
        cout<<"Digite o numero de paginas do livro "<<i+1<<":";
        cin>>vectorlivros[i].NumeroPaginas;
        cout<<"Digite o preco do livro "<<i+1<<":";
        cin>>vectorlivros[i].Preco;
        cout<<""<<endl;
    }
    
    double precototal;
    double mediapaginas;

    for(Livros x : vectorlivros)
    {
        precototal+= x.Preco;
        mediapaginas+=x.NumeroPaginas;
    }
    cout<<"Preco total dos livros:"<<precototal<<endl;
    cout<<"A media de paginas e:"<<mediapaginas/3<<endl;


}