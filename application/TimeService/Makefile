.PHONY: all
all: precommit

.PHONY: precommit
## Run clean-build and test as a step before committing.
precommit: clean build lint test

.PHONY: clean
clean:
	echo "Nothing to do for clean for now."

.PHONY: build
build:
	echo "Nothing to do for build for now."

.PHONY: lint
lint:
	echo "Nothing to do for lint for now."

.PHONY: test
test:
	echo "Nothing to do for test for now."

.PHONY: cell-bootstrap
cell-bootstrap:
	dotnet build
	./build-and-push-docker-image.sh
	./cdktf-deploy.sh

pipeline-build:
	npm run build



.PHONY: cell-teardown
cell-teardown:
	echo "TimeService is an AKS app, thus it will be torn down when the AKS cluster is torn down. No actions taken for now."