namespace _2task
{
    internal class Program
    {
        class MusIns
        {
            #region Areas
            public string Name { get; set; }
            public string Description { get; set; }
            public string History { get; set; }
            #endregion
            #region constr  
            public MusIns()
            {
                Name = null;
                Description = null;
            }
            public MusIns(string name, string description)
            {
                Name = name;
                Description = description;
            }
            #endregion
            #region Meth
            public void Sound() { Console.WriteLine("Base Sound"); }
            public void Show() { Console.WriteLine("Base Show"); }
            public void Desc() { Console.WriteLine("Base Desc"); }
            public void Hist() { Console.WriteLine("Base hist"); }

            #endregion
        }
        class Violin : MusIns
        {
            public new void Sound() { Console.WriteLine("Violin sound"); }
            public new void Show() { Console.WriteLine($"Violin {Name}"); }
            public new void Desc() { Console.WriteLine($"Violin {Description}"); }
            public void Hist() { Console.WriteLine($"Violin {History}"); }
        }
        class Trombone : MusIns
        {
            public new void Sound() { Console.WriteLine($"Trombone sound"); }
            public new void Show() { Console.WriteLine($"Trombone {Name}"); }
            public new void Desc() { Console.WriteLine($"Trombone {Description}"); }
            public void Hist() { Console.WriteLine($"Trombone {History}"); }
        }
        class Ukulele : MusIns
        {
            public new void Sound() { Console.WriteLine("Ukulele sound"); }
            public new void Show() { Console.WriteLine($"Ukulele {Name}"); }    
            public new void Desc() { Console.WriteLine($"Ukulele {Description}"); }
            public void Hist() { Console.WriteLine($"Ukulele {History}"); }
        }
        class Cello : MusIns
        {
            public new void Sound() { Console.WriteLine("Cello sound"); }
            public new void Show() { Console.WriteLine($"Cello {Name}"); }
            public new void Desc() { Console.WriteLine($"Cello {Description}"); }
            public void Hist() { Console.WriteLine($"Cello {History}"); }
        }
        static void Main(string[] args)
        {

        }
    }
}
