# Azure Cellular Architecture Demo: Cell Registry

This directory contains a library that provides basic metadata (subscription id, storage container information for
cdktf state, etc.) for all known cells. The library can be used by any other programs that need to interact with the
infrastructure for the cells; they can look up cells by name, by subscription id, etc.

This allows us to centralize all the metadata that we need for deployments and avoid repeating it across the infrastructure
code for every application component.

In this particular implementation the cell metadata is hard-coded in the `HardCodedCellRegistry` class, so it requires
a code change and an update to the library version in order to add, remove, or change cell metadata. In a more real-world,
large-scale production environment, you might store the cell metadata in a database or in a JSON file on a blob store so
that it could be modified independently of the library. Then the library would just be responsible for looking it up,
so that the data can be consumed by any infrastructure code that needs it.