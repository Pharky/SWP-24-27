// See https://aka.ms/new-console-template for more information
bool isInput = true;


Console.WriteLine("Schreibe deinen Namen!");

while (isInput) {
    string input = Console.ReadLine();
    Console.WriteLine(input);
    
    if(input =="Beenden") {
        isInput = false;
}}