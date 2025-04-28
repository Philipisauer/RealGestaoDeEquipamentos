using RealGestaoDeEquipamentos.ConsoleApp.ModuloEquipament;

namespace RealGestaoDeEquipamentos.ConsoleApp.ModuloChamados
{
    public class Calls
    {
        public int Id;
        public string Title;
        public string Description;
        public Equipment Equipment;
        public DateTime DateOfOpening;

    public Calls(string title, string description, Equipment equipment)
        {
            Title = title;
            Description = description;
            Equipment = equipment;
            DateOfOpening = DateTime.Now;
        }

        public int GetTime()
        {
            TimeSpan ElepsedTime = DateTime.Now.Subtract(DateOfOpening);
                return ElepsedTime.Days;
        }
    }
}
