﻿using System;

namespace Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dogs dog = new Dogs();
            dog.Attack();
            dog.SayHi();
            dog.Run();
        }
    }

    public interface IAnimals
    {
        void Run();
    }

    public interface IDogCommands : IAnimals
    {
        void Stay();

        void Sit();

        void Attack();

        string DogName
        {
            set;
            get;
        }
    }

    internal interface Trainer
    {
    }

    internal class Animals
    {
        private string AnimalName;

        public void SayHi()
        {
            Console.WriteLine("Hi from the animals class");
        }
    }

    internal class Dogs : Animals, IDogCommands, Trainer
    {
        private string DogBreed;

        public void Stay()
        {
            Console.WriteLine("Dog is staying");
        }

        public void Sit()
        {
            Console.WriteLine("Dog is sitting");
        }

        public void Attack()
        {
            Console.WriteLine("Dog is attacking");
        }

        public void Run()
        {
            Console.WriteLine("Animal is running");
        }

        public string DogName { get; set; }
    }
}