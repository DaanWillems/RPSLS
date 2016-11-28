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
                PlayerSymbol = "Lizard",
                ComputerSymbol = "Spock"
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
                PlayerSymbol = "Rock",
                ComputerSymbol = "Paper"
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
                PlayerSymbol = "Scissor",
                ComputerSymbol = "Lizard"
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
                PlayerSymbol = "Scissor",
                ComputerSymbol = "Rock"
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
                PlayerSymbol = "Scissor",
                ComputerSymbol = "Scissor"
            };
            //--Run
            PlayAttempt result = s.DoPlay(attempt);
            //--Assess
            Assert.AreEqual(result.Winner, "Tie");
        }
    }
}
