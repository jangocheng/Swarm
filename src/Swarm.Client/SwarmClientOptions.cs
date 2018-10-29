using System.Dynamic;

namespace Swarm.Client
{
    public class SwarmClientOptions
    {
        public string Host { get; set; }
        public string Group { get; set; } = "DEFAULT";
        public  string Name { get; set; }

        public string AccessToken{ get; set; }

        public int RetryTimes { get; set; } = 7200;
    }
}