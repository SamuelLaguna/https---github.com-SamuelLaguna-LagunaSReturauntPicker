//Samuel Laguna 
//10-18-22
//We are making a program called returaunt picker. We are to have 3 catrigorys of resturaunts and then have ten option in each catigory.
//Peer reivew: 
Console.Clear();

bool PlayAgain = true;
bool end = false;
while(PlayAgain == true){
var random = new Random();
 var list = new List<string>{ "Davids Pizza","Eddies pizza","Micheles pizza","dominos","Little Ceazers","Roundtable","Strawhat","pizza guys","Papa Johns","pizzahut"};
 int index = random.Next(list.Count);
 Console.WriteLine(list[index]);

var another = new Random();
var newList = new List<string>{"Rasin Canes","KFC","Chick fil A","Wingstop","Bufflo Wikd wings","Popyes","Fire Wings","churches chicken","Nash n tender","Rays chicken"};
int anotherindex = random.Next(newList.Count);
Console.WriteLine(newList[index]);

var burger = new Random();
var burgerList = new List<string>{"Mcdonolds","Burgerking","Bj's","Chillies","Applebees","Five guys","in n out","Habit","Sqeez Burger","Smash burger"};
int burgerindex = random.Next(burgerList.Count);
Console.WriteLine(burgerList[index]);


Console.WriteLine("Would you like to playAgain. Type playAgain and end to end it");

    string ending = Console.ReadLine();
    if(ending == "end")
    {
      PlayAgain = false;
    }else
    {
        end = true;
    }

}