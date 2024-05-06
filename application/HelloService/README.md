# Azure Cellular Architecture Demo: HelloService Application Component

This directory contains one of three application components for the simple application that we use to demonstrate
cellular architecture automation. This component is an Azure WebApp that calls the TimeService to get the current time, and then returns
a greeting message to the caller. Uses CDKTF to deploy to the Azure WebApp service.

The application components themselves aren't all that interesting relative to the Pipelines and CellBootstrap; they're
really just placeholders to demonstrate the cellular automation concepts. The most noteworthy thing about this component
is that it has a dependency on the TimeService application, so we use Azure AppConfig to make the address of the deployed
TimeService k8s load balancer available to this HelloService, so that it can find it and call it at runtime.
