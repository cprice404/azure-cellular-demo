#!/usr/bin/env bash

set -e
set -x

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"
export KUBECONFIG=${SCRIPT_DIR}/../../Core/infrastructure/azurek8s_kube_config

TIME_SERVICE_IP=$(kubectl get services timeservice -o json | jq -r '.status.loadBalancer.ingress[0].ip')
# Loop until we get an ip from k8s
while [ "$TIME_SERVICE_IP" == "null" ]; do
    echo "Error: TIME_SERVICE_IP is not set. Waiting for it to be set..."
    sleep 5  # Wait for 1 second before checking again
    TIME_SERVICE_IP=$(kubectl get services timeservice -o json | jq -r '.status.loadBalancer.ingress[0].ip')
done

echo "Time service ip is: ${TIME_SERVICE_IP}"
az appconfig kv set --name azure-cellular-demo-appconfig --key timeservice_address --value $TIME_SERVICE_IP --yes

