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


       Dictionary<Symbols, List<Symbols>> Symbols = new Dictionary<Symbols, List<Symbols>>()
        {
            {RPSLSService.Symbols.Rock, new List<Symbols>()
                {
                    RPSLSService.Symbols.Scissor,
                    RPSLSService.Symbols.Lizard
                }
            },
            {RPSLSService.Symbols.Paper, new List<Symbols>()
                {
                    RPSLSService.Symbols.Rock,
                    RPSLSService.Symbols.Spock
                }
            },
            { RPSLSService.Symbols.Scissor, new List<Symbols>()
                {
                    RPSLSService.Symbols.Paper,
                    RPSLSService.Symbols.Lizard
                }
            },
            { RPSLSService.Symbols.Lizard, new List<Symbols>()
                {
                    RPSLSService.Symbols.Paper,
                    RPSLSService.Symbols.Spock
                }
            },
            { RPSLSService.Symbols.Spock, new List<Symbols>()
                {
                    RPSLSService.Symbols.Rock,
                    RPSLSService.Symbols.Scissor
                }
            }
        };
        
        public PlayAttempt DoPlay(PlayAttempt value)
        {
            if (value.ComputerSymbol == RPSLSService.Symbols.Empty)
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
