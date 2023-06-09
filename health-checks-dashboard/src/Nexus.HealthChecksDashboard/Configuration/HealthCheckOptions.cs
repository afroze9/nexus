﻿namespace Nexus.HealthChecksDashboard.Configuration;

public class HealthCheckOptions
{
    public HealthCheckClient[]? Clients { get; set; }

    public int IntervalInSeconds { get; set; }
}

public class HealthCheckClient
{
    public string Name { get; set; } = string.Empty;
    public string ServiceName { get; set; } = string.Empty;
}