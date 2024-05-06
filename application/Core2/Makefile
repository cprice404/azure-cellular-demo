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
	./scripts/cell-bootstrap.sh

.PHONY: cell-teardown
cell-teardown:
	./scripts/cell-teardown.sh