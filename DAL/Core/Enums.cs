// ===============================
// roberto.garcia@transmaquila.com
// www.transmaquila.com
// ===============================


namespace DAL.Core
{
    public enum Gender
    {
        None,
        Female,
        Male
    }

    public enum RelationshipType
    {
        Spouse,
        Child,
        Parent
    }


    public enum PhoneType
    {
        Cell,
        Office,
        Company,
        Home
    }



    public enum EmailType
    {
        Personl,
        Work,
        Other
    }
    public enum UniqueIdType
    {
        SSN,
        CURP,
        RFC
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Inquiry,
        Transfer
    }

    public enum Status
    {
        Active,
        Inactive
    }

    public enum CommandState
    {
        Unprocessed,
        ExecuteFailed,
        ExecuteSucceeded,
        UndoFailed,
        UndoSucceeded
    }
}
