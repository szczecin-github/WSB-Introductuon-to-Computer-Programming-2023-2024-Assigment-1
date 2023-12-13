Console.WriteLine("Welcome to Tic-Tac-Toe!");
string[] array = { " ", " ", " ", " ", " ", " ", " ", " ", " ", };
void GameBoard()
{
    //
    Console.WriteLine(" " + array[0] + " | " + array[1] + " | " + array[2]);
    Console.WriteLine("---+---+---");
    Console.WriteLine(" " + array[3] + " | " + array[4] + " | " + array[5]);
    Console.WriteLine("---+---+---");
    Console.WriteLine(" " + array[6] + " | " + array[7] + " | " + array[8]);
}
Console.WriteLine("Choose space you want to start");
Console.WriteLine(" 1 | 2 | 3 ");
Console.WriteLine("---+---+---");
Console.WriteLine(" 4 | 5 | 6 ");
Console.WriteLine("---+---+---");
Console.WriteLine(" 7 | 8 | 9 ");
for (int aa = 1; aa <= 9; aa++)
{
    int userinput = Convert.ToInt32(Console.ReadLine());
    if ((userinput >= 1) && (userinput <= 9))
    {
        if (array[userinput - 1] != " ")
        {
            Console.WriteLine("Space already taken. Please choose a different space.");
            aa--;
        }
        else
        {
            if (aa % 2 == 0)
            {
                array[userinput - 1] = "x";
                Console.WriteLine("x's move > " + userinput);
                GameBoard();
            }
            else
            {
                array[userinput - 1] = "o";
                Console.WriteLine("o's move > " + userinput);
                GameBoard();
            }
        }

    }

}
Console.WriteLine("Game Over!");
