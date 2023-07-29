using System.Diagnostics;

namespace SteamShutdown.Actions
{
    public class Shutdown : Action
    {
        public override string Name { get; protected set; } = "关机";

        public override void Execute()
        {
            base.Execute();
            Process.Start("shutdown", "/s /t 0");
        }
    }
}
