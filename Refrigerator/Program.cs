// Autora: Carol Magalhães Lima

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        {
            var geladeira = new List<List<List<string>>>
        {
            new List<List<string>>
            {
                new List<string> {"Maçã", "Banana", "Cenoura", "Alface"},
                new List<string> {"Tomate", "Pepino", "Brócolis", "Batata"}
            },
            new List<List<string>>
            {
                new List<string> {"Leite", "Queijo", "Iogurte", "Manteiga"},
                new List<string> {"Feijão", "Milho", "Ervilha", "Atum"}
            },
            new List<List<string>>
            {
                new List<string> {"Presunto", "Salame", "Mortadela", "Bacon"},
                new List<string> {"Frango", "Carne", "Ovos", "Peito de Peru"}
            }
        };

            for (int andar = 0; andar < geladeira.Count; andar++)
            {
                for (int container = 0; container < geladeira[andar].Count; container++)
                {
                    string itens = string.Join(", ", geladeira[andar][container]);
                    Console.WriteLine($"Andar {andar}, Container {container}, Itens: {itens}");
                }
            }

        }
    }
}