// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe a opção desejada:");
Console.WriteLine("1- Inserir novo aluno");
Console.WriteLine("2- Listar alunos");
Console.WriteLine("3- Calcular média geral");
Console.WriteLine("X- Sair");
Console.WriteLine();

string opcaoUsuario = Console.ReadLine();

while (opcaoUsuario.ToUpper() != "X")
{
    switch(opcaoUsuario)
    
{
        case "1":
             //TODO: ADICIONAR ALUNO           
            break;

        case "2":  
             //TODO: LISTAR ALUNOS   
            break;
        case "3":
            //TODO: CALCULAR MEDIA GERAL  
            break;
        default:
            throw new ArgumentOutOfRangeException();



    
}   
    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine("1- Inserir novo aluno");
    Console.WriteLine("2- Listar alunos");
    Console.WriteLine("3- Calcular média geral");
    Console.WriteLine("X- Sair");
    Console.WriteLine();

    opcaoUsuario = Console.ReadLine();


}