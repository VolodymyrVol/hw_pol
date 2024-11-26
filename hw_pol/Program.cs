using System.Security.Cryptography.X509Certificates;

namespace hw_pol
{
    class Device
    {
        #region Areas
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion
        #region constr  
        public Device()
        {
            Name = null;
            Description = null;
        }
        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }
        #endregion
        #region Meth
        public void Sound() { Console.WriteLine("Base Sound"); }
        public void Show() { Console.WriteLine("Base Show"); }
        public void Desc() { Console.WriteLine("Base Desc"); }

        #endregion
    }
    class Teapot : Device
    {
        public new void Sound() { Console.WriteLine("Teapot sound"); }
        public new void Show() { Console.WriteLine($"Teapot {Name}"); }
        public new void Desc() { Console.WriteLine($"Teapot {Description}"); }
    }
    class Auto : Device
    {
        public new void Sound() { Console.WriteLine($"Auto sound"); }
        public new void Show() { Console.WriteLine($"Auto {Name}"); }
        public new void Desc() { Console.WriteLine($"Auto {Description}"); }
    }
    class Microv : Device
    {
        public new void Sound() { Console.WriteLine("Microv sound"); }
        public new void Show() { Console.WriteLine($"Microv {Name}"); }
        public new void Desc() { Console.WriteLine($"Microv {Description}"); }
    }
    class Steamship : Device
    {
        public new void Sound() { Console.WriteLine("Steamship sound"); }
        public new void Show() { Console.WriteLine($"Steamship {Name}"); }
        public new void Desc() { Console.WriteLine($"Steamship {Description}"); }
    }

    internal class Program
        {
        }   
  }
