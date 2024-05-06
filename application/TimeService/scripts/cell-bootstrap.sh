#!/usr/bin/env bash

set -e
set -x

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

export KUBECONFIG=${SCRIPT_DIR}/../../Core/infrastructure/azurek8s_kube_config

pushd $SCRIPT_DIR
  ./build-and-push-docker-image.sh
  ./apply-k8s-manifests.sh
  ./store-loadbalancer-address-to-appconfig.sh
popd
