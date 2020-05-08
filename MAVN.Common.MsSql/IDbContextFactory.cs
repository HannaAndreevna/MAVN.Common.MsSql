using JetBrains.Annotations;

namespace MAVN.Common.MsSql
{
    [PublicAPI]
    public interface IDbContextFactory<out T>
    {
        T CreateDataContext();

        T CreateDataContext(TransactionContext transactionContext);
    }
}