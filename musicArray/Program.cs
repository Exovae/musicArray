using System;

namespace MusicProgram
{
    enum MusicGenre
    {
        Rock,
        Pop,
        HipHop,
        Jazz,
        Country
    }

    struct Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        private int length;
        public MusicGenre Genre { get; set; }

        public int Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length must be greater than 0.");
                }
                length = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Album: " + Album);
            Console.WriteLine("Length: " + Length + " minutes");
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    collection[i] = new Music();

                    Console.WriteLine("Please enter the song title:");
                    collection[i].Title = Console.ReadLine();

                    Console.WriteLine("Please enter the song artist:");
                    collection[i].Artist = Console.ReadLine();

                    Console.WriteLine("Please enter the album name:");
                    collection[i].Album = Console.ReadLine();

                    Console.WriteLine("Please enter the song length (in minutes):");
                    collection[i].Length = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the music genre (0-Rock, 1-Pop, 2-HipHop, 3-Jazz, 4-Country):");
                    collection[i].Genre = (MusicGenre)int.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    collection[i].Display();
                }
            }

            Console.ReadKey();
        }
    }
}
