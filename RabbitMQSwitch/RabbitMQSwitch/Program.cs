using System;
using System.ServiceProcess;
using System.Threading;

public class Program
{
    private const string ServiceName = "RabbitMQ";
    private static ServiceController _serviceController;

    static void Main(string[] args)
    {
        _serviceController = new ServiceController(ServiceName);

        DisplayServiceStatus();

        string command = GetCommand();

        if (command == "start")
        {
            StartRabbitMQService();
        }
        else if (command == "stop")
        {
            StopRabbitMQService();
        }
        else
        {
            Console.WriteLine("Invalid command. Use [Start], [Stop], or [Exit].");
        }
        DisplayServiceStatus();
        Console.WriteLine("Press Any Key to Exit.");
        Console.ReadKey();
    }

    private static string GetCommand()
    {
        if (_serviceController.Status == ServiceControllerStatus.Stopped || _serviceController.Status == ServiceControllerStatus.StopPending)
        {
            return "start";
        }
        if (_serviceController.Status == ServiceControllerStatus.Running || _serviceController.Status == ServiceControllerStatus.StartPending)
        {
            return "stop";
        }
        return string.Empty;
    }

    private static void DisplayServiceStatus()
    {
        // Refresh the status from the Service Control Manager
        _serviceController.Refresh();
        Console.WriteLine($"\nCurrent Status of {ServiceName}: {_serviceController.Status}");
    }

    private static void StartRabbitMQService()
    {
        Console.WriteLine($"Attempting to start {ServiceName}...");
        try
        {
            _serviceController.Start();
            // Wait for the service to actually reach the Running state
            _serviceController.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(3));
            Console.WriteLine($"{ServiceName} started successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error starting {ServiceName}: {ex.Message}");
            Console.WriteLine("Note: You may need to run this console app as an Administrator.");
        }
    }

    private static void StopRabbitMQService()
    {
        Console.WriteLine($"Attempting to stop {ServiceName}...");
        try
        {
            _serviceController.Stop();
            // Wait for the service to actually reach the Stopped state
            _serviceController.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(3));
            Console.WriteLine($"{ServiceName} stopped successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error stopping {ServiceName}: {ex.Message}");
            Console.WriteLine("Note: You may need to run this console app as an Administrator.");
        }
    }
}
