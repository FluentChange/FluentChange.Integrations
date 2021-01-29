using System;
using System.Collections.Generic;
using System.Text;

namespace FluentChange.Integrations.FinaApi.Models
{
    public static class ConnectStatus
    {
        public const string COMPLETED = "COMPLETED";
        public const string NOT_YET_OPENED = "NOT_YET_OPENED";
        public const string IN_PROGRESS = "IN_PROGRESS";
        public const string ABORTED = "ABORTED";

    }


    
    public enum ConnectionImportResponseCode
    {
        // https://docs.finapi.io/#!/Bank_Connections/importBankConnection
        Imported = 201,
        BadRequest = 400,
        AuthenticationError = 401,
        NotAllowed = 403,
        ConnectionProblem = 422,
        NeedWebForm = 451,
        UnexpectedError = 500,
        BankNotSupported = 501,
        BankNeedsAddtionalInfo = 510

    }

    public static class ConnectionStatus
    {
        public const string IN_PROGRESS = "IN_PROGRESS";
        public const string READY = "READY";
    }
}
