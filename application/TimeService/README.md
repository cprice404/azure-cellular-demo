# Azure Cellular Architecture Demo: TimeService Application Component

This directory contains one of three application components for the simple application that we use to demonstrate
cellular architecture automation. This component is a k8s application that returns the current time, along with scripts and manifests to
deploy it.

The application components themselves aren't all that interesting relative to the Pipelines and CellBootstrap; they're
really just placeholders to demonstrate the cellular automation concepts. The most noteworthy thing about this component
is that it is a k8s application, so it will be deployed to a Kubernetes cluster provisioned by the CDKTF stack for the
Core component. Therefore this component doesn't require any TerraForm deployment code.
