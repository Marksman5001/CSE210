using System;
using System.Threading;
using System.Xml.Serialization;
//some of the intention with this program was to make the classes reusable, i didn't want them to be overly specific, so that if (in theory)
//I wanted to reuse the classes for different applications, I wouldn't have to remake the class. Therefore, program handles a lot more than normal.
class Program 
{
    static void Main(string[] args)
    {
        Console.Clear();
        //reads a scripture from a file, as per the stretch challenge
        string text =File.ReadAllText("scriptures.txt");
        List<Word> words = new List<Word>();
        for(int i=0; i<text.Split(",").Length; i++){
            Word word = new Word(text.Split(",")[i]);
            words.Add(word);
        }
        Reference reference = new Reference("James", 1, 5);
        Scripture scripture = new Scripture(reference, words);
        Random rand = new Random();
        bool allhiden=false;
        string userinput = "";
        System.Console.WriteLine("Welcome to the scripture memorizer!");
        Thread.Sleep(2000);
        //used for making sure only non-hidden words are called to hide, as stretch challenge
        List<Word> nothiddenwords = new List<Word>(words);
        while(!allhiden && userinput!="quit"){
            Console.Clear();
            allhiden=true;
            if(scripture.GetReference().GetStart()==scripture.GetReference().GetEnd()){
                System.Console.WriteLine($"{scripture.GetReference().GetBook()}: {scripture.GetReference().GetChapter()}, {scripture.GetReference().GetStart()}");
            }
            else{
                System.Console.WriteLine($"{scripture.GetReference().GetBook()}: {scripture.GetReference().GetChapter()}, {scripture.GetReference().GetStart()}-{scripture.GetReference().GetEnd()}");
            }
            foreach(Word word in scripture.GetWords()){
                System.Console.Write($"{word.GetText()} ");
                if(!word.IsHidden()){
                    allhiden=false;
                }
                
            }
            if(nothiddenwords.Count==0){
                    break;
                }
            System.Console.WriteLine();
            System.Console.WriteLine("Prese enter or type 'quit' to quit");
            userinput=System.Console.ReadLine();
           

            for(int i=5; i>0; i--){
                int index =rand.Next(0, nothiddenwords.Count);
                if(index<nothiddenwords.Count){
                    nothiddenwords[index].Hide();
                    foreach(Word word in scripture.GetWords()){
                        if(word==nothiddenwords[index]){
                            word.Hide();
                        }
                    }
                    nothiddenwords.RemoveAt(index);
                    //ensures the program ends properly
                    if(nothiddenwords.Count==0){
                        break;
                    }
                }
            }
        }
    }
}