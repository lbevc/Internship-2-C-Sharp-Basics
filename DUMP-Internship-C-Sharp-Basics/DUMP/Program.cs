using System;
using System.Collections.Generic;

namespace DUMP
{
    class Program
    {
        public static void WriteOutPlaylist(Dictionary<int,string> playlist)
        {
            Console.WriteLine("Izabrali ste ispis cijele liste:");

            foreach (var pair in playlist)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }

        public static void NameOfSong(Dictionary<int, string> playlist)
        {
            var t=0;
           

            Console.WriteLine("Unesite redni broj pjesme cije ime zelite:");
            var numberOfSong = int.Parse(Console.ReadLine());

            foreach(var pair in playlist)
            {
                if (numberOfSong == pair.Key)
                    t ++;
               
            }

            if(t==0)
            {
                Console.WriteLine("Ne  postoji pjesma pod rednim brojem koji ste unijeli, pritisnite 1 za ponovni unos ili 2 za povratak na izbornik.");
                var i = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    Console.WriteLine("Unesite redni broj pjesme cije ime zelite:");
                    numberOfSong = int.Parse(Console.ReadLine());

                }
                else if (i == 2)
                {
                    Console.WriteLine("Odaberite akciju:");
                    Console.WriteLine("1 - Ispis cijele liste");
                    Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                    Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                    Console.WriteLine("4 - Unos nove pjesme");
                    Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                    Console.WriteLine("6 - Brisanje pjesme po imenu");
                    Console.WriteLine("7 - Brisanje cijele liste");
                    Console.WriteLine("8 - Uredivanje imena pjesme");
                    Console.WriteLine("Uredivanje rednog broja pjesme");
                    Console.WriteLine("0 - izlaz iz aplikacije");

                    var returnedValue = int.Parse(Console.ReadLine());

                    switch (returnedValue)
                    {
                        case 1:
                            WriteOutPlaylist(playlist);
                            break;
                        case 2:
                            NameOfSong(playlist);
                            break;
                        case 3:
                            NumberOfSong(playlist);
                            break;
                        case 4:
                            InsertOfNewSong(playlist);
                            break;
                        case 5:
                            DeleteSongByNumber(playlist);
                            break;
                        case 6:
                            DeleteSongByName(playlist);
                            break;
                        case 7:
                            DeleteWholePlaylist(playlist);
                            break;
                        case 8:
                            EditingSongName(playlist);
                            break;
                        case 9:
                            EditNumberOfSong(playlist);
                            break;
                        case 0:
                            break;

                    }
                }
            }

            Console.WriteLine("ime pjesme pod rednim brojem {0}. je:{1}", numberOfSong, playlist[numberOfSong]);
        }

