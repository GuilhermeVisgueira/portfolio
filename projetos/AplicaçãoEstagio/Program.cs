using System.Net.Mime;

namespace AplicaçãoEstagio;

class Program
{
  static void Main(string[] args)
  {
    /*
    Escreva uma função que recebe por parâmetro a seguinte lista de notas escolares [73, 67,38 ,33].
    A função deve percorrer a lista de notas,aplicando as seguintes regras e retornar as notas finais.
    Regras:
    Se a diferença entre uma nota e o próximo número múltiplo de 5 for menor que 3, arredonde a nota para o próximo múltiplo de 5
    Se a nota for menor que 38 nada acontece com a nota.
    Exemplos: Se uma nota for igual a  84, seu próximo múltiplo de 5 é 85, logo a nota será arredondada para para 85,
    pois a diferença (85-84) é menor que 3.
    

    public int LNotas(List<int> notas)
    {
      
      for (int i = 0; i < notas.Count; i++)
      {
        
        int proxNumero = notas[i];
        proxNumero = proxNumero + 1;
        if (proxNumero % 5 == 0 && proxNumero % 5 == 5)
        {
          int dif = proxNumero - notas[i];
          if (dif < 3)
          {
            return notas[i];
          }
          else
          {
            return notas[i] = proxNumero;
          }
          
          
          break;
          
        }
        
      }
      return notas[i];

    }

    LNotas(73, 67, 38, 33);
    */

    /*
    //Faça um algoritmo para ler 50 números e armazenar em uma lista,verificar e escrever
    //se existem números repetidos na lista e em que posições se encontram.

    List<int> numeros = new List<int>();
    for (int i = 0; i < 50; i++)
    {
      Console.WriteLine("Digite 50 numeros: ");
      Console.WriteLine($"Numero {i} :");
      numeros[i] = int.Parse(Console.ReadLine());

    }

    for (int i = 0; i < numeros.Count; i++)
    {
      int aux = numeros[i];

      for (int j = 0; j < numeros.Count; j++)

        if (aux == numeros[j])
        {
          Console.WriteLine($"Existem numeros repetidos e estão na posição {i} e {j}");
        }

    }
    */


    /*
    //Usando a seguinte lista de temperatutas [23.6, 37.9, 25.1, 19.0, 29.8],escreva código que identifique e retorne.
    //a)Menor temperatura b) Maior temperatura c) Temperatura média

    List<double> temperaturas = [23.6, 37.9, 25.1, 19.0, 29.8];

    double maior = 0, menor = 100, media, soma = 0;

    for(int i = 0; i < temperaturas.Count; i++)
    {
      soma += temperaturas[i];

      if (temperaturas[i] > maior)
      {
        maior = temperaturas[i];
      }else if (temperaturas[i] < menor)
      {
        menor = temperaturas[i];
      }

    }
    media = soma / temperaturas.Count;

    Console.WriteLine($"A maior temperatura é {maior}, a menor temperatura é {menor} e a media delas é {media}");
    */

    /*
    //Ler 2 valores inteiros garantindo que o segundo valor lido será sempre maior que o primeiro valor lido.
    //Calcule e escreva a soma dos inteiros existentes entre os 2 valores lidos (incluindo os valores lidos).
    bool Flag = true;
    while (Flag)
    {
      int num1, num2, AllNumbers, resultado;
      resultado = 0;
      Console.WriteLine("Digite o valor do primeiro numero: ");
      num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor do segundo numero: ");
      num2 = int.Parse(Console.ReadLine());
      AllNumbers = num1 + num2;
      resultado = num1 + num2;

      if (num1 > num2)
      {
        while (num1 > num2)
        {
          resultado = 0;
          Console.WriteLine("O primeiro numero digitado não pode ser maior que o segundo numero");
          Console.WriteLine("Digite o primeiro numero: ");
          num1 = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite o segundo numero: ");
          num2 = int.Parse(Console.ReadLine());

          AllNumbers = num1 + num2;
          resultado = num1 + num2;
          Console.Clear();

        }

      }
      Flag = false;
      Console.WriteLine($"A soma dos dois numeros é {resultado} e de todos os numeros digitados é {AllNumbers}");
      */
  }
}