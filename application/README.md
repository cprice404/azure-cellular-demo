# Azure Cellular Architecture Demo: Application Components

This directory contains the 3 application components for the simple application that we use to demonstrate
cellular architecture automation.

The application components themselves aren't all that interesting relative to the Pipelines and CellBootstrap; they're
really just placeholders to demonstrate the cellular automation concepts.

The subdirectories include:

* [Core](./Core) - a CDKTF stack that contains common infrastructure to be re-used by other applicaion
  components; e.g. Kubernetes clusters, virtual networks, etc.
* [TimeService](./TimeService) - a k8s application that returns the current time, along with scripts and manifests to
  deploy it.
* [HelloService](./HelloService) - an Azure WebApp that calls the time service to get the current time, and then returns
  a greeting message to the caller. Uses CDKTF to deploy to the Azure WebApp service.