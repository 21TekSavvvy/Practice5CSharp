class HeightCategory
{
    static void Main()
    {
        // input data
        int inches = 70;

        // convert inches to centimeter
        double centimeterConverted = inches * 2.54;

        // Height is above 195 cm = "Abnormal height"
        if ( centimeterConverted >195)
        {
            System.Console.WriteLine("Abnormal height");
        }
        // Height is between 165 cm and 195 cm = "Tall"
        else if (centimeterConverted <=195 | centimeterConverted > 165)
        {
            System.Console.WriteLine("Tall");
        }
        // Height is between 150 cm and 165 cm = "Average height"
        else if (centimeterConverted <= 165 | centimeterConverted > 150)
        {
            System.Console.WriteLine("Average Height");
        }
        // Height is less than 150 cm = "Dwarf"
        else
        {
            System.Console.WriteLine("Dwarf");
        }

        System.Console.ReadKey();
    }

}