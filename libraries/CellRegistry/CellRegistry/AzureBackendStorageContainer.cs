namespace CellRegistry;

public record struct AzureBackendStorageContainer(
    string ResourceGroupName,
    string StorageAccountName,
    string ContainerName
);