using System.ComponentModel;

namespace Exceptions.Enums
{
    public enum AccountType
    {
        [Description("Conta Corrente")]
        CC,
        [Description("Conta Poupança")]
        CP
    }
}
