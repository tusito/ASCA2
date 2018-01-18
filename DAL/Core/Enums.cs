// ===============================
// roberto.garcia@transmaquila.com
// www.transmaquila.com
// ===============================

using System;

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
}
