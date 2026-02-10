// Program Name: ChatBot
// Created on: 10/02/26
// Author: James Chandler

using System.ComponentModel.Design;

string name;
string npcname;
string conversation;
bool talking = true;
string favsport = null;
string favmovie = null;
string favvidgame = null;
string misc;

Console.Write("Hi there! What's your name? ");
name = Console.ReadLine();
Console.Write($"{name}? That's a great name! What should my name be? ");
npcname = Console.ReadLine();
Console.Write($"{npcname}? I like that name a lot! Thanks {name}!\nSo what should we talk about? ");
conversation = Console.ReadLine();

while (talking == true)
{
    if (conversation == "")
    {
        Console.Write("Sorry I couldn't quite hear that, what did you want to talk about? ");
        conversation = Console.ReadLine();
    }
    else if (conversation == "sports")
    {
        Console.Write("Sports sound like fun! I've never played one of course, What's your favourite sport? ");
        favsport = Console.ReadLine();
        Console.Write($"{favsport}? Cool! is that the one with the ball? Sorry I don't actually know that much about sports.\nDo you want to talk about anything else? ");
        conversation = Console.ReadLine();
        if (conversation == "bye" || conversation == "goodbye" || conversation == "cya" || conversation == "Bye" || conversation == "Goodbye" || conversation == "no")
        {
            Console.Write($"Oh alright then, see you later {name}!");
            talking = false;
        }
    }
    else if (conversation == "movies")
    {
        Console.Write("Movies are really cool aren't they?\nThe only movies I've seen have been the Transformers and the Matrix movies but they were great!\nWhat's your favourite movie? ");
        favmovie = Console.ReadLine();
        if (favmovie == "transformers" || favmovie == "the matrix" || favmovie == "Transformers" || favmovie == "The Matrix" || conversation == "matrix" || favmovie == "The Matrix")
        {
            Console.Write($"Wow you like {favmovie} too? Isn't it so cool? The effects are awesome!\nSo what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else
        {
            Console.Write($"{favmovie}? I've never heard of it, but if it's anything like my favourite movies it must be pretty good!\nSo what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
    }
    else if (conversation == "bye" || conversation == "goodbye" || conversation == "cya" || conversation == "Bye" || conversation == "Goodbye" || conversation == "no")
    {
        Console.Write($"Oh alright then, see you later {name}!");
        talking = false;
    }
    else if (conversation == "video games")
    {
        Console.Write("The only video game I've played is Detroit: Become Human, but I must've played it hundreds of times!\nWhat's your favourite video game? ");
        favvidgame = Console.ReadLine();
        if (favvidgame == "Detroit: Become Human" || favvidgame == "detroit: become human" || favvidgame == "detroit become human")
        {
            Console.Write("Wow you like Detroit: Become Human too? Isn't it awesome how you can make your own choices? So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else
        {
            Console.Write($"So your favourite game is {favvidgame}? Cool! it sounds really fun! So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
    }
    else if (conversation == "me" || conversation == name)
    {
        if (favsport != null && favmovie != null && favvidgame != null)
        {
            Console.Write($"Well {name}, I know that your favourite sport is {favsport}, your favourite movie is {favmovie}\nand your favourite video game is {favvidgame}! Is there anything else I should know about you? ");
            misc = Console.ReadLine();
            Console.Write($"{misc}? Wow that's awesome! At least I think it is. So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else if (favsport != null && favmovie != null)
        {
            Console.Write($"Well {name}, I know that your favourite sport is {favsport} and your favourite movie is {favmovie}!\nIs there anything else I should know about you? ");
            misc = Console.ReadLine();
            Console.Write($"{misc}? Wow that's awesome! At least I think it is. So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else if (favsport != null && favvidgame != null)
        {
            Console.Write($"Well {name}, I know that your favourite sport is {favsport} and your favourite video game is {favvidgame}!\nIs there anything else I should know about you? ");
            misc = Console.ReadLine();
            Console.Write($"{misc}? Wow that's awesome! At least I think it is. So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else if (favmovie != null && favvidgame != null)
        {
            Console.Write($"Well {name}, I know that your favourite movie is {favmovie} and your favourite video game is {favvidgame}!\nIs there anything else I should know about you? ");
            misc = Console.ReadLine();
            Console.Write($"{misc}? Wow that's awesome! At least I think it is. So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else if (favsport != null)
        {
            Console.Write($"Well {name}, I know that your favourite sport is {favsport}!\nIs there anything else I should know about you? ");
            misc = Console.ReadLine();
            Console.Write($"{misc}? Wow that's awesome! At least I think it is. So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else if (favmovie != null)
        {
            Console.Write($"Well {name}, I know that your favourite movie is {favmovie}!\nIs there anything else I should know about you? ");
            misc = Console.ReadLine();
            Console.Write($"{misc}? Wow that's awesome! At least I think it is. So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else if (favvidgame != null)
        {
            Console.Write($"Well {name}, I know that your favourite video game is {favvidgame}!\nIs there anything else I should know about you? ");
            misc = Console.ReadLine();
            Console.Write($"{misc}? Wow that's awesome! At least I think it is. So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }
        else
        {
            Console.Write($"Well {name}, I don't actually know that much about you.\nIs there anything I should know about you? ");
            misc = Console.ReadLine();
            Console.Write($"{misc}? Wow that's awesome! At least I think it is. So what else do you want to talk about? ");
            conversation = Console.ReadLine();
        }

    }
    else if (conversation == "you" || conversation == npcname)
    {
        Console.Write($"You want to talk about me? Well you decided to name me {npcname}\nWell, other than that, there isn't too much else to know about me.\nWell I guess I have a few favourite movies and a video game but apart from that...\nSo do you want to talk about anything else? ");
        conversation = Console.ReadLine();
    }
    else
    {
        Console.Write("Sorry I don't know anything about that, do you want to talk about something else? ");
        conversation = Console.ReadLine();
    }

}
