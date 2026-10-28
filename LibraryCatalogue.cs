//input 1 //////////////////////////////////////////
//Space Adventures, Ronnie Johnson, Science Fiction
////////////////////////////////////////////////////

// expected output 1 ///////////////////////////
// You have selected genre: science fiction
// There are 1 books in this genre
// ------------------------------------------------------
// Book Title: space adventures
// Book Author: ronnie johnson
// --------------------------------------------------
////////////////////////////////////////////////

// actual output 1 /////////////////////////////
// You have selected genre: science fiction
// There are 1 books in this genre
// ------------------------------------------------------
// Book Title: space adventures
// Book Author: ronnie johnson
// --------------------------------------------------
///////////////////////////////////////////////////





// input 2 //////////////////////////////////
// Joe in Space, Aisha Khan, Science Fiction
/////////////////////////////////////////////

// expected output 2 ///////////////////////////
// You have selected genre: science fiction
// There are 2 books in this genre
// ------------------------------------------------------
// Book Title: space adventures
// Book Author: ronnie johnson
// --------------------------------------------------
// Book Title: joe in space
// Book Author: aisha khan
// --------------------------------------------------
////////////////////////////////////////////////

// actual output 2 ///////////////////////////
// You have selected genre: science fiction
// There are 2 books in this genre
// ------------------------------------------------------
// Book Title: space adventures
// Book Author: ronnie johnson
// --------------------------------------------------
// Book Title: joe in space
// Book Author: aisha khan
// --------------------------------------------------
////////////////////////////////////////////////





// input 3///////////////////////////////////////////
// The Dragons, Michelle Smith, Fantasy
/////////////////////////////////////////////////////

// expected output 3 /////////////////////////////
// You have selected genre: fantasy
// There are 1 books in this genre
// ------------------------------------------------------
// Book Title: the dragons
// Book Author: michelle smith
// --------------------------------------------------
///////////////////////////////////////////////////

// actual output 3 /////////////////////////////
// You have selected genre: fantasy
// There are 1 books in this genre
// ------------------------------------------------------
// Book Title: the dragons
// Book Author: michelle smith
// --------------------------------------------------
///////////////////////////////////////////////////




// input 4 /////////
// when nothing has been added
///////////////////

// expected ouput 4/////
// No books have been added into the library yet!!
//////////////////////

// actual ouput 4/////
// No books have been added into the library yet!!
//////////////////////




// input 5 ////////////
// view all books
////////////////////////

// expected output 5////////////////////
//You have selected genre: all
// There are 3 books in this genre
// ------------------------------------------------------
// Book Title: space adventures
// Book Author: ronnie johnson
// --------------------------------------------------
// Book Title: joe in space
// Book Author: aisha khan
// --------------------------------------------------
// Book Title: the dragons
// Book Author: michelle smith
// --------------------------------------------------
/////////////////////////////////////////////////////////

// actual output 5////////////////////
//You have selected genre: all
// There are 3 books in this genre
// ------------------------------------------------------
// Book Title: space adventures
// Book Author: ronnie johnson
// --------------------------------------------------
// Book Title: joe in space
// Book Author: aisha khan
// --------------------------------------------------
// Book Title: the dragons
// Book Author: michelle smith
// --------------------------------------------------
/////////////////////////////////////////////////////////

