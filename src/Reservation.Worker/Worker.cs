namespace Reservation.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(
        CancellationToken stoppingToken)
    {
        _logger.LogInformation(
            "Reservation Worker da khoi dong."
        );

        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation(
                "Worker dang cho yeu cau dat muon sach: {time}",
                DateTimeOffset.Now
            );

            await Task.Delay(5000, stoppingToken);
        }
    }
}