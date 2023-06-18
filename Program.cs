using System;
using System.Linq;
using System.Collections.Generic;

namespace AtividadeNova08;

public static class Program
{
    static List<string> nomes = new List<string>();
	public static void Main()
	{
		string num;
		int posicao;
		string usuario;
		int deletar;
		string antigoNome;
		string novoNome;
		int alterar;
		int contador=0;
	
	    Console.WriteLine("Digite '1' para cadastrar:");
		Console.WriteLine("Digite '2' para buscar:");
		Console.WriteLine("Digite '3' para Deletar:");
		Console.WriteLine("Digite '4' para alterar:");
		Console.WriteLine("Digite '5' para listar os nomes:");
		num = Console.ReadLine();
		
		if(num!="1" && num!="2" && num!="3" && num!="4" && num!="5"){
		   Console.WriteLine("Comando não identificado...");
		   Console.Clear();
		   Main();
		   return;
		}
		
		if(num == "1"){
		   Console.WriteLine("Digite o nome para se cadastrar");
		   usuario = Console.ReadLine();
		   nomes.Add(usuario);
		   Console.WriteLine("Usuario cadastrado com sucesso");
		   Console.Clear();
		   Main();
		   return;
		}
		
		if(num=="2"){
		   if(nomes.Count == 0){
		      Console.WriteLine("A lista está vazia...");
			  Console.ReadLine();
			  Console.Clear();
			  Main();
			  return;
		   }
		   
		   Console.WriteLine("Digite a posição em que deseja buscar: ");
		   posicao = int.Parse(Console.ReadLine());
		   
		   if(posicao<0 || posicao>nomes.Count){
		      Console.WriteLine("Essa posição não existe...");
			  Console.ReadLine();
			  Console.Clear();
			  Main();
			  return;
		   }
		   
		   Console.WriteLine($"O nome nesta posição é: {nomes[posicao]}");
		   Console.ReadLine();
		   Console.Clear();
		   Main();
		   return;
		}
		
		if(num=="3"){
		  if(nomes.Count == 0){
		      Console.WriteLine("A lista está vazia...");
			  Console.ReadLine();
			  Console.Clear();
			  Main();
			  return;
		   }
		   
		  Console.WriteLine("Digite a posição que deseja deletar:");
		  deletar = int.Parse(Console.ReadLine());
		  
		  if(deletar<0 || deletar>nomes.Count){
		     Console.WriteLine("Essa posição não existe...");
			 Console.ReadLine();
			 Console.Clear();
			 Main();
			 return;
		  }
		  
		  nomes.RemoveAt(deletar);
		  Console.WriteLine("Nome deletado com sucesso!");
		  Console.ReadLine();
		  Console.Clear();
		  Main();
		  return;
		}
		
		if(num=="4"){
		  if(nomes.Count == 0){
		      Console.WriteLine("A lista está vazia...");
			  Console.ReadLine();
			  Console.Clear();
			  Main();
			  return;
		   }
		   
		  Console.WriteLine("Digite o nome que deseja alterar:");
		  antigoNome = Console.ReadLine();
		  
		  alterar = nomes.IndexOf(antigoNome);
		  
		  if(alterar!= -1){
		     Console.WriteLine("Digite o novo nome:");
			 novoNome = Console.ReadLine();
			 
			 nomes[alterar]=novoNome;
			 Console.WriteLine("Nome alterado com sucesso!");
			 Console.ReadLine();
			 Console.Clear();
			 Main();
			 return;
		  }
		  else{
		     Console.WriteLine("Esse nome não está na lista...");
			 Console.ReadLine();
			 Console.Clear();
			 Main();
			 return;
		  }
		}
		
		if(num=="5"){
		   while(contador<nomes.Count){
		      Console.WriteLine("O nome é: "+nomes[contador]);
			  //Console.ReadLine();
			  
			  contador++;
		   }
		}
		
		
		Console.ReadKey();

	}
}
