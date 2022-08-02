int n = 13;

switch (n)
{
    case 0:
        {
            break;
        }
    case 1:
        {
            break;
        }
    case 2:
        {
            break;
        }
    case 10:
        {
            Console.WriteLine("Hola");
            break;
        }
    case 13: // demoing case fall thru for reminder
    case 15:
        {
            Console.WriteLine("Yoooo 13");
            break;
        }
    default:
        Console.WriteLine("idk!");
        break;
}