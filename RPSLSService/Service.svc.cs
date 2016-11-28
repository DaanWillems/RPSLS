using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RPSLSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        PlayAttempt _attempt = new PlayAttempt();

        Dictionary<string, List<string>> Symbols = new Dictionary<string, List<string>>()
        {
            { "Rock", new List<string>()
                {
                    "Scissor",
                    "Lizard"
                }
            },
            { "Paper", new List<string>()
                {
                    "Rock",
                    "Spock"
                }
            },
            { "Scissor", new List<string>()
                {
                    "Paper",
                    "Lizard"
                }
            },
            { "Lizard", new List<string>()
                {
                    "Paper",
                    "Spock"
                }
            },
            { "Spock", new List<string>()
                {
                    "Rock",
                    "Scissor"
                }
            }
        };
        public PlayAttempt DoPlay(PlayAttempt value)
        {
            if (String.IsNullOrEmpty(value.ComputerSymbol))
            {
                Random rand = new Random();
                value.ComputerSymbol = Symbols.ElementAt(rand.Next(0, Symbols.Count)).Key;
            }
            if (value.ComputerSymbol.Equals(value.PlayerSymbol))
                value.Winner = "Tie";
            else if (Symbols[value.ComputerSymbol].Contains(value.PlayerSymbol))
                value.Winner = "Computer";
            else if (Symbols[value.PlayerSymbol].Contains(value.ComputerSymbol))
                value.Winner = "Player";
            return value;
        }
    }
}
