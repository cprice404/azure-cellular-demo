#!/usr/bin/env bash

set -e
set -x

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

if [ -z "CELL_NAME" ]; then
    echo "Error: CELL_NAME is not set."
    exit 1
fi

export TIMESERVICE_VERSION=$(git rev-list --count HEAD)

pushd ${SCRIPT_DIR}/../k8s
  envsubst < deployment.yml
  envsubst < deployment.yml | kubectl apply -f -
  envsubst < service.yml | kubectl apply -f -
popd