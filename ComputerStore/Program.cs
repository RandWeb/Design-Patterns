// See https://aka.ms/new-console-template for more information

using ComputerStore;

Assembler assembler = new(new IntelComputer());
var computer =  assembler.Assembel();
Console.WriteLine(computer.ToString());