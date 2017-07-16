using System;
using System.Linq;
using LawnMowers.App.Infrastructure;

namespace LawnMowers.App
{
    public class Program
    {
        private static readonly IInputParser InputParser = new InputParser();

        private static readonly IMoversFactory MoversesFactory = new MoversFactory();

        public static void Main(string[] args)
        {
            var inputData = InputParser.ParseInput();

            var movers = MoversesFactory.CreateMovers(inputData).ToList();
            foreach (var mover in movers)
            {
                mover.StartMover();
            }

            foreach (var mover in movers)
            {
               mover.DisplayCurrentPosition(); 
            }

            Console.ReadLine();
        }
    }
}