// Shaun Aguirre-Reyes
// 10/18/22
// This program reverses the number that the user has inputted




Console.Clear();

string playAgain = "yes";
while(playAgain == "yes"){

int  i, reverse=0, rvrs;           
Console.Write("Enter a number: ");      
i= int.Parse(Console.ReadLine());     
while(i!=0){      
rvrs=i%10;        
reverse=reverse*10+rvrs;      
i/=10;      
}      
Console.Write("Reversed Number: "+ reverse + ".");  

Console.WriteLine(" Do you want to play again?");
playAgain = Console.ReadLine();
if(playAgain == "yes"){
    Console.WriteLine("Lets play again");
}else{
    Console.WriteLine("Have a great day :)");
}

}