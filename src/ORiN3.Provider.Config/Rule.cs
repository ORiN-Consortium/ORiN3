namespace ORiN3.Provider.Config;

public record Rule(string Type, decimal? Minimum, decimal? Maximum, string? Pattern, bool Secret);
