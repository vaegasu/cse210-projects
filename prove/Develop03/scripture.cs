using System;
using System.Collections;
class Scripture
{
    private string _scripture = "4 Love is patient, love is kind. It does not envy, it does not boast, it is not proud. 5 It does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs. 6 Love does not delight in evil but rejoices with the truth. 7 It always protects, always trusts, always hopes, always perseveres. 8 Love never fails. But where there are prophecies, they will cease; where there are tongues, they will be stilled; where there is knowledge, it will pass away.";
    // private string _reference = "1 Corinthians 13:4–8";

    public void Display()
    {
        Console.WriteLine($"{_scripture}");
    }
}