        public static void NumberOfSong(Dictionary<int, string> playlist)
        {
            var t = 0;

            Console.WriteLine("Unesite ime pjesme ciji redni broj zelite:");
            var nameOfSong = Console.ReadLine();

            foreach (var pair in playlist)
            {
                if (nameOfSong == pair.Value)
                
                    Console.WriteLine("Redni broj pjesme je:{0}", pair.Key);
                
                else
                    t++;
            }
            if(t!=0)
            {
                Console.WriteLine("Ne  postoji pjesma s imenom kojeg ste unijeli, pritisnite 1 za ponovni unos ili 2 za povratak na izbornik.");
                var i = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    Console.WriteLine("Unesite redni broj pjesme cije ime zelite:");
                    nameOfSong = Console.ReadLine();
                    foreach (var pair in playlist)
                    {
                        if (nameOfSong == pair.Value)

                            Console.WriteLine("Redni broj pjesme je:{0}", pair.Key);

                        
                    }

                }
                else if (i == 2)
                {
                    Console.WriteLine("Odaberite akciju:");
                    Console.WriteLine("1 - Ispis cijele liste");
                    Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                    Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                    Console.WriteLine("4 - Unos nove pjesme");
                    Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                    Console.WriteLine("6 - Brisanje pjesme po imenu");
                    Console.WriteLine("7 - Brisanje cijele liste");
                    Console.WriteLine("8 - Uredivanje imena pjesme");
                    Console.WriteLine("Uredivanje rednog broja pjesme");
                    Console.WriteLine("0 - izlaz iz aplikacije");

                    var returnedValue = int.Parse(Console.ReadLine());

                    switch (returnedValue)
                    {
                        case 1:
                            WriteOutPlaylist(playlist);
                            break;
                        case 2:
                            NameOfSong(playlist);
                            break;
                        case 3:
                            NumberOfSong(playlist);
                            break;
                        case 4:
                            InsertOfNewSong(playlist);
                            break;
                        case 5:
                            DeleteSongByNumber(playlist);
                            break;
                        case 6:
                            DeleteSongByName(playlist);
                            break;
                        case 7:
                            DeleteWholePlaylist(playlist);
                            break;
                        case 8:
                            EditingSongName(playlist);
                            break;
                        case 9:
                            EditNumberOfSong(playlist);
                            break;
                        case 0:
                            break;

                    }
                }

            }
        }

        public static void InsertOfNewSong(Dictionary<int,string>playlist)
        {
            Console.WriteLine("Unesite ime pjesme po Vasem izboru:");
            var song = Console.ReadLine();

            playlist[9] = song;

            foreach (var pair in playlist)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

        }

        public static void DeleteSongByNumber(Dictionary<int, string> playlist)
        {
            var t = 0;

            Console.WriteLine("Unesite redni broj pjesme koju zelite izbrisati:");
            var numberOfSong = int.Parse(Console.ReadLine());
            Console.WriteLine("Jeste li sigurni da zelite izbrisati pjesmu pod rednim brojem:{0}? (upisite da ako ste sigurni)",numberOfSong);
            var answer = Console.ReadLine();

            if (answer == "da")
            {
                foreach (var pair in playlist)
                {
                    if (numberOfSong == pair.Key)
                        t++;

                }

                if (t != 0)
                {
                    playlist.Remove(numberOfSong);
                    foreach (var pair in playlist)
                    {
                        Console.WriteLine(pair.Key + " " + pair.Value);
                    }

                }
                else
                {
                    Console.WriteLine("Ne  postoji pjesma s rednim brojem kojeg ste unijeli, pritisnite 1 za ponovni unos ili 2 za povratak na izbornik.");
                    var i = int.Parse(Console.ReadLine());

                    if (i == 1)
                    {
                        Console.WriteLine("Unesite redni broj pjesme cije ime zelite:");
                        numberOfSong = int.Parse(Console.ReadLine());

                        playlist.Remove(numberOfSong);

                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Odaberite akciju:");
                        Console.WriteLine("1 - Ispis cijele liste");
                        Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                        Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                        Console.WriteLine("4 - Unos nove pjesme");
                        Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                        Console.WriteLine("6 - Brisanje pjesme po imenu");
                        Console.WriteLine("7 - Brisanje cijele liste");
                        Console.WriteLine("8 - Uredivanje imena pjesme");
                        Console.WriteLine("Uredivanje rednog broja pjesme");
                        Console.WriteLine("0 - izlaz iz aplikacije");

                        var returnedValue = int.Parse(Console.ReadLine());

                        switch (returnedValue)
                        {
                            case 1:
                                WriteOutPlaylist(playlist);
                                break;
                            case 2:
                                NameOfSong(playlist);
                                break;
                            case 3:
                                NumberOfSong(playlist);
                                break;
                            case 4:
                                InsertOfNewSong(playlist);
                                break;
                            case 5:
                                DeleteSongByNumber(playlist);
                                break;
                            case 6:
                                DeleteSongByName(playlist);
                                break;
                            case 7:
                                DeleteWholePlaylist(playlist);
                                break;
                            case 8:
                                EditingSongName(playlist);
                                break;
                            case 9:
                                EditNumberOfSong(playlist);
                                break;
                            case 0:
                                break;

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Odaberite akciju:");
                Console.WriteLine("1 - Ispis cijele liste");
                Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                Console.WriteLine("4 - Unos nove pjesme");
                Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                Console.WriteLine("6 - Brisanje pjesme po imenu");
                Console.WriteLine("7 - Brisanje cijele liste");
                Console.WriteLine("8 - Uredivanje imena pjesme");
                Console.WriteLine("Uredivanje rednog broja pjesme");
                Console.WriteLine("0 - izlaz iz aplikacije");

                var returnedValue = int.Parse(Console.ReadLine());

                switch (returnedValue)
                {
                    case 1:
                        WriteOutPlaylist(playlist);
                        break;
                    case 2:
                        NameOfSong(playlist);
                        break;
                    case 3:
                        NumberOfSong(playlist);
                        break;
                    case 4:
                        InsertOfNewSong(playlist);
                        break;
                    case 5:
                        DeleteSongByNumber(playlist);
                        break;
                    case 6:
                        DeleteSongByName(playlist);
                        break;
                    case 7:
                        DeleteWholePlaylist(playlist);
                        break;
                    case 8:
                        EditingSongName(playlist);
                        break;
                    case 9:
                        EditNumberOfSong(playlist);
                        break;
                    case 0:
                        break;

                }
            }

        }

        public static void DeleteSongByName(Dictionary<int,string>playlist)
        {
            var t = 0;
            var temp=0;

            Console.WriteLine("Unesite ime pjesme koju zelite izbrisati:");
            var nameOfSong = Console.ReadLine();
            Console.WriteLine("Jeste li sigurni da zelite izbrisati pjesmu pod imenom:{0}? (upisite da ako ste sigurni)", nameOfSong);
            var answer = Console.ReadLine();

            if (answer == "da")
            {
                foreach (var pair in playlist)
                {
                    if (nameOfSong == pair.Value)
                        t++;

                }

                if (t != 0)
                {
                    foreach (var pair in playlist)
                    {
                        if (nameOfSong == pair.Value)
                            temp = pair.Key;
                    }

                    playlist.Remove(temp);
                    foreach (var pair in playlist)
                    {
                        Console.WriteLine(pair.Key + " " + pair.Value);
                    }

                }
                else
                {
                    Console.WriteLine("Ne  postoji pjesma s imenom kojeg ste unijeli, pritisnite 1 za ponovni unos ili 2 za povratak na izbornik.");
                    var i = int.Parse(Console.ReadLine());

                    if (i == 1)
                    {
                        Console.WriteLine("Unesite redni broj pjesme cije ime zelite:");
                        nameOfSong = Console.ReadLine();

                        foreach (var pair in playlist)
                        {
                            if (nameOfSong == pair.Value)
                                temp = pair.Key;
                        }

                        playlist.Remove(temp);
                        foreach (var pair in playlist)
                        {
                            Console.WriteLine(pair.Key + " " + pair.Value);
                        }

                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Odaberite akciju:");
                        Console.WriteLine("1 - Ispis cijele liste");
                        Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                        Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                        Console.WriteLine("4 - Unos nove pjesme");
                        Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                        Console.WriteLine("6 - Brisanje pjesme po imenu");
                        Console.WriteLine("7 - Brisanje cijele liste");
                        Console.WriteLine("8 - Uredivanje imena pjesme");
                        Console.WriteLine("Uredivanje rednog broja pjesme");
                        Console.WriteLine("0 - izlaz iz aplikacije");

                        var returnedValue = int.Parse(Console.ReadLine());

                        switch (returnedValue)
                        {
                            case 1:
                                WriteOutPlaylist(playlist);
                                break;
                            case 2:
                                NameOfSong(playlist);
                                break;
                            case 3:
                                NumberOfSong(playlist);
                                break;
                            case 4:
                                InsertOfNewSong(playlist);
                                break;
                            case 5:
                                DeleteSongByNumber(playlist);
                                break;
                            case 6:
                                DeleteSongByName(playlist);
                                break;
                            case 7:
                                DeleteWholePlaylist(playlist);
                                break;
                            case 8:
                                EditingSongName(playlist);
                                break;
                            case 9:
                                EditNumberOfSong(playlist);
                                break;
                            case 0:
                                break;

                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("Odaberite akciju:");
                Console.WriteLine("1 - Ispis cijele liste");
                Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                Console.WriteLine("4 - Unos nove pjesme");
                Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                Console.WriteLine("6 - Brisanje pjesme po imenu");
                Console.WriteLine("7 - Brisanje cijele liste");
                Console.WriteLine("8 - Uredivanje imena pjesme");
                Console.WriteLine("Uredivanje rednog broja pjesme");
                Console.WriteLine("0 - izlaz iz aplikacije");

                var returnedValue = int.Parse(Console.ReadLine());

                switch (returnedValue)
                {
                    case 1:
                        WriteOutPlaylist(playlist);
                        break;
                    case 2:
                        NameOfSong(playlist);
                        break;
                    case 3:
                        NumberOfSong(playlist);
                        break;
                    case 4:
                        InsertOfNewSong(playlist);
                        break;
                    case 5:
                        DeleteSongByNumber(playlist);
                        break;
                    case 6:
                        DeleteSongByName(playlist);
                        break;
                    case 7:
                        DeleteWholePlaylist(playlist);
                        break;
                    case 8:
                        EditingSongName(playlist);
                        break;
                    case 9:
                        EditNumberOfSong(playlist);
                        break;
                    case 0:
                        break;

                }
            }

        }

        public static void DeleteWholePlaylist(Dictionary<int,string> playlist)
        {
            Console.WriteLine("Jeste li sigurni da zelite izbrisati cijelu playlist?(upisite da ako jeste)");
            var answer = Console.ReadLine();

            if(answer=="da")
            {
                playlist.Clear();
                foreach(var pair in playlist)
                {
                    Console.WriteLine(pair.Key+" "+pair.Value);
                }
            }
            else
            {
                Console.WriteLine("Odaberite akciju:");
                Console.WriteLine("1 - Ispis cijele liste");
                Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                Console.WriteLine("4 - Unos nove pjesme");
                Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                Console.WriteLine("6 - Brisanje pjesme po imenu");
                Console.WriteLine("7 - Brisanje cijele liste");
                Console.WriteLine("8 - Uredivanje imena pjesme");
                Console.WriteLine("Uredivanje rednog broja pjesme");
                Console.WriteLine("0 - izlaz iz aplikacije");

                var returnedValue = int.Parse(Console.ReadLine());

                switch (returnedValue)
                {
                    case 1:
                        WriteOutPlaylist(playlist);
                        break;
                    case 2:
                        NameOfSong(playlist);
                        break;
                    case 3:
                        NumberOfSong(playlist);
                        break;
                    case 4:
                        InsertOfNewSong(playlist);
                        break;
                    case 5:
                        DeleteSongByNumber(playlist);
                        break;
                    case 6:
                        DeleteSongByName(playlist);
                        break;
                    case 7:
                        DeleteWholePlaylist(playlist);
                        break;
                    case 8:
                        EditingSongName(playlist);
                        break;
                    case 9:
                        EditNumberOfSong(playlist);
                        break;
                    case 0:
                        break;

                }
            }
        }

        public static void EditingSongName(Dictionary<int,string>playlist)
        {
            var t = 0;
            Console.WriteLine("upisite redni broj pjesme cije ime zelite urediti:");
            var numberOfSong = int.Parse(Console.ReadLine());

            Console.WriteLine("jeste li sigurni da zelite urediti ime pjesme pod rednim brojem:{0}?(unesite da ako jeste)", numberOfSong);
            var answer = Console.ReadLine();
            if(answer=="da")
            {
                foreach(var pair in playlist)
                {
                    if (numberOfSong == pair.Key)
                        t++;
                }
                if (t != 0)
                {
                    Console.WriteLine("Upisite ime koje zelite pjesme pod rednim brojem {0}.", numberOfSong);
                    var newSongName = Console.ReadLine();

                    playlist[numberOfSong] = newSongName;

                    foreach (var pair in playlist)
                    {
                        Console.WriteLine(pair.Key + " " + pair.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Ne  postoji pjesma s rednim brojem kojeg ste unijeli, pritisnite 1 za ponovni unos ili 2 za povratak na izbornik.");
                    var i = int.Parse(Console.ReadLine());

                    if (i == 1)
                    {
                        Console.WriteLine("Unesite redni broj pjesme cije ime zelite:");
                        numberOfSong = int.Parse(Console.ReadLine());

                        playlist.Remove(numberOfSong);

                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Odaberite akciju:");
                        Console.WriteLine("1 - Ispis cijele liste");
                        Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                        Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                        Console.WriteLine("4 - Unos nove pjesme");
                        Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                        Console.WriteLine("6 - Brisanje pjesme po imenu");
                        Console.WriteLine("7 - Brisanje cijele liste");
                        Console.WriteLine("8 - Uredivanje imena pjesme");
                        Console.WriteLine("Uredivanje rednog broja pjesme");
                        Console.WriteLine("0 - izlaz iz aplikacije");

                        var returnedValue = int.Parse(Console.ReadLine());

                        switch (returnedValue)
                        {
                            case 1:
                                WriteOutPlaylist(playlist);
                                break;
                            case 2:
                                NameOfSong(playlist);
                                break;
                            case 3:
                                NumberOfSong(playlist);
                                break;
                            case 4:
                                InsertOfNewSong(playlist);
                                break;
                            case 5:
                                DeleteSongByNumber(playlist);
                                break;
                            case 6:
                                DeleteSongByName(playlist);
                                break;
                            case 7:
                                DeleteWholePlaylist(playlist);
                                break;
                            case 8:
                                EditingSongName(playlist);
                                break;
                            case 9:
                                EditNumberOfSong(playlist);
                                break;
                            case 0:
                                break;

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Odaberite akciju:");
                Console.WriteLine("1 - Ispis cijele liste");
                Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
                Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
                Console.WriteLine("4 - Unos nove pjesme");
                Console.WriteLine("5 - Brisanje pjesme po rednom broju");
                Console.WriteLine("6 - Brisanje pjesme po imenu");
                Console.WriteLine("7 - Brisanje cijele liste");
                Console.WriteLine("8 - Uredivanje imena pjesme");
                Console.WriteLine("Uredivanje rednog broja pjesme");
                Console.WriteLine("0 - izlaz iz aplikacije");

                var returnedValue = int.Parse(Console.ReadLine());

                switch (returnedValue)
                {
                    case 1:
                        WriteOutPlaylist(playlist);
                        break;
                    case 2:
                        NameOfSong(playlist);
                        break;
                    case 3:
                        NumberOfSong(playlist);
                        break;
                    case 4:
                        InsertOfNewSong(playlist);
                        break;
                    case 5:
                        DeleteSongByNumber(playlist);
                        break;
                    case 6:
                        DeleteSongByName(playlist);
                        break;
                    case 7:
                        DeleteWholePlaylist(playlist);
                        break;
                    case 8:
                        EditingSongName(playlist);
                        break;
                    case 9:
                        EditNumberOfSong(playlist);
                        break;
                    case 0:
                        break;

                }
            }

        }

        public static void EditNumberOfSong(Dictionary<int,string>playlist)
        {
            

            Console.WriteLine("Unesite redni broj pjesme koju zelite premjestiti:");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite redni broj na koji zelite premjestiti tu pjesmu:");
            var secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("jeste li sigurni da zelite premjestiti pjesmu s rednog broja {0}. na redni broj {1}?(unesite da ako jeste)",firstNumber,secondNumber);
            var answer = Console.ReadLine();

            if (answer == "da")
            {
                
                    var temp = playlist[firstNumber];

                    for (int i = firstNumber; i < secondNumber; i++)
                    {
                        playlist[i] = playlist[i + 1];
                    }

                    playlist[secondNumber] = temp;

                    foreach (var pair in playlist)
                    {
                        Console.WriteLine(pair.Key + " " + pair.Value);
                    }
                
                
            }  

        }

        static void Main()
        {
            var playlist = new Dictionary<int, string>()
            {
                {1, "Whole Lotta Love" },
                {2, "Anarchist" },
                {3, "Dancing Queen" },
                {4, "Killer Queen" },
                {5, "Trooper" },
                {6, "Kiwi" },
                {7, "Do I Wanna Know" },
                {8, "Mamma Mia" }
            };
            Console.WriteLine("Odaberite akciju:");
            Console.WriteLine("1 - Ispis cijele liste");
            Console.WriteLine("2 - Ispis imena pjesme unosom pripadajuceg rednog broja");
            Console.WriteLine("3 - Ispis rednog broja pjesme unosom pripadajuceg imena");
            Console.WriteLine("4 - Unos nove pjesme");
            Console.WriteLine("5 - Brisanje pjesme po rednom broju");
            Console.WriteLine("6 - Brisanje pjesme po imenu");
            Console.WriteLine("7 - Brisanje cijele liste");
            Console.WriteLine("8 - Uredivanje imena pjesme");
            Console.WriteLine("9 - Uredivanje rednog broja pjesme");
            Console.WriteLine("0 - izlaz iz aplikacije");

            var returnedValue = int.Parse(Console.ReadLine());

            switch(returnedValue)
            {
                case 1:
                    WriteOutPlaylist(playlist);
                    break;
                case 2:
                   NameOfSong(playlist);
                    break;
                case 3:
                    NumberOfSong(playlist);
                    break;
                case 4:
                    InsertOfNewSong(playlist);
                    break;
                case 5:
                    DeleteSongByNumber(playlist);
                    break;
                case 6:
                    DeleteSongByName(playlist);
                    break;
                case 7:
                    DeleteWholePlaylist(playlist);
                    break;
                case 8:
                    EditingSongName(playlist);
                    break;
                case 9:
                    EditNumberOfSong(playlist);
                    break;
                case 0:
                    break;


            }
        }
    }
}
