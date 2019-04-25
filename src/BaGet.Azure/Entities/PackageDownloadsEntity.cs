using BaGet.Core.Entities;
using Microsoft.Azure.Cosmos.Table;

namespace BaGet.Azure
{
    /// <summary>
    /// The Azure Table Storage entity to update the <see cref="Package.Downloads"/> column.
    /// The <see cref="TableEntity.PartitionKey"/> is the <see cref="Package.Id"/> and
    /// the <see cref="TableEntity.RowKey"/> is the <see cref="Package.Version"/>.
    /// </summary>
    public partial class TablePackageService
    {
        private class PackageDownloadsEntity : TableEntity
        {
            public PackageDownloadsEntity()
            {
            }

            public long Downloads { get; set; }
        }
    }
}