namespace coursework
{
    //new file to keep everything seperate
    //creating libraryCatalogue class
    public class LibraryCatalogue
    {
        public static void Run()
        {
            //creates a list to store all books
            List<Book> books = new List<Book>();

            //ask user again if inputs invalid
            bool askAgain=true;
            while (askAgain)
            {
                Console.WriteLine("Would you to add or view books?");
                string addOrView=Console.ReadLine().Trim().ToLower();

                // if add is typed in:
                if(addOrView=="add")
                {
                    bool addMore=true;

                    //while loop to make sure user enters valid input
                    while (addMore)
                    {
                        string bookType;

                        //asks user again if inputs invalid
                        bool bookTypeValid=true;
                        do{
                            Console.WriteLine("Select Type of Book (F/N)");
                            Console.WriteLine("Fiction");
                            Console.WriteLine("Non-Fiction");

                            bookType=Console.ReadLine().Trim().ToUpper();

                            if (bookType=="F")
                            {
                                bookType="Fiction";
                                bookTypeValid=false;
                            }
                            else if (bookType=="N") 
                            {
                                bookType="Non-Fiction";
                                bookTypeValid=false;
                            }
                            else
                            {
                            Console.WriteLine("Invalid Input!");
                            }
                        } while(bookTypeValid);

                        Console.WriteLine($"You have selected: {bookType}");

                        string  title, author, genre;
                        bool notBlank=true;
                        do
                        {
                            Console.WriteLine("Enter Book Title: ");
                            title=Console.ReadLine().Trim();

                            Console.WriteLine("Enter Book Author: ");
                            author=Console.ReadLine().Trim();

                            Console.WriteLine("Enter Genre: ");
                            genre=Console.ReadLine().Trim();

                            if (string.IsNullOrEmpty(title))
                            {
                                Console.WriteLine("You have not provided a book title.");
                                Console.WriteLine("Please enter a book title!");
                            }
                            else if (string.IsNullOrEmpty(author))
                            {
                                Console.WriteLine("You have not provided an author.");
                                Console.WriteLine("Please enter an author!");
                            }
                            else if (string.IsNullOrEmpty(genre))
                            {
                                Console.WriteLine("You have not provided a genre.");
                                Console.WriteLine("Please enter a genre!");
                            }
                            else
                            {
                                notBlank=false;
                            }
                        }while(notBlank);

                        //creates list to put new books into
                        Book newBook =new Book(title, author, genre, bookType);
                        //adds new books to the list
                        books.Add(newBook);

                        bool againValid=true;
                        do
                        {
                            Console.WriteLine("Do you want to add details for another book? (yes/no)");
                            Console.WriteLine("Or if you would like the return to the menu type: exit");
                            string again=Console.ReadLine().Trim().ToLower();
                            
                            if (again=="no")
                            {
                                addMore=false;
                                againValid=false; 
                            }
                            else if(again=="exit")
                            {
                                addMore=false;
                                askAgain=false; 
                                againValid=false; 
                            }
                            else if (again == "yes")
                            {
                              againValid=false;  
                            }
                            else
                            {
                                Console.WriteLine("Invalid input \nPlease enter a valid input!");
                            }
                        }while(againValid);
                    }
                }

                else if (addOrView=="view")
                {
                    //if theres no books in the list then it will say that
                    if (books.Count==0)
                    {
                        Console.WriteLine("No books have been added into the library yet!!");
                    }
                    else if (books.Count>0)
                    {

                        //loop to ask again if input is invalid
                        string selectType;
                        bool selectTypeNotValid=true;
                        do{
                            Console.WriteLine("Select book type (F/N)");
                            Console.WriteLine("Fiction");
                            Console.WriteLine("Non-Fiction");
                            selectType=Console.ReadLine().Trim().ToUpper();

                            if (selectType=="F")
                            {
                                selectType="Fiction";
                                selectTypeNotValid=false;
                            }
                            else if(selectType=="N")
                            {
                                selectType="Non-Fiction";
                                selectTypeNotValid=false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input!");
                            }
                        }while(selectTypeNotValid);

                        //loop through every book in collection
                        List<string> genres= new List<string>();
                        foreach(Book b in books)
                        {
                            //only consider books from the selected type by the user
                            if (b.TypeOfBook==selectType)
                            {
                                //if the genre is not in the list add it to the list
                                if (genres.Contains(b.Genre)==false)
                                {
                                    genres.Add(b.Genre);
                                }
                            }
                        }

                        //lists all the genres in the selected book type
                        Console.WriteLine("Please select a genre: ");
                        foreach (string g in genres)
                        {
                            Console.WriteLine($"-{g}");
                        }
                        Console.WriteLine("-All");

                        string selectedGenre=Console.ReadLine().Trim().ToLower();

                        Console.WriteLine($"You have selected the genre: {selectedGenre}");
                        Console.WriteLine();

                        //creating list to be able to list books by genre
                        List<Book> filteredBooks = new List<Book>();

                        //goes through all books and adds them to filteredBooks depending on the chosen genre
                        foreach (Book b in books)
                        {
                            //check if this book is the same type the user selected
                            if (b.TypeOfBook==selectType)
                            {
                                //adds all books within the selected type to filteredBooks
                                if (selectedGenre=="all")
                                {
                                    filteredBooks.Add(b);
                                }
                                else
                                {
                                    //makes sure only books in the selected genre are added to filteredBooks
                                    if (b.Genre.ToLower()==selectedGenre.ToLower())
                                    {
                                        filteredBooks.Add(b);
                                    }
                                }
                            }        
                        }

                        Console.WriteLine($"You have selected genre: {selectedGenre}");
                        //tells the user how many books in thier chosen genre there are
                        Console.WriteLine($"There are {filteredBooks.Count} books in this genre");
                        Console.WriteLine("------------------------------------------------------");

                        //lists all the books in the chosen genre
                        foreach (Book b in filteredBooks)
                        {
                            Console.WriteLine($"Book Title: {b.Title}");
                            Console.WriteLine($"Book Author: {b.Author}");
                            Console.WriteLine("--------------------------------------------------");
                        }

                        Console.WriteLine("Would you like to return to the menu? (yes/no)");
                        string menuReturn=Console.ReadLine().Trim().ToLower();

                        if (menuReturn=="no")
                        {
                            askAgain=true;
                        }
                        else if (menuReturn=="yes")
                        {
                            askAgain=false;
                        }
                    }
                }
                //if user enters something thats not add or view
                //repeats add or view statement
                else
                {
                    Console.WriteLine("Invalid Input!!! \n Enter add or view!!");
                }
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author {get; set; }
        public string Genre { get;set; }
        public string TypeOfBook { get; set; } 

        public Book(string title, string author, string genre, string typeOfBook)
        {
            Title=title;
            Author=author;
            Genre=genre;
            TypeOfBook=typeOfBook;
        }
    }
}