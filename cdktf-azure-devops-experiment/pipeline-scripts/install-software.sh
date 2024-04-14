#!/usr/bin/env bash

set -e
set -x

echo "foo is '$FOO'"
echo "bar is '$BAR'"

env
which node
node --version
which npm
npm --version
which terraform
terraform --version
which dotnet
dotnet --version
