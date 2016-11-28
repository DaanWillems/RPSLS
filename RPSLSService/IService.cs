using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RPSLSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        PlayAttempt DoPlay(PlayAttempt value);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class PlayAttempt
    {
        private string playerName;
        private string stringValue;
        private string winner;
        private DateTime _dateTime;

        private Symbols playerSymbol;
        private Symbols computerSymbol;

        [DataMember]
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

        [DataMember]
        public Symbols PlayerSymbol
        {
            get { return playerSymbol; }
            set { playerSymbol = value; }
        }

        [DataMember]
        public Symbols ComputerSymbol
        {
            get { return computerSymbol; }
            set { computerSymbol = value; }
        }


        [DataMember]
        public string Winner
        {
            get { return winner; }
            set { winner = value; }
        }

        [DataMember]
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
    }
    [DataContract]
    public enum Symbols
    {
        [EnumMember]
        Empty,
        [EnumMember]
        Rock,
        [EnumMember]
        Paper,
        [EnumMember]
        Scissor,
        [EnumMember]
        Lizard,
        [EnumMember]
        Spock

    }
}
