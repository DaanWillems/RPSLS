using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSLSService;

namespace ServiceTests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void LizardSpock()
        {
            //--Build
            Service s = new Service();
            PlayAttempt attempt = new PlayAttempt()
            {
                PlayerName = "Daan",
                PlayerSymbol = RPSLSService.Symbols.Scissor,
                ComputerSymbol = RPSLSService.Symbols.Lizard
            };
            //--Run
            PlayAttempt result = s.DoPlay(attempt);
            //--Assess
            Assert.AreEqual(result.Winner, "Player");
        }

        [TestMethod]
        public void RockPaper()
        {
            //--Build
            Service s = new Service();
            PlayAttempt attempt = new PlayAttempt()
            {
                PlayerName = "Daan",
                PlayerSymbol = RPSLSService.Symbols.Rock,
                ComputerSymbol = RPSLSService.Symbols.Paper
            };
            //--Run
            PlayAttempt result = s.DoPlay(attempt);
            //--Assess
            Assert.AreEqual(result.Winner, "Computer");
        }

        [TestMethod]
        public void ScissorLizzard()
        {
            //--Build
            Service s = new Service();
            PlayAttempt attempt = new PlayAttempt()
            {
                PlayerName = "Daan",
                PlayerSymbol =  RPSLSService.Symbols.Scissor,
                ComputerSymbol = RPSLSService.Symbols.Lizard
            };
            //--Run
            PlayAttempt result = s.DoPlay(attempt);
            //--Assess
            Assert.AreEqual(result.Winner, "Player");
        }

        [TestMethod]
        public void ScissorRock()
        {
            //--Build
            Service s = new Service();
            PlayAttempt attempt = new PlayAttempt()
            {
                PlayerName = "Daan",
                PlayerSymbol = RPSLSService.Symbols.Scissor,
                ComputerSymbol = RPSLSService.Symbols.Rock
            };
            //--Run
            PlayAttempt result = s.DoPlay(attempt);
            //--Assess
            Assert.AreEqual(result.Winner, "Computer");
        }

        [TestMethod]
        public void ScissorScissor()
        {
            //--Build
            Service s = new Service();
            PlayAttempt attempt = new PlayAttempt()
            {
                PlayerName = "Daan",
                PlayerSymbol = RPSLSService.Symbols.Scissor,
                ComputerSymbol = RPSLSService.Symbols.Scissor
            };
            //--Run
            PlayAttempt result = s.DoPlay(attempt);
            //--Assess
            Assert.AreEqual(result.Winner, "Tie");
        }
    }
}
