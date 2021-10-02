using System;
using System.Collections.Generic;
enum Menu
{
    PlayGame = 1,
    Exit
}
enum Word
{
    Tennis = 1,
    Football,
    Badminton
}
namespace MT_Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuScreen(); //เรียกใช้ medthod ที่ชื่อว่า PrintMenuScreen เป็นmedthod ที่ใช้ในการแสดงหน้าmenu
        }
        static void PrintMenuScreen()
        {
            Console.Clear(); //ทำการเคลียร์หน้าต่าง
            PrintHeaderWelcome(); //เรียกใช้ medthod ที่ชื่อว่า PrintHeaderWelcome เป็นmedthod ที่ใช้ในการแสดงข้อความต้อนรับ
            PrintMenu(); //เรียกใช้ medthod ที่ชื่อว่า PrintMenu เป็นmedthod ที่ใช้ในการแสดงรายการเมนู
            InputMenuFromKeyBoard(); //เรียกใช้ medthod ที่ชื่อว่า InputMenuFromKeyBoard เป็นmedthod ที่ใช้ในการรับค่าเมนูที่ผู้ใช้เลือก
        }
        static void PrintHeaderWelcome()
        {
            Console.WriteLine("Welcome to Hangman Game"); //แสดงข้อความ Welcome to Hangman Game (เป็นข้อความต้อนรับ)
            Console.WriteLine("----------------------------------------"); //แสดงข้อความ ----------------------------------------
        }
        static void PrintMenu()
        {
            Console.WriteLine("1.Play game\n2.Exit"); //แสดงเมนู
        }
        static void InputMenuFromKeyBoard()
        {
            Console.Write("Please Select Menu : "); //แสดงข้อความPlease Select Menu : 
            Menu menu = (Menu)(int.Parse(Console.ReadLine())); //รับค่าเมนูที่ผู้ใช้เลือก โดยตัวแปร menu จะเก็บค่านั้นไป

            CheckPresentPageThatUserChoose(menu); /*เรียกใช้ medthod ที่ชื่อว่า CheckPresentPageThatUserChoose เป็นmedthod 
                                                   ที่ใช้ในการตรวจสอบว่าผู้ใช้เลือกไปที่หน้าใด พร้อมส่งค่าของ menu ไปที่ method นั้นๆด้วย*/
        }
        static void CheckPresentPageThatUserChoose(Menu menu)
        {
            if (menu == Menu.PlayGame) //เทียบค่าที่เก็บอยู่ในตัวแปร menu ว่ามีค่าตรงกับ Enum Menu.PlayGame(มีค่าเท่ากับ1)ไหม
            {
                ShowPlayGamePage(); /*หากใช่จะเรียกใช้ medthod ที่ชื่อว่า ShowPlayGamePage ซึ่งเป็น medthod ที่ใช้ในการแสดงหน้าเล่นเกม
                                      หากไม่ใช้จะตรวจสอบในลำดับต่อไป*/
            }
            else if (menu == Menu.Exit) //เทียบค่าที่เก็บอยู่ในตัวแปร menu ว่ามีค่าตรงกับ Enum Menu.PlayGame(มีค่าเท่ากับ2)ไหม
            {

            }
        }
        static void ShowPlayGamePage()
        {
            Console.Clear(); //เคลียร์หน้าต่าง
            PrintHeaderPlayGame();//เรียกใช้ medthod ที่ชื่อว่า PrintHeaderPlayGame เป็นmedthod ที่ใช้ในการแสดงข้อความของหน้าเล่นเกม
            PrintIncorectScore(-1);//เรียกใช้ medthod ที่ชื่อว่า  PrintIncorectScore() เป็นmedthod ที่ใช้ในการแสดงข้อความและค่าจำนวนครั้งที่ผู้ใช้ตอบผิด
            CheckRandomword(PrintRandomWord());//เรียกใช้ medthod ที่ชื่อว่า  CheckRandomword() เป็นmedthod ที่ใช้ในการแสดงข้อความและค่าจำนวนครั้งที่ผู้ใช้ตอบผิด
        }

        static void PrintHeaderPlayGame()
        {
            Console.Clear(); //เคลียร์หน้าต่าง
            Console.WriteLine("Play Game Hangman"); //แสดงข้อความ Play Game Hangman
            Console.WriteLine("----------------------------------------"); //แสดงข้อความ ----------------------------------------
        }
        static void PrintIncorectScore(int i)
        {
            Console.WriteLine("Incorrect Score : {0}", i + 1);

        }
        static Word PrintRandomWord()
        {
            Random random = new Random(); //สร้างตัวแปรชื่อrandom เป็นประเภท Random
            int resultRandom = random.Next(1, 3); //random ตัวเลข1-3
            Word wordrandom = (Word)resultRandom; //สร้างตัวแปรชื่อwordrandom เป็นประเภท Word เก็ยค่าคำตอบของการแรนด้อมเป็นประเภท Word
            return wordrandom; //คืนค่าตัวแปร wordrandom
        }
        static void CheckRandomword(Word wordrandom)
        {
            if (wordrandom == Word.Tennis)//เทียบค่า wordrandom ว่ามีค่าเท่ากับ Enum Word.Tennis(ค่าเท่ากับ1)หรือไม่
            {
                ShowBlankOfRandomWord("Tennis");//ถ้าใช่ให้เรียกใช้ method ชื่อ  ShowBlankOfRandomWord() ซึ่งเป็น medthod ที่ใช้ในการแสดงช่องว่าง
            }
            else if (wordrandom == Word.Football)//เทียบค่า wordrandom ว่ามีค่าเท่ากับ Enum Word.Football(ค่าเท่ากับ1)หรือไม่
            {
                ShowBlankOfRandomWord("Football");//ถ้าใช่ให้เรียกใช้ method ชื่อ  ShowBlankOfRandomWord() ซึ่งเป็น medthod ที่ใช้ในการแสดงช่องว่าง
            }
            else if (wordrandom == Word.Badminton)//เทียบค่า wordrandom ว่ามีค่าเท่ากับ Enum Word.Badminton(ค่าเท่ากับ1)หรือไม่
            {
                ShowBlankOfRandomWord("Badminton");//ถ้าใช่ให้เรียกใช้ method ชื่อ  ShowBlankOfRandomWord() ซึ่งเป็น medthod ที่ใช้ในการแสดงช่องว่าง
            }

        }
        static void ShowBlankOfRandomWord(string currentword)
        {
            char[] Blanks = new char[currentword.Length]; //ตั้งตัวแปรอาร์เรย์ของตัวอักษรชื่อ Blanks ขนาดเท่าความยาวของข้อความที่แรนด้อมได้
            for (int i = 0; i < currentword.Length; i++) //ใช้ loop for วนจนกว่าค่าiจะเท่ากับความยาวของข้อความที่แรนด้อมได้
            {
                Console.Write("_ ");//แสดงข้อความ _
                Blanks[i] = '_'; //เก็บค่า _ ซึ่งเป็นสัญลักษณ์แทนช่องว่างไว้ใน อารเรย์ชื่อ Blanks
            }

            Console.WriteLine();//เว้นบรรทัด
            Console.WriteLine();//เว้นบรรทัด

            InputLetterAlphabetFromKeyBoard(currentword, Blanks);/*เรียกใช้ medthod ที่ชื่อว่า InputLetterAlphabetFromKeyBoard() เป็นmedthod
                                                                   ที่ใช้ในการรับค่าตัวอักษรที่ผู้ใช้กรอกเพื่อเล่น*/
        }
        static void InputLetterAlphabetFromKeyBoard(string currentword, char[] currentblanks)
        {
            string word = currentword; //สร้างตัวแปรประเภท string ชื่อ word มาเก็บค่าของคำที่แรนด้อมได้
            Console.Write("Input letter alphabet : "); //แสดงข้อความ Input letter alphabet : 
            string inputletter = Console.ReadLine(); //รับค่าตัวอักษรที่ผู้ใช้กรอกและเก็บไว้ในตัวแปรinputletter

            CheckCorrectLetter(inputletter, word, currentblanks);/*เรียกใช้ medthod ที่ชื่อว่า CheckCorrectLetter() เป็นmedthod
                                                                   ที่ใช้ในตรวจสอบคำตอบที่ถูกต้อง*/
        }
        static void CheckCorrectLetter(string inputletter, string word, char[] currentblanks)
        {
            Console.Clear();
            PrintHeaderPlayGame();//เรียกใช้ medthod ชื่อ  PrintHeaderPlayGame() เป็น medthod ที่ใช้แสดงข้อความที่บอกว่าเป็นหน้าเล่นเกม
            PrintIncorectScore(-1);//เรียกใช้ medthod ชื่อ  PrintIncorectScore(0) เป็น medthod ที่ใช้แสดงจำนวนที่ผู้ใช้ตอบผิด
            char[] letter = word.ToCharArray(); //สร้างตัวแปรอาร์เรย์ของตัวอักษรชื่อ letter ซึ่งจะเก็บตัวอักษรของคำที่แรนด้อมได้มา
            char[] NewGuessWord = currentblanks; //สร้างตัวแปรอาร์เรย์ของตัวอักษรชื่อ NewGuessWord ซึ่งจะเก็บตัวอักษรของช่องว่างที่เท่ากับจำนวนของอักษรของคำที่แรนด้อมได้
            char[] guessletter = inputletter.ToCharArray(); //สร้างตัวแปรอาร์เรย์ชองตัวอักษรชื่อ guessletter ซึ่งจะเก็บตัวอักษรที่ผู้ใช้กรอกมา
            for (int i = 0; i < word.Length; i++) //ใช้ loop for วนจนกว่าค่าiจะเท่ากับค่าความยาวของคำที่แรนด้อมได้
            {
                if (guessletter[0] == letter[i]) //ตรวจสอบถ้าตัวอักษรที่ผู้ใช้กรอกมาตรงกับอาร์เรย์ตัวที่iของletter(ตัวแปรที่เก็บตัวอักษรของคำที่แรนด้อม)หรือไม่
                {
                    Console.Write(guessletter); //ถ้าใช่ให้แสดงตัวอักษรนั้นออกมา
                    NewGuessWord[i] = guessletter[0]; //นำตัวอักษรที่ผู้ใช้กรอกมาแทนที่ส่งไปในช่องว่างที่ i ของข้อความช่องว่าง
                    Console.Write(" ");//เว้นวรรค
                }
                else if (guessletter[0] != letter[i])//แต่ถ้าไม่ใช่
                {
                    NewGuessWord[i] = NewGuessWord[i]; //ให้แทนที่ค่าช่องว่างที่ i ด้วยตัวของมันเอง หรือหมายความว่าช่องว่างไม่เปลี่ยนแปลง
                    Console.Write("{0} ", NewGuessWord[i]);//แสดงช่องว่างที่i
                }
            }

            string newGuessWord = new string(NewGuessWord);//แปลงตัวแปรNewGuessWord จาก char[] ให้เป็น string และเก็บไว้ในตัวแปร newGuessWord
            string currentblank = new string(currentblanks);//แปลงตัวแปร currentblanks จาก char[] ให้เป็น string และเก็บไว้ในตัวแปร currentblank


            Console.WriteLine("\n");//เว้นบรรทัด
            CheckResult(newGuessWord, word);//เรียกเมธอด CheckResult เพื่อตรวจสอบว่าชนะหรือยัง
            InputLetterAlphabetFromKeyBoard(word, NewGuessWord);/*เรียกใช้ medthod ชื่อ  InputLetterAlphabetFromKeyBoard เป็น medthod 
                                                               ไว้รับค่าอักษรที่ผู้ใช้จะกรอกมาเพื่อเล่นอีกครั้ง*/

        }
        static void CheckResult(string newGuessWord, string word)
        {
            if (newGuessWord == word)//ตรวจว่าข้อความในตัวแปร newGuessWord ตรงกับข้อความที่แรนด้อมไหม
            {
                Console.WriteLine("You win!!");//ถ้าใช่แสดงคำว่า You Win!!
            }
            else
            {
                //ถ้าไม่ใช่ไม่ต้องทำอะไร
            }
        }
    }
}
