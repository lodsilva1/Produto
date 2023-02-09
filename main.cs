using System;

class Program {

    public static void Main (string[] args) {

string entrada, produto;
int qtd;
Double preco,total,desc_menor_5,desc_menor_10,desc_maior_10,desconto; 
 
      desc_menor_5 = 0.02;

      desc_menor_10 = 0.03;

      desc_maior_10 = 0.05;
      
      desconto = 0.0;

     Console.WriteLine ("Nome do Produto: ");
 produto = Console.ReadLine ();
    
      Console.WriteLine  ("Quantidade: ");
 entrada = Console.ReadLine ();
qtd = int.Parse(entrada);
 
      Console.WriteLine ("Preço Unitario: "); 
 entrada = Console.ReadLine ();
preco = Double.Parse(entrada);
    
      total = qtd * preco;

      
      if (qtd <= 5)

      { desconto = total * desc_menor_5;
    }

    
      if (qtd > 5 && qtd <= 10)

    {desconto = total * desc_menor_10;
    }
    
     
      if (qtd > 10)

      {desconto = total * desc_maior_10;
    }
    
      Console.WriteLine("Produto : " +produto);

      Console.WriteLine("Preco unitário : " +preco);
      Console.WriteLine("Total : "  +total); 
      Console.WriteLine("Desconto: " +desconto); 
      Console.WriteLine("Total a pagar: " +total+ - +desconto); 
      Console.WriteLine("valor total a pagar: " +total + desconto );

  }
}