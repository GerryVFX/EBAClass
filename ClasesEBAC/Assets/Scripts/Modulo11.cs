using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Modulo11 : MonoBehaviour
{
    public List<int> primeraLista = new List<int>();
    int tamañoLista=10;
    int rangos;

    Stack<string> pilaString = new Stack<string>();
    Queue<string> colaString = new Queue<string>();

    List<string> ingredientes = new List<string>();


    void Start()
    {
        print("Esto es el primer ejercicio");
        for(int i = 1; i <= tamañoLista; i++)
        {
            rangos = Random.Range(3, 9);
            primeraLista.Add(rangos);
        }

        foreach(int numero in primeraLista)
        {
            print(numero);
        }

        FuncionArrays();

        print("De una lista a un hashset");
        FuncionHashSet();

        FuncionPila();

    }

    public void FuncionArrays()
    {
        int[] enteros = {2,4,6,8,10};
        var ordenados = enteros.OrderByDescending(n => n).ToList();
        print("Arreglo en descendente");

        foreach(int num in ordenados)
        {
            print(num);
        }
    }

    public void FuncionHashSet()
    {
        ingredientes.Add("Pan");
        ingredientes.Add("Pan");
        ingredientes.Add("Queso");
        ingredientes.Add("Jamón");
        ingredientes.Add("Salami");
        ingredientes.Add("Queso");

        HashSet<string> ingredientes2 = new HashSet<string>();
        ingredientes2.UnionWith(ingredientes);

        foreach(string ing in ingredientes2)
        {
            print(ing);
        }
    }

    public void FuncionPila()
    {
        pilaString.Push("ELemento1");
        pilaString.Push("ELemento2");
        pilaString.Push("ELemento3");
        pilaString.Push("ELemento4");
        pilaString.Push("ELemento5");

        print("Esto es de la pila");

        print(pilaString.Peek());
        colaString.Enqueue(pilaString.Peek());
        pilaString.Pop();
        print(pilaString.Peek());
        colaString.Enqueue(pilaString.Peek());
        pilaString.Pop();
        print(pilaString.Peek());
        colaString.Enqueue(pilaString.Peek());
        pilaString.Pop();
        print(pilaString.Peek());
        colaString.Enqueue(pilaString.Peek());
        pilaString.Pop();
        print(pilaString.Peek());
        colaString.Enqueue(pilaString.Peek());
        pilaString.Pop();

        print("Esto es de la cola");

        print(colaString.Peek());
        colaString.Dequeue();
        print(colaString.Peek());
        colaString.Dequeue();
        print(colaString.Peek());
        colaString.Dequeue();
        print(colaString.Peek());
        colaString.Dequeue();
        print(colaString.Peek());
        colaString.Dequeue();
    }

}
