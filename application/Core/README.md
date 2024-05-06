# Azure Cellular Architecture Demo: Application Core Infrastructure

This directory contains one of three application components for the simple application that we use to demonstrate
cellular architecture automation. This component is a CDKTF stack that contains common infrastructure to be re-used by other applicaion
components; e.g. Kubernetes clusters, virtual networks, etc.

The application components themselves aren't all that interesting relative to the Pipelines and CellBootstrap; they're
really just placeholders to demonstrate the cellular automation concepts. The most noteworthy thing about this component
is that other components may have dependencies on the resources it creates, so this will be the first component that
gets deployed when you bootstrap a new cell.
