class HeightCategory
{
    static void Main()
    {
        int inches = 70;
        double centimeterConverted = inches * 2.54;
        if( centimeterConverted >195)
        {
            System.Console.WriteLine("Abnormal height");
        }
        else if(centimeterConverted <=195 | centimeterConverted > 165)
        {
            System.Console.WriteLine("Tall");
        }
        else if (centimeterConverted <= 165 | centimeterConverted > 150)
        {
            System.Console.WriteLine("Average Height");
        }
        else
        {
            System.Console.WriteLine("Dwarf");
        }

        System.Console.ReadKey();
    }

}