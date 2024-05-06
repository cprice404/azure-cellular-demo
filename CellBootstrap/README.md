# Azure Cellular Architecture Demo: Cell Bootstrap

This is a simple CLI program that can be used to bootstrap a new cell.

It uses the CellRegistry to get the basic information that it needs about the cell (Azure Subscription Id, etc.) Then,
because all the application components have standardized `Makefile` targets for bootstrapping and teardown, this program
can simply loop over each of the application components and call the appropriate `make` target.

This allows us to very rapidly create new cells hosting our application, and also makes it trivial to tear them down
to save costs if we don't need them anymore.

To run the program, use the `cell-bootstrap.sh` and `cell-teardown.sh` scripts in the root directory of the repo.