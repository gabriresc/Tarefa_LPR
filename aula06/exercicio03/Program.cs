
static void menuPrincipal()
{
    string nome01="",nome02="",nome03="",nome04="",nome05="";
    string poder01="",poder02="",poder03="",poder04="",poder05="";
    int pontuacao01=0,pontuacao02=0,pontuacao03=0,pontuacao04=0,pontuacao05=0;
    int querHeroi01=0,querHeroi02=0,querHeroi03=0,querHeroi04=0,querHeroi05=0;
    int numerodeherois=1;
    int escolha;
    bool continuar=true;

    while(continuar==true)
    {
        Console.WriteLine("||             Menu Principal         ||");
        Console.WriteLine("|| 1 - Criar os herois                ||");
        Console.WriteLine("|| 2 - Selecionar os herois           ||");  
        Console.WriteLine("|| 3 - Exibir equipe                  ||");
        Console.WriteLine("|| 4 - Sair                           ||");
        Console.Write("||->");
        escolha = Convert.ToInt32(Console.ReadLine());
        if(escolha>4||escolha<1)
        {
            Console.WriteLine("Escolha inválida, tente novamente.");
            menuPrincipal();
        }else
        {
            
            Console.Clear();
            switch(escolha) 
            {
                case 1: 
                    
                    int quantidadeHerois;
                    Console.WriteLine("||  Quantos herois quer criar||\n||no maximo 5 e no minimo 3 ||");
                    Console.Write("||->");
                    quantidadeHerois = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if(quantidadeHerois>5||quantidadeHerois<3)
                    {
                        Console.WriteLine("Quantidade inválida, tente novamente.");
                        menuPrincipal();
                    }
                    else
                    {
                        while(numerodeherois<=quantidadeHerois)
                        {
                            if(numerodeherois==1)
                            {
                                cadastrarHeroi(ref nome01,ref poder01,ref pontuacao01);
                                numerodeherois++;
                            }else if(numerodeherois==2)
                            {
                                cadastrarHeroi(ref nome02,ref poder02,ref pontuacao02);
                                numerodeherois++;
                            }else if(numerodeherois==3)
                            {
                                cadastrarHeroi(ref nome03,ref poder03,ref pontuacao03);
                                numerodeherois++;
                            }else if(numerodeherois==4)      
                            {
                                cadastrarHeroi(ref nome04,ref poder04,ref pontuacao04);
                                numerodeherois++;
                            }else if(numerodeherois==5)
                            {
                                cadastrarHeroi(ref nome05,ref poder05,ref pontuacao05);
                                numerodeherois++;
                            }
                        }
                        Console.WriteLine("||Herois criados com sucesso!||");
                    }
                    break;
                
                case 2:
                    
                    Console.WriteLine("||Selecione os herois para sua equipe||");
                    Console.WriteLine("||Tem que ter 3 herois na equipe        ||");
                    for(int i=1;i<numerodeherois;i++)
                    {
                        if (i==1)
                        {
                            querHeroi01 = selecionarEquipe(nome01,poder01,pontuacao01);
                        

                        }
                        else if (i==2)
                        {
                            querHeroi02 = selecionarEquipe(nome02,poder02,pontuacao02);
                            
                            
                        }
                        else if (i==3)
                        {
                            querHeroi03 = selecionarEquipe(nome03,poder03,pontuacao03);
                            
                        }
                        else if (i==4)
                        {
                            querHeroi04 = selecionarEquipe(nome04,poder04,pontuacao04);
                            
                        }
                        else if (i==5)
                        {
                            querHeroi05 = selecionarEquipe(nome05,poder05,pontuacao05);
                            
                        }      
                    }
                    
                    break;

                case 3:
                    int somatotal = 0 ;
                    int sair=0;
                    Console.Clear();
                    Console.WriteLine("||Equipe selecionada:||");
                    do{
                        Console.Clear();
                        if(querHeroi01==1){ 
                            somatotal = calcularPontuacaoTotal(pontuacao01,somatotal);
                            exibirEquipe(nome01,poder01,pontuacao01);
                        }

                        if(querHeroi02==1){
                            somatotal = calcularPontuacaoTotal(pontuacao02,somatotal);
                            exibirEquipe(nome02,poder02,pontuacao02);
                        }

                        if(querHeroi03==1) {
                            somatotal = calcularPontuacaoTotal(pontuacao03,somatotal);
                            exibirEquipe(nome03,poder03,pontuacao03);
                        }

                        if(querHeroi04==1) {
                            somatotal = calcularPontuacaoTotal(pontuacao04,somatotal);
                            exibirEquipe(nome04,poder04,pontuacao04);
                        }

                        if(querHeroi05==1) {
                            somatotal = calcularPontuacaoTotal(pontuacao05,somatotal);
                            exibirEquipe(nome05,poder05,pontuacao05);
                        }
                        Console.WriteLine($"||Pontuação total da equipe: {somatotal} ||");
                        Console.WriteLine("||Deseja voltar para o menu?\n||1 - Sim || 0 - Não ||");
                        Console.Write("||->");
                        sair = int.Parse(Console.ReadLine());
                        somatotal=0;
                    }while(sair==0);{
                        Console.Clear();
                        break;
                    }   
                    
            }
            if(escolha==4)
            {
                Console.WriteLine("||Saindo do programa...||");
                continuar=false;
                
            }
        
        }
    }
}
static void cadastrarHeroi(ref string nome,ref string  poder,ref int pontuacao)
{
    Console.WriteLine("||Digite o nome do heroi:");
    Console.Write("||->");
    nome = Console.ReadLine();
    Console.WriteLine("||Digite o poder do heroi:");
    Console.Write("||->");
    poder = Console.ReadLine();
    Console.WriteLine("||Digite a pontuacao do heroi:");
    Console.Write("||->");
    pontuacao = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    
}

static int selecionarEquipe(string nome,string poder,int pontuacao)
{
    int querHeroi,contador=0;
    Console.WriteLine("||Quer este heroi na sua equipe?");
    Console.WriteLine($"||Nome: {nome} || Poder: {poder} || Pontuação: {pontuacao} ||");
    Console.WriteLine("||1 - Sim || 0 - Não ||");
    Console.Write("||->");
    querHeroi = Convert.ToInt32(Console.ReadLine());
    
    if(querHeroi==1)
    {
        
        Console.Clear();
        contador++;
        if(contador>3)
        {
            Console.WriteLine("||Equipe completa!||");
            Console.Clear();
            return 0;
        }else{
            
            Console.WriteLine("||Heroi adicionado a equipe||");
            return 1;
        }
        
    }else 
    {
        Console.WriteLine("||Heroi não adicionado a equipe||");
        Console.Clear();
        return 0;
    }  
}
static int calcularPontuacaoTotal(int pontos,int total)
{
    total+= pontos;
    return total;

}
static void exibirEquipe(string nome,string poder,int pontuacao)  
{  
    Console.WriteLine($"||Nome: {nome} || Poder: {poder} || Pontuação: {pontuacao} ||");
    
}
menuPrincipal();






