#!/usr/bin/env bash

set -e
set -x

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

pushd $SCRIPT_DIR
  ./build-and-push-docker-image.sh
popd

pushd ${SCRIPT_DIR}/../infrastructure
  npm run deploy -- --auto-approve
popd
