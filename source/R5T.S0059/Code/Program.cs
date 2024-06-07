using System;


namespace R5T.S0059
{
    class Program
    {
        static void Main()
        {
            var writer = Console.Out;

            // No initial blank line.
            var systemEnvironmentMachineNamePropertyName = "System.Environment.MachineName";

            writer.WriteLine($"{Instances.Values.ProgramName}: Script providing the machine name as .NET would see it, using the {systemEnvironmentMachineNamePropertyName} value.");
            writer.WriteLine();

            var machineName = Instances.MachineNameOperator.GetMachineName();

            writer.WriteLine();
            writer.WriteLine($"Machine name: {machineName}");

            Console.WriteLine(); // Blank.
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}