using System;
using System.Linq;
using LawnMowers.App.Infrastructure;

namespace LawnMowers.App
{
    public class Program
    {
        private static readonly IInputParser InputParser = new InputParser();

        private static readonly ILawnMowersFactory MoversesFactory = new LawnMowersFactory();

        public static void Main(string[] args)
        {
            var inputData = InputParser.ParseInput();

            var movers = MoversesFactory.CreateLawnMowers(inputData).ToList();
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