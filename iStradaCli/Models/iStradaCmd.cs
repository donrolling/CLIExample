using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Threading.Tasks;

namespace iStradaCli.Models
{
    [Command(Name = "istrada", OptionsComparison = System.StringComparison.InvariantCultureIgnoreCase)]
    [VersionOptionFromMember("--version", MemberName = nameof(GetVersion))]
    [Subcommand(typeof(LoginCmd), typeof(ListTicketCmd))]
    public class iStradaCmd : iStradaCmdBase
    {
        public iStradaCmd(ILogger<iStradaCmd> logger, IConsole console)
        {
            _logger = logger;
            _console = console;
        }

        protected override Task<int> OnExecute(CommandLineApplication app)
        {
            // this shows help even if the --help option isn't specified
            app.ShowHelp();
            return Task.FromResult(0);
        }

        private static string GetVersion() => typeof(iStradaCmd).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
    }
}