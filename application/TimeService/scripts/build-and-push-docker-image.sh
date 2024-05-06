#!/usr/bin/env bash

set -e
set -x

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

if [ -z "$CELL_NAME" ]; then
    echo "Error: CELL_NAME is not set."
    exit 1
fi

export VERSION=$(git rev-list --count HEAD)
az acr login -n azurecelldemo${CELL_NAME}
pushd ${SCRIPT_DIR}/../service
   docker build -t azurecelldemo${CELL_NAME}.azurecr.io/timeservice:v${VERSION} .
   docker push azurecelldemo${CELL_NAME}.azurecr.io/timeservice:v${VERSION}
popd
