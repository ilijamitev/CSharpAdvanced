// See https://aka.ms/new-console-template for more information
using Class09.FIleSystemm;
using static Class09.FIleSystemm.Calculate;

var reader = new ConsoleReader();
var first = reader.ReadInteger();
var second = reader.ReadInteger();
var op = reader.ReadOperation();

var result = Calculate.Execute(first, second, op);

Console.WriteLine(result);



