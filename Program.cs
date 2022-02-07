using dotnet_5_httpclient_rest_bind;
using Serilog;

var logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .WriteTo.Console()
    .CreateLogger();

var tester = new BindTester(logger);
await tester.DiscoverInterfacesAsync();

logger.Information("all addresses: {List}", tester.DiscoveredAddresses);
logger.Information("public interfaces: {List}", tester.PublicInterfaces);
logger.Information("private interfaces: {List}", tester.PrivateInterfaces);
