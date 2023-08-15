while (true)
{
    Console.WriteLine("****************************************************");
    Console.Write("Enter your PhoneNumber: ");
    string keyphone = Console.ReadLine();
    if (keyphone == null || keyphone == "" || keyphone.Contains(" "))
    {
        Console.WriteLine(" PhoneNumber vared shode eshtebah ast");
        Console.WriteLine("mojadad PhoneNumber vared konid");
    }
    else
    {
        if (keyphone.Length != 11)
        {
            Console.WriteLine("tedad adad argham PhoneNumber eshtebah ast ! bayad 11 ragham bashad");
        }
        else
        {

            bool istrue = true;
            for (int i = 0; i < 10; i++)
            {
                if (!char.IsDigit(keyphone[i]))
                {
                    istrue = false;
                    Console.WriteLine("PhoneNumber vared shode eshtebah ast ");
                    break;
                }
            }
            if (istrue && char.GetNumericValue(keyphone[0]) == 0)
            {
                Console.WriteLine("PhoneNumber Vared shode dorost ast");
            }
            else
            {
                Console.WriteLine("avalin ragham byad sefr bashad");
            }
        }
    }
}

