using RealGestaoDeEquipamentos.ConsoleApp.Compartilhados;
using RealGestaoDeEquipamentos.ConsoleApp.ModuloChamados;

namespace RealGestaoDeEquipamentos.ConsoleApp
{
    public class CallsRepository
    {
        public Call[] calls = new Call[100];
        public int CounterCalls = 0;
        public void RegisterCall(Call newCall)
        {
            calls[CounterCalls] = newCall;
            CounterCalls++;
            newCall.Id = GeradorIds.CreateCallId();

        }
    }
}
