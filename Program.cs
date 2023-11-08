using theLibrary;



//OUR LIBRARIAN BERIT WILL HANDLE USER INPUT 
Librarian Berit = new Librarian();

//OUR LIBRARY WILL HANDLE ADD, DELETE, AND SHOWING BOOKS
Library library = new Library();

//OUR BOOK WILL COLLECT INFO EACH INDIVIDUAL BOOKS
Book StoryAboutACat = new Book("Story about a cat", 94767399, "Lord Hopfceinstain", false);
library.addABook(StoryAboutACat);
Book StoryAboutADog = new Book("Story about a dog", 94764289, "Lady Noseface", false);
library.addABook(StoryAboutADog);
Book StoryAboutAFish = new Book("Story about a fish", 94762574, "Snofs Lishter", true);
library.addABook(StoryAboutAFish);

//PUT BOOKS IN LIBRARY LIST
int runLibrary = 1;
Console.WriteLine("Welcome, welcome to da greatest library in da world.");

// --------------------------PROGRAM START----------------------------------
do
{

Berit.askWhatToDo();
string answer = Console.ReadLine();
if (answer == null) Berit.askWhatToDo();
Berit.deteremenWhatToDoo(library, answer);
Console.WriteLine("exit? y/n");
string exitchoice = Console.ReadLine();
    if (exitchoice == null) continue;
    if (exitchoice == "y") runLibrary--;

} while (runLibrary == 1);
