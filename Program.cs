using ExemploExplorando.Models;
using System;

LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhas, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucesso)
{
    Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo.");
}
























//Pessoa p1 = new Pessoa();
//p1.Nome = "John";
//p1.Sobrenome = "Dalton";
////p1.Idade = 30;
////p1.Apresentar();

//Pessoa p2 = new Pessoa();
//p2.Nome = "Hilza";
//p2.Sobrenome = "Batista";

//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Inglês";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();