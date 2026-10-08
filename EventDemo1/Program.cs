using System;

public class TemperatureChangedEventArgs : EventArgs
{
    public double NewTemperature { get; }

    public TemperatureChangedEventArgs(double newTemperature)
    {
        NewTemperature = newTemperature;
    }
}

public class Thermostat
{
    public event EventHandler<TemperatureChangedEventArgs>? TemperatureChanged;

    private double _currentTemperature;

    public double CurrentTemperature
    {
        get => _currentTemperature;
        set
        {
            if (Math.Abs(_currentTemperature - value) > 0.01)
            {
                _currentTemperature = value;
                OnTemperatureChanged(new TemperatureChangedEventArgs(value));
            }
        }
    }

    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

public class Display
{
    public void Register(Thermostat thermostat)
    {
        thermostat.TemperatureChanged += OnTemperatureChanged;
    }

    private void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Temperature changed to: {e.NewTemperature}°C");
    }
}

internal static class Program
{
    private static void Main()
    {
        var thermostat = new Thermostat();
        var display = new Display();
        display.Register(thermostat);

        thermostat.CurrentTemperature = 21.5;
    }
}