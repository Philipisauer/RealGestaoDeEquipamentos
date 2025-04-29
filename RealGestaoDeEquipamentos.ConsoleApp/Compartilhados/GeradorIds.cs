namespace RealGestaoDeEquipamentos.ConsoleApp.Compartilhados
{
    public static class GeradorIds
    {
        public static int EquipmentsId = 0;
        public static int CallsId = 0;

        public static int CreateEquipmentId ()
        {
            EquipmentsId++;

            return EquipmentsId;
        }
        public static int CreateCallId()
        {
            CallsId++;

            return CallsId;
        }
    }
}
