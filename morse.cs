        static void Main(string[] args)
        {
            string word, morse;
            word = Console.ReadLine();
            morse = word.Replace("a", ".- ").Replace("b", "-... ").Replace("c", "-.-. ").Replace("d", "-.. ").Replace("e", ". ").Replace("f", "..-. ").Replace("g", "--. ").Replace("h", ".... ").Replace("i", ".. ").Replace("j", ".--- ")
            .Replace("k", "-.- ").Replace("l", ".-.. ").Replace("m", "-- ").Replace("n", "-. ").Replace("o", "--- ").Replace("p", ".--. ").Replace("q", "--.- ").Replace("r", ".-. ").Replace("s", "... ").Replace("t", "- ").Replace("u", "..- ")
            .Replace("v", "...- ").Replace("w", ".-- ").Replace("x", "-..- ").Replace("y", "-.-- ").Replace("z", "--.. ").Replace("1", ".---").Replace("2", "..---").Replace("3", "...-- ").Replace("4", "....- ").Replace("5", "..... ")
            .Replace("6", "-.... ").Replace("7", "--... ").Replace("8", "---.. ").Replace("9", "----. ").Replace("0", "----- ").Replace("A", ".- ").Replace("B", "-... ").Replace("C", "-.-. ").Replace("D", "-.. ").Replace("E", ". ")
            .Replace("F", "..-. ").Replace("G", "--. ").Replace("H", ".... ").Replace("I", ".. ").Replace("J", ".--- ")
            .Replace("K", "-.- ").Replace("l", ".-.. ").Replace("M", "-- ").Replace("N", "-. ").Replace("O", "--- ").Replace("P", ".--. ").Replace("Q", "--.- ").Replace("R", ".-. ").Replace("S", "... ").Replace("T", "- ").Replace("U", "..- ")
            .Replace("V", "...- ").Replace("W", ".-- ").Replace("X", "-..- ").Replace("Y", "-.-- ").Replace("Z", "--.. ");
            Console.WriteLine(morse);
            Console.WriteLine(word);
        }
