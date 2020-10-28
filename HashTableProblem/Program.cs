// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HashTableProblem
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the phrase:");
            string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] splitPhrase = phrase.Split(' ');
            MyMapNode<string, string> mapNode = new MyMapNode<string, string>(splitPhrase.Length);
            AddSplitPhraseIntoMap(splitPhrase, mapNode);
            Console.WriteLine("Frequency before removal:");
            mapNode.GetFrequencyOf("paranoid");
            mapNode.Remove("paranoid");
            Console.WriteLine("Frequency after removal:");
            mapNode.GetFrequencyOf("paranoid");
            mapNode.Display();
            Console.ReadLine();
        }

        /// <summary>
        /// UC 2 : Adds the splitPhrase into the map.
        /// </summary>
        /// <param name="splitPhrase">The split phrase.</param>
        /// <param name="mapNode">The map node.</param>
        public static void AddSplitPhraseIntoMap(string[] splitPhrase, MyMapNode<string, string> mapNode)
        {
            Console.WriteLine("Adding KeyValue pair");
            for (int i = 0; i < splitPhrase.Length; i++)
            {
                mapNode.Add($"{i}", splitPhrase[i]);
            }
        }
    }
}
        
